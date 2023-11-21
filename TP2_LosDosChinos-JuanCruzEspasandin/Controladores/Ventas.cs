using iText.Kernel.Colors;
using iText.Layout.Element;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TP2_LosDosChinos_JuanCruzEspasandin.src;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using Image = iTextSharp.text.Image;

namespace TP2_LosDosChinos_JuanCruzEspasandin.Controladores
{
    public partial class Ventas : UserControl
    {
        private Sesion ses_act { get; set; }

        public Ventas(Sesion sesionUsuario)
        {
            InitializeComponent();
            ses_act = sesionUsuario;
        }

        private void CargarProductos()
        {
            Input_PV.Text = "0";
            DG_Articulos.Rows.Clear();
            var ControladorDb = new ControladorDB();
            var response = ControladorDb.GetArticulos(ControladorDb);
            response.ForEach(articulo =>
            {
                var N = DG_Articulos.Rows.Add();
                DG_Articulos.Rows[N].Cells[0].Value = articulo.ArticuloID;
                DG_Articulos.Rows[N].Cells[1].Value = articulo.PrecioVenta;
                DG_Articulos.Rows[N].Cells[2].Value = articulo.Detalle;
                DG_Articulos.Rows[N].Cells[3].Value = articulo.Presentacion;
                DG_Articulos.Rows[N].Cells[4].Value = articulo.Stock;
            });
        }

        private void FiltrarProductos()
        {
            if (Input_ID.Text == "" && Input_Detalle.Text == "")
            {
                CargarProductos();
            }
            else
            {
                string identificator = Input_ID.Text;
                long id = 0;
                try
                {
                    id = Int64.Parse(identificator);
                }
                catch (FormatException) { }
                string detalle = Input_Detalle.Text;
                DG_Articulos.Rows.Clear();
                var ControladorDB = new ControladorDB();
                var response = ControladorDB.GetFilterArticulos(ControladorDB, id, detalle);
                response.ForEach(articulo =>
                {
                    var N = DG_Articulos.Rows.Add();
                    DG_Articulos.Rows[N].Cells[0].Value = articulo.ArticuloID;
                    DG_Articulos.Rows[N].Cells[1].Value = articulo.PrecioVenta;
                    DG_Articulos.Rows[N].Cells[2].Value = articulo.Detalle;
                    DG_Articulos.Rows[N].Cells[3].Value = articulo.Presentacion;
                    DG_Articulos.Rows[N].Cells[4].Value = articulo.Stock;
                });
            }
        }

        private void Ventas_VisibleChanged(object sender, EventArgs e)
        {
            Input_PV.Enabled = false;
            CargarProductos();
        }

        private void Input_ID_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarProductos();
        }

        private void Input_Detalle_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductos();
        }

        private List<ArticuloCarrito> Carrito = new List<ArticuloCarrito>();

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            ArticuloCarrito ArticuloActual = new ArticuloCarrito(int.Parse(Input_Cantidad.Text), long.Parse(Input_ID.Text), Input_Detalle.Text);

            var Controlador = new ControladorDB();
            var ArticuloSeleccionadoInfo = Controlador.GetArticulo(Controlador, ArticuloActual.Id.ToString());
            if (ArticuloActual.Cantidad > ArticuloSeleccionadoInfo.Stock)
            {
                NotifyIcon notificacion = new NotifyIcon();
                notificacion.Icon = SystemIcons.Information;
                notificacion.Visible = true;
                notificacion.ShowBalloonTip(400, "Error", "Cantidad invalida chequear stock", ToolTipIcon.Info);
            }
            else
            {
                var N = DG_Carrito.Rows.Add();
                DG_Carrito.Rows[N].Cells[0].Value = ArticuloActual.Detalle;
                DG_Carrito.Rows[N].Cells[1].Value = ArticuloActual.Cantidad;
                DG_Carrito.Rows[N].Cells[2].Value = ArticuloActual.Id;
                Carrito.Add(ArticuloActual);
                BTN_LimpiarCampos_Click();
            }
        }

        private void BTN_LimpiarCampos_Click()
        {
            Input_ID.Text = "";
            Input_Detalle.Text = "";
            Input_PV.Text = "";
            Input_Cantidad.Text = "";
        }

        private void DG_Carrito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                Carrito.RemoveAt(rowIndex);
                DG_Carrito.Rows.RemoveAt(rowIndex);
            }
        }

        private void DG_Articulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG_Articulos.CurrentRow.Cells[0].Value.ToString() != "")
            {
                Input_ID.Text = DG_Articulos.CurrentRow.Cells[0].Value.ToString();
                Input_PV.Text = DG_Articulos.CurrentRow.Cells[1].Value.ToString();
                Input_Detalle.Text = DG_Articulos.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private static void Notificacion_BalloonTipClicked(object sender, EventArgs e)
        {
            string rutaCarpeta = @"C:\Users\Usuario\Desktop\Practica Tp2\TP2_LosDosChinos-JuanCruzEspasandin\TP2_LosDosChinos-JuanCruzEspasandin\Recibos\";
            // Ruta de la carpeta que quieres abrir
            Process.Start("explorer.exe", rutaCarpeta);
        }

        private void BTN_FinalizarCompra_Click(object sender, EventArgs e)
        {
            if (Carrito.Count == 0)
            {
                NotifyIcon notificacion = new NotifyIcon();
                notificacion.Icon = SystemIcons.Error;
                notificacion.Visible = true;
                notificacion.ShowBalloonTip(400, "Error", "Carrito vacio", ToolTipIcon.Error);
            }
            else
            {
                NotifyIcon notificacion = new NotifyIcon();
                notificacion.Icon = SystemIcons.Information;
                notificacion.Visible = true;
                notificacion.ShowBalloonTip(400, "Compra exitosa", "Retire su ticket", ToolTipIcon.Info);

                // Agregar evento OnClick
                notificacion.BalloonTipClicked += Notificacion_BalloonTipClicked;

                int horaActual = DateTime.Now.Hour;
                int minutosActuales = DateTime.Now.Minute;
                string rutaCarpeta = $@"C:\Users\Usuario\Desktop\Practica Tp2\TP2_LosDosChinos-JuanCruzEspasandin\TP2_LosDosChinos-JuanCruzEspasandin\Recibos\PdfRecibo{horaActual.ToString("00")}{minutosActuales.ToString("00")}{ses_act.SesionId}.pdf";

                FileStream fs = new FileStream(rutaCarpeta, FileMode.Create);
                Document doc = new Document(PageSize.A8, 2, 2, 2, 2);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                string LogoPath = @"C:\Users\Usuario\Desktop\Practica Tp2\TP2_LosDosChinos-JuanCruzEspasandin\TP2_LosDosChinos-JuanCruzEspasandin\src\logo_Logo.png";

                // Crear una tabla con 1 fila y 3 columnas
                PdfPTable header = new PdfPTable(3);
                header.WidthPercentage = 100;

                // Añadir celdas vacías en las esquinas
                header.AddCell(new PdfPCell() { Border = PdfPCell.NO_BORDER });

                // Añadir celda con la imagen en el medio
                PdfPCell imageCell = new PdfPCell();
                Image img = Image.GetInstance(LogoPath);
                imageCell.AddElement(img);
                imageCell.Border = PdfPCell.NO_BORDER;
                header.AddCell(imageCell);

                // Añadir celdas vacías en las esquinas
                header.AddCell(new PdfPCell() { Border = PdfPCell.NO_BORDER });

                // Agregar la tabla al documento
                doc.Add(header);

                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, iTextSharp.text.Font.BOLD, BaseColor.DARK_GRAY);
                iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);
                iTextSharp.text.Font subFont = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 5, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);

                doc.Add(new iTextSharp.text.Paragraph("SANTA ROSA, LA PAMPA", subFont));
                doc.Add(new iTextSharp.text.Paragraph("AV SPINETTO 1400", subFont));
                doc.Add(new iTextSharp.text.Paragraph("Inicio de actividad comercial: 26/01/2023 ", subFont));

                doc.Add(Chunk.NEWLINE);

                doc.Add(new iTextSharp.text.Paragraph("FACTURA B (COD 001)", boldFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new iTextSharp.text.Paragraph("A CONSUMIDOR FINAL", standarFont) { Alignment = Element.ALIGN_CENTER });
                doc.Add(new iTextSharp.text.Paragraph("----------------------------------------", boldFont));

                PdfPTable subtitle = new PdfPTable(2);
                subtitle.WidthPercentage = 100;
                DateTime now = DateTime.Now;
                string soloFecha = now.ToShortDateString();
                string soloHora = now.ToLongTimeString();
                PdfPCell celdaFecha = new PdfPCell(new iTextSharp.text.Paragraph("Fecha: " + soloFecha, standarFont));
                celdaFecha.BorderWidth = 0;
                PdfPCell celdaHora = new PdfPCell(new iTextSharp.text.Paragraph("Hora: " + soloHora, standarFont));
                celdaHora.BorderWidth = 0;
                subtitle.AddCell(celdaFecha);
                subtitle.AddCell(celdaHora);
                doc.Add(subtitle);

                doc.Add(new iTextSharp.text.Paragraph("Caja: " + Math.Ceiling(new Random().NextDouble() * 5), standarFont) { IndentationLeft = 2f });
                doc.Add(new iTextSharp.text.Paragraph("----------------------------------------", boldFont));

                PdfPTable table = new PdfPTable(1);
                table.HorizontalAlignment = Element.ALIGN_LEFT;
                table.DefaultCell.Border = PdfPCell.NO_BORDER;
                table.WidthPercentage = 100;

                double total = 0;
                // Iterar a través de los artículos y agregarlos a la tabla
                var Controlador = new ControladorDB();
                foreach (ArticuloCarrito articulo in Carrito)
                {
                    Controlador.RealizarVenta(Controlador, articulo.Id.ToString(), articulo.Cantidad);

                    var ArticuloCarritoInfo = Controlador.GetArticulo(Controlador, articulo.Id.ToString());
                    table.AddCell(new PdfPCell(new Phrase(articulo.Detalle + " | " + ArticuloCarritoInfo.Presentacion, standarFont)) { BorderWidth = 0 });

                    PdfPTable tablaPrecios = new PdfPTable(2);
                    tablaPrecios.WidthPercentage = 100;
                    tablaPrecios.DefaultCell.BorderWidth = 0;
                    tablaPrecios.AddCell(new PdfPCell(new Phrase(articulo.Cantidad.ToString() + " x " + ArticuloCarritoInfo.PrecioVenta + "$", standarFont)) { Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });
                    tablaPrecios.AddCell(new PdfPCell(new Phrase(new Chunk((articulo.Cantidad * ArticuloCarritoInfo.PrecioVenta).ToString() + "$", standarFont))) { Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                    total += articulo.Cantidad * ArticuloCarritoInfo.PrecioVenta;
                    table.AddCell(tablaPrecios);
                    table.AddCell(new PdfPCell((new iTextSharp.text.Paragraph(articulo.Id.ToString(), standarFont))) { Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT }); ;
                }
                doc.Add(table);

                doc.Add(new iTextSharp.text.Paragraph("----------------------------------------", boldFont));

                PdfPTable tablaTotal = new PdfPTable(2);
                tablaTotal.WidthPercentage = 100;
                tablaTotal.DefaultCell.BorderWidth = 0;
                tablaTotal.AddCell(new PdfPCell(new iTextSharp.text.Paragraph("TOTAL: ", boldFont)) { PaddingTop = 5f, Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_LEFT });
                tablaTotal.AddCell(new PdfPCell(new iTextSharp.text.Paragraph("$ " + total.ToString(), standarFont)) { PaddingTop = 5f, Border = PdfPCell.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT });
                doc.Add(tablaTotal);

                doc.Add(new iTextSharp.text.Paragraph("----------------------------------------", boldFont));

                doc.Close();
                fs.Close();
                CargarProductos();
            }
        }

        private static void NotificacionEtiqueta_BalloonTipClicked(object sender, EventArgs e)
        {
            string rutaCarpeta = @"C:\Users\Usuario\Desktop\Practica Tp2\TP2_LosDosChinos-JuanCruzEspasandin\TP2_LosDosChinos-JuanCruzEspasandin\Etiquetas\";
            // Ruta de la carpeta que quieres abrir
            Process.Start("explorer.exe", rutaCarpeta);
        }

        private void BTN_GenerarEtiqueta_Click(object sender, EventArgs e)
        {
            if (Input_ID.Text != "")
            {
                string rutaCarpeta = $@"C:\Users\Usuario\Desktop\Practica Tp2\TP2_LosDosChinos-JuanCruzEspasandin\TP2_LosDosChinos-JuanCruzEspasandin\Etiquetas\Etiqueta_{Input_Detalle.Text}.pdf";

                FileStream fs = new FileStream(rutaCarpeta, FileMode.Create);
                Document doc = new Document(PageSize.A9.Rotate(), 2, 0, 2, 0);
                PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                doc.Open();

                // Crear un objeto Barcode128
                Barcode128 barcode = new Barcode128();
                barcode.Code = Input_ID.Text;
                barcode.GenerateChecksum = true;

                // Obtener la imagen del código de barras
                iTextSharp.text.Image img = barcode.CreateImageWithBarcode(writer.DirectContent, BaseColor.BLACK, BaseColor.BLACK);

                iTextSharp.text.Font boldFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 10, iTextSharp.text.Font.NORMAL, BaseColor.DARK_GRAY);
                iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 6, iTextSharp.text.Font.NORMAL, BaseColor.GRAY);
                iTextSharp.text.Font subFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 10, iTextSharp.text.Font.NORMAL, BaseColor.MAGENTA);
                iTextSharp.text.Font ofertaFont = new iTextSharp.text.Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 8, iTextSharp.text.Font.NORMAL, BaseColor.WHITE);

                iTextSharp.text.Paragraph ofertaParagraph = new iTextSharp.text.Paragraph();
                doc.Add(new iTextSharp.text.Paragraph("-------------------------------------------", boldFont));

                Chunk ofertaChunk = new Chunk("OFERTA", ofertaFont);
                ofertaChunk.SetBackground(BaseColor.MAGENTA);
                ofertaParagraph.Add(ofertaChunk);

                // Alinear al centro
                ofertaParagraph.Alignment = Element.ALIGN_CENTER;

                // Agregar padding
                ofertaParagraph.SpacingBefore = 5f;
                ofertaParagraph.SpacingAfter = 5f;

                doc.Add(ofertaParagraph);

                PdfPTable table = new PdfPTable(2);
                table.DefaultCell.Border = PdfPCell.NO_BORDER;
                table.WidthPercentage = 100;
                // Crear celda de imagen

                PdfPCell imgCell = new PdfPCell();
                imgCell.Border = PdfPCell.NO_BORDER;
                imgCell.AddElement(img);
                imgCell.PaddingLeft = 5f;
                table.AddCell(imgCell);

                PdfPTable tablaDetalle = new PdfPTable(1);
                tablaDetalle.AddCell(new PdfPCell(new iTextSharp.text.Paragraph($"{Input_Detalle.Text}", boldFont)) { Border = PdfPCell.NO_BORDER, VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_LEFT });
                tablaDetalle.AddCell(new PdfPCell(new iTextSharp.text.Paragraph($"{Input_PV.Text}$", subFont)) { Border = PdfPCell.NO_BORDER, VerticalAlignment = Element.ALIGN_MIDDLE, HorizontalAlignment = Element.ALIGN_LEFT });

                table.AddCell(tablaDetalle);
                // Agregar tabla al documento
                doc.Add(table);
                doc.Add(new iTextSharp.text.Paragraph("-------------------------------------------", boldFont));

                doc.Close();
                fs.Close();

                NotifyIcon notificacion = new NotifyIcon();
                notificacion.Icon = SystemIcons.Information;
                notificacion.Visible = true;
                notificacion.ShowBalloonTip(200, "Etiqueta generada", "Haga click para visualizarla", ToolTipIcon.Info);
                // Agregar evento OnClick
                notificacion.BalloonTipClicked += NotificacionEtiqueta_BalloonTipClicked;
            }
            else
            {
                NotifyIcon notificacion = new NotifyIcon();
                notificacion.Icon = SystemIcons.Error;
                notificacion.Visible = true;
                notificacion.ShowBalloonTip(400, "Error", "Seleccione un producto para crear la etiqueta", ToolTipIcon.Error);
            }
        }
    }
}