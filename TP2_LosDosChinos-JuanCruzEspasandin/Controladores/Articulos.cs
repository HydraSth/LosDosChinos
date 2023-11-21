using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_LosDosChinos_JuanCruzEspasandin.Controladores;
using TP2_LosDosChinos_JuanCruzEspasandin.src;
using static TP2_LosDosChinos_JuanCruzEspasandin.Articulo;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public partial class Articulos : UserControl
    {
        public Sesion ses_act;

        public Articulos(Sesion ses_act)
        {
            InitializeComponent();
            this.ses_act = ses_act;
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            var ControladorDb = new ControladorDB();
            var response = ControladorDb.GetArticulos(ControladorDb);
            response.ForEach(articulo =>
            {
                var N = DG_Articulos.Rows.Add();
                DG_Articulos.Rows[N].Cells[0].Value = articulo.ArticuloID;
                DG_Articulos.Rows[N].Cells[1].Value = articulo.PrecioCompra;
                DG_Articulos.Rows[N].Cells[2].Value = articulo.PrecioVenta;
                DG_Articulos.Rows[N].Cells[3].Value = articulo.Detalle;
                DG_Articulos.Rows[N].Cells[4].Value = articulo.Presentacion;
                DG_Articulos.Rows[N].Cells[5].Value = articulo.Stock;
            });
        }

        private void DG_Articulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG_Articulos.CurrentRow.Cells[0].Value.ToString() != null)
            {
                Input_ArtID.Text = DG_Articulos.CurrentRow.Cells[0].Value.ToString();
                Input_PC.Text = DG_Articulos.CurrentRow.Cells[1].Value.ToString();
                Input_PV.Text = DG_Articulos.CurrentRow.Cells[2].Value.ToString();
                Input_Detalle.Text = DG_Articulos.CurrentRow.Cells[3].Value.ToString();
                Input_Presen.Text = DG_Articulos.CurrentRow.Cells[4].Value.ToString();
                Input_Stock.Text = DG_Articulos.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void Input_ArtID_TextChanged(object sender, EventArgs e)
        {
            var Conexion = new ControladorDB();
            string textoId = Input_ArtID.Text;
            var response = Conexion.ExisteArticulo(Conexion, textoId);
            if (response)
            {
                BTN_Agregar.Text = "MODIFICAR";
                BTN_Agregar.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                BTN_Agregar.Text = "AGEGAR";
                BTN_Agregar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            }
        }

        private void CargarArticulo(Articulo articulo)
        {
            var N = DG_Articulos.Rows.Add();
            DG_Articulos.Rows[N].Cells[0].Value = articulo.ArticuloID;
            DG_Articulos.Rows[N].Cells[1].Value = articulo.PrecioCompra;
            DG_Articulos.Rows[N].Cells[2].Value = articulo.PrecioVenta;
            DG_Articulos.Rows[N].Cells[3].Value = articulo.Detalle;
            DG_Articulos.Rows[N].Cells[4].Value = articulo.Presentacion;
            DG_Articulos.Rows[N].Cells[5].Value = articulo.Stock;
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (Input_ArtID.Text == "" || Input_Detalle.Text == "" || Input_Presen.Text == "" || Input_PC.Text == "" || Input_PV.Text == "" || Input_Stock.Text == "")
            {
                NotifyIcon notificacion = new NotifyIcon();
                notificacion.Icon = SystemIcons.Information;
                notificacion.Visible = true;
                notificacion.ShowBalloonTip(400, "Error", "Campos vacios", ToolTipIcon.Info);
            }
            else
            {
                if (BTN_Agregar.Text == "AGEGAR")
                {
                    var ControladorDb = new ControladorDB();
                    var ArticuloNuevo = new Articulo(long.Parse(Input_ArtID.Text), Input_Detalle.Text, Input_Presen.Text, int.Parse(Input_PC.Text), int.Parse(Input_PV.Text), int.Parse(Input_Stock.Text));
                    ArticuloValidator validator = new ArticuloValidator();
                    var resultadoValidacion = validator.Validate(ArticuloNuevo);
                    if (resultadoValidacion.IsValid)
                    {
                        var response = ControladorDb.AddArticulo(ControladorDb, ArticuloNuevo);
                        if (response)
                        {
                            NotifyIcon notificacion = new NotifyIcon();
                            notificacion.Icon = SystemIcons.Information;
                            notificacion.Visible = true;
                            notificacion.ShowBalloonTip(200, "Valido", "Producto agregado correctamente", ToolTipIcon.Info);
                        }
                        else
                        {
                            NotifyIcon notificacion = new NotifyIcon();
                            notificacion.Icon = SystemIcons.Information;
                            notificacion.Visible = true;
                            notificacion.ShowBalloonTip(400, "Error", "Error al agregar producto", ToolTipIcon.Info);
                        }
                    }
                    else
                    {
                        NotifyIcon notificacion = new NotifyIcon();
                        notificacion.Icon = SystemIcons.Information;
                        notificacion.Visible = true;
                        notificacion.ShowBalloonTip(400, "Error", resultadoValidacion.Errors[0].ErrorMessage, ToolTipIcon.Error);
                    }
                }
                else
                {
                    var ControladorDb = new ControladorDB();
                    var ArticuloNuevo = new Articulo(int.Parse(Input_ArtID.Text), Input_Detalle.Text, Input_Presen.Text, int.Parse(Input_PC.Text), int.Parse(Input_PV.Text), int.Parse(Input_Stock.Text));

                    ArticuloValidator validator = new ArticuloValidator();
                    var resultadoValidacion = validator.Validate(ArticuloNuevo);
                    if (resultadoValidacion.IsValid)
                    {
                        ControladorDb.ModificarArticulo(ControladorDb, ArticuloNuevo);
                        DG_Articulos.Rows.Clear();
                        CargarArticulos();
                        var response = ControladorDb.AddArticulo(ControladorDb, ArticuloNuevo);
                        if (response)
                        {
                            NotifyIcon notificacion = new NotifyIcon();
                            notificacion.Icon = SystemIcons.Information;
                            notificacion.Visible = true;
                            notificacion.ShowBalloonTip(200, "Valido", "Producto agregado correctamente", ToolTipIcon.Info);
                            CargarArticulo(ArticuloNuevo);
                        }
                        else
                        {
                            NotifyIcon notificacion = new NotifyIcon();
                            notificacion.Icon = SystemIcons.Information;
                            notificacion.Visible = true;
                            notificacion.ShowBalloonTip(400, "Error", "Error al agregar producto", ToolTipIcon.Error);
                        }
                    }
                    else
                    {
                        NotifyIcon notificacion = new NotifyIcon();
                        notificacion.Icon = SystemIcons.Information;
                        notificacion.Visible = true;
                        notificacion.ShowBalloonTip(400, "Error", resultadoValidacion.Errors[0].ErrorMessage, ToolTipIcon.Error);
                    }
                }
            }
            DG_Articulos.Rows.Clear();
            CargarArticulos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ControladorDb = new ControladorDB();
            ControladorDb.EliminarArticulo(ControladorDb, Input_ArtID.Text);
            DG_Articulos.Rows.Clear();
            CargarArticulos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var VentanaCamaras = new Camaras();
            VentanaCamaras.Show();
        }
    }
}