namespace TP2_LosDosChinos_JuanCruzEspasandin.Controladores
{
    partial class Ventas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_FinalizarCompra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Input_Cantidad = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.LBL_PV = new System.Windows.Forms.Label();
            this.Input_ID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.Input_PV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DG_Articulos = new System.Windows.Forms.DataGridView();
            this.ArticuloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LBL_Articulo = new System.Windows.Forms.Label();
            this.Input_Detalle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_Detalle = new System.Windows.Forms.Label();
            this.LBL_Carrito = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DG_Carrito = new System.Windows.Forms.DataGridView();
            this.CarritoDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdentificadorCarrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTN_GenerarEtiqueta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Articulos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Carrito)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_FinalizarCompra
            // 
            this.BTN_FinalizarCompra.BackColor = System.Drawing.Color.White;
            this.BTN_FinalizarCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_FinalizarCompra.FlatAppearance.BorderSize = 0;
            this.BTN_FinalizarCompra.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FinalizarCompra.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.BTN_FinalizarCompra.Location = new System.Drawing.Point(180, 361);
            this.BTN_FinalizarCompra.Name = "BTN_FinalizarCompra";
            this.BTN_FinalizarCompra.Size = new System.Drawing.Size(149, 35);
            this.BTN_FinalizarCompra.TabIndex = 30;
            this.BTN_FinalizarCompra.Text = "FINALIZAR COMPRA";
            this.BTN_FinalizarCompra.UseVisualStyleBackColor = false;
            this.BTN_FinalizarCompra.Click += new System.EventHandler(this.BTN_FinalizarCompra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(215, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Cantidad";
            // 
            // Input_Cantidad
            // 
            this.Input_Cantidad.Location = new System.Drawing.Point(180, 322);
            this.Input_Cantidad.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Cantidad.Name = "Input_Cantidad";
            this.Input_Cantidad.Size = new System.Drawing.Size(149, 30);
            this.Input_Cantidad.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Cantidad.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Cantidad.StateCommon.Border.Rounding = 12;
            this.Input_Cantidad.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Cantidad.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Cantidad.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Cantidad.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Cantidad.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Cantidad.StateNormal.Border.Rounding = 20;
            this.Input_Cantidad.TabIndex = 29;
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.BackColor = System.Drawing.Color.White;
            this.BTN_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Agregar.FlatAppearance.BorderSize = 0;
            this.BTN_Agregar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BTN_Agregar.Location = new System.Drawing.Point(22, 361);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(149, 35);
            this.BTN_Agregar.TabIndex = 21;
            this.BTN_Agregar.Text = "AÑADIR AL CARRITO";
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // LBL_PV
            // 
            this.LBL_PV.AutoSize = true;
            this.LBL_PV.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_PV.Location = new System.Drawing.Point(46, 298);
            this.LBL_PV.Name = "LBL_PV";
            this.LBL_PV.Size = new System.Drawing.Size(103, 19);
            this.LBL_PV.TabIndex = 25;
            this.LBL_PV.Text = "Precio venta";
            // 
            // Input_ID
            // 
            this.Input_ID.Location = new System.Drawing.Point(19, 92);
            this.Input_ID.Margin = new System.Windows.Forms.Padding(0);
            this.Input_ID.Name = "Input_ID";
            this.Input_ID.Size = new System.Drawing.Size(143, 30);
            this.Input_ID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_ID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_ID.StateCommon.Border.Rounding = 12;
            this.Input_ID.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_ID.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_ID.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_ID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_ID.StateNormal.Border.Rounding = 20;
            this.Input_ID.TabIndex = 27;
            this.Input_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Input_ID_KeyUp);
            // 
            // Input_PV
            // 
            this.Input_PV.Location = new System.Drawing.Point(22, 322);
            this.Input_PV.Margin = new System.Windows.Forms.Padding(0);
            this.Input_PV.Name = "Input_PV";
            this.Input_PV.Size = new System.Drawing.Size(149, 30);
            this.Input_PV.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_PV.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_PV.StateCommon.Border.Rounding = 12;
            this.Input_PV.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_PV.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_PV.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_PV.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_PV.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_PV.StateNormal.Border.Rounding = 20;
            this.Input_PV.TabIndex = 26;
            // 
            // DG_Articulos
            // 
            this.DG_Articulos.AllowUserToAddRows = false;
            this.DG_Articulos.AllowUserToDeleteRows = false;
            this.DG_Articulos.AllowUserToResizeColumns = false;
            this.DG_Articulos.AllowUserToResizeRows = false;
            this.DG_Articulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DG_Articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Articulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DG_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticuloID,
            this.PrecioVenta,
            this.Detalle,
            this.Presentacion,
            this.Stock});
            this.DG_Articulos.GridColor = System.Drawing.SystemColors.Control;
            this.DG_Articulos.Location = new System.Drawing.Point(13, 136);
            this.DG_Articulos.MultiSelect = false;
            this.DG_Articulos.Name = "DG_Articulos";
            this.DG_Articulos.ReadOnly = true;
            this.DG_Articulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_Articulos.RowHeadersVisible = false;
            this.DG_Articulos.Size = new System.Drawing.Size(316, 155);
            this.DG_Articulos.TabIndex = 22;
            this.DG_Articulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Articulos_CellContentDoubleClick);
            // 
            // ArticuloID
            // 
            this.ArticuloID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ArticuloID.HeaderText = "ID";
            this.ArticuloID.Name = "ArticuloID";
            this.ArticuloID.ReadOnly = true;
            this.ArticuloID.Width = 35;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioVenta.FillWeight = 162.963F;
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 40;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Presentacion
            // 
            this.Presentacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Stock.Width = 40;
            // 
            // LBL_Articulo
            // 
            this.LBL_Articulo.AutoSize = true;
            this.LBL_Articulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Articulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Articulo.Location = new System.Drawing.Point(44, 73);
            this.LBL_Articulo.Name = "LBL_Articulo";
            this.LBL_Articulo.Size = new System.Drawing.Size(89, 19);
            this.LBL_Articulo.TabIndex = 20;
            this.LBL_Articulo.Text = "Articulo ID";
            // 
            // Input_Detalle
            // 
            this.Input_Detalle.Location = new System.Drawing.Point(178, 92);
            this.Input_Detalle.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Detalle.Name = "Input_Detalle";
            this.Input_Detalle.Size = new System.Drawing.Size(150, 30);
            this.Input_Detalle.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Detalle.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Detalle.StateCommon.Border.Rounding = 12;
            this.Input_Detalle.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Detalle.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Detalle.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Detalle.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Detalle.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Detalle.StateNormal.Border.Rounding = 20;
            this.Input_Detalle.TabIndex = 24;
            this.Input_Detalle.TextChanged += new System.EventHandler(this.Input_Detalle_TextChanged);
            // 
            // LBL_Detalle
            // 
            this.LBL_Detalle.AutoSize = true;
            this.LBL_Detalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Detalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Detalle.Location = new System.Drawing.Point(220, 72);
            this.LBL_Detalle.Name = "LBL_Detalle";
            this.LBL_Detalle.Size = new System.Drawing.Size(62, 19);
            this.LBL_Detalle.TabIndex = 23;
            this.LBL_Detalle.Text = "Detalle";
            // 
            // LBL_Carrito
            // 
            this.LBL_Carrito.AutoSize = true;
            this.LBL_Carrito.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LBL_Carrito.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Carrito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_Carrito.Location = new System.Drawing.Point(19, 35);
            this.LBL_Carrito.Name = "LBL_Carrito";
            this.LBL_Carrito.Padding = new System.Windows.Forms.Padding(35, 10, 35, 10);
            this.LBL_Carrito.Size = new System.Drawing.Size(139, 39);
            this.LBL_Carrito.TabIndex = 31;
            this.LBL_Carrito.Text = "CARRITO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.DG_Carrito);
            this.panel1.Controls.Add(this.LBL_Carrito);
            this.panel1.Location = new System.Drawing.Point(352, -14);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 450);
            this.panel1.TabIndex = 32;
            // 
            // DG_Carrito
            // 
            this.DG_Carrito.AllowUserToAddRows = false;
            this.DG_Carrito.AllowUserToResizeColumns = false;
            this.DG_Carrito.AllowUserToResizeRows = false;
            this.DG_Carrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG_Carrito.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.DG_Carrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Carrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DG_Carrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Carrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Carrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Carrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CarritoDetalle,
            this.Unidad,
            this.IdentificadorCarrito});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Carrito.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Carrito.GridColor = System.Drawing.Color.LightSeaGreen;
            this.DG_Carrito.Location = new System.Drawing.Point(15, 75);
            this.DG_Carrito.Name = "DG_Carrito";
            this.DG_Carrito.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DG_Carrito.RowHeadersVisible = false;
            this.DG_Carrito.Size = new System.Drawing.Size(148, 354);
            this.DG_Carrito.TabIndex = 32;
            this.DG_Carrito.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Carrito_CellDoubleClick);
            // 
            // CarritoDetalle
            // 
            this.CarritoDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CarritoDetalle.FillWeight = 164.467F;
            this.CarritoDetalle.HeaderText = "Detalle";
            this.CarritoDetalle.Name = "CarritoDetalle";
            this.CarritoDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CarritoDetalle.Width = 95;
            // 
            // Unidad
            // 
            this.Unidad.FillWeight = 35.53299F;
            this.Unidad.HeaderText = "U";
            this.Unidad.Name = "Unidad";
            this.Unidad.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // IdentificadorCarrito
            // 
            this.IdentificadorCarrito.HeaderText = "ID";
            this.IdentificadorCarrito.Name = "IdentificadorCarrito";
            this.IdentificadorCarrito.Visible = false;
            // 
            // BTN_GenerarEtiqueta
            // 
            this.BTN_GenerarEtiqueta.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_GenerarEtiqueta.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BTN_GenerarEtiqueta.Location = new System.Drawing.Point(95, 31);
            this.BTN_GenerarEtiqueta.Name = "BTN_GenerarEtiqueta";
            this.BTN_GenerarEtiqueta.Size = new System.Drawing.Size(143, 23);
            this.BTN_GenerarEtiqueta.TabIndex = 33;
            this.BTN_GenerarEtiqueta.Text = "GENERAR ETIQUETA";
            this.BTN_GenerarEtiqueta.UseVisualStyleBackColor = true;
            this.BTN_GenerarEtiqueta.Click += new System.EventHandler(this.BTN_GenerarEtiqueta_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BTN_GenerarEtiqueta);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BTN_FinalizarCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Input_Cantidad);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.LBL_PV);
            this.Controls.Add(this.Input_ID);
            this.Controls.Add(this.Input_PV);
            this.Controls.Add(this.DG_Articulos);
            this.Controls.Add(this.LBL_Articulo);
            this.Controls.Add(this.Input_Detalle);
            this.Controls.Add(this.LBL_Detalle);
            this.Name = "Ventas";
            this.Size = new System.Drawing.Size(528, 437);
            this.VisibleChanged += new System.EventHandler(this.Ventas_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Articulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Carrito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_FinalizarCompra;
        private System.Windows.Forms.Label label1;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Cantidad;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Label LBL_PV;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_ID;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_PV;
        private System.Windows.Forms.DataGridView DG_Articulos;
        private System.Windows.Forms.Label LBL_Articulo;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Detalle;
        private System.Windows.Forms.Label LBL_Detalle;
        private System.Windows.Forms.Label LBL_Carrito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DG_Carrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarritoDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button BTN_GenerarEtiqueta;
    }
}
