namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    partial class Articulos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Stock = new System.Windows.Forms.Label();
            this.Input_Stock = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.LBL_PC = new System.Windows.Forms.Label();
            this.Input_PC = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_PV = new System.Windows.Forms.Label();
            this.Input_PV = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_Presen = new System.Windows.Forms.Label();
            this.Input_Presen = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_Detalle = new System.Windows.Forms.Label();
            this.Input_Detalle = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_Articulo = new System.Windows.Forms.Label();
            this.Input_ArtID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DG_Articulos = new System.Windows.Forms.DataGridView();
            this.ArticuloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Articulos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_Stock);
            this.panel1.Controls.Add(this.Input_Stock);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BTN_Agregar);
            this.panel1.Controls.Add(this.LBL_PC);
            this.panel1.Controls.Add(this.Input_PC);
            this.panel1.Controls.Add(this.LBL_PV);
            this.panel1.Controls.Add(this.Input_PV);
            this.panel1.Controls.Add(this.LBL_Presen);
            this.panel1.Controls.Add(this.Input_Presen);
            this.panel1.Controls.Add(this.LBL_Detalle);
            this.panel1.Controls.Add(this.Input_Detalle);
            this.panel1.Controls.Add(this.LBL_Articulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 409);
            this.panel1.TabIndex = 3;
            // 
            // LBL_Stock
            // 
            this.LBL_Stock.AutoSize = true;
            this.LBL_Stock.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Stock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Stock.Location = new System.Drawing.Point(13, 301);
            this.LBL_Stock.Name = "LBL_Stock";
            this.LBL_Stock.Size = new System.Drawing.Size(51, 19);
            this.LBL_Stock.TabIndex = 15;
            this.LBL_Stock.Text = "Stock";
            // 
            // Input_Stock
            // 
            this.Input_Stock.Location = new System.Drawing.Point(12, 321);
            this.Input_Stock.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Stock.Name = "Input_Stock";
            this.Input_Stock.Size = new System.Drawing.Size(152, 30);
            this.Input_Stock.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Stock.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Stock.StateCommon.Border.Rounding = 12;
            this.Input_Stock.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Stock.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Stock.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Stock.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Stock.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Stock.StateNormal.Border.Rounding = 20;
            this.Input_Stock.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(93, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.BackColor = System.Drawing.Color.White;
            this.BTN_Agregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BTN_Agregar.FlatAppearance.BorderSize = 0;
            this.BTN_Agregar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.BTN_Agregar.Location = new System.Drawing.Point(12, 358);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(83, 35);
            this.BTN_Agregar.TabIndex = 6;
            this.BTN_Agregar.Text = "AGREGAR";
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // LBL_PC
            // 
            this.LBL_PC.AutoSize = true;
            this.LBL_PC.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PC.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_PC.Location = new System.Drawing.Point(13, 187);
            this.LBL_PC.Name = "LBL_PC";
            this.LBL_PC.Size = new System.Drawing.Size(118, 19);
            this.LBL_PC.TabIndex = 12;
            this.LBL_PC.Text = "Precio compra";
            // 
            // Input_PC
            // 
            this.Input_PC.Location = new System.Drawing.Point(12, 207);
            this.Input_PC.Margin = new System.Windows.Forms.Padding(0);
            this.Input_PC.Name = "Input_PC";
            this.Input_PC.Size = new System.Drawing.Size(152, 30);
            this.Input_PC.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_PC.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_PC.StateCommon.Border.Rounding = 12;
            this.Input_PC.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_PC.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_PC.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_PC.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_PC.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_PC.StateNormal.Border.Rounding = 20;
            this.Input_PC.TabIndex = 13;
            // 
            // LBL_PV
            // 
            this.LBL_PV.AutoSize = true;
            this.LBL_PV.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_PV.Location = new System.Drawing.Point(13, 243);
            this.LBL_PV.Name = "LBL_PV";
            this.LBL_PV.Size = new System.Drawing.Size(103, 19);
            this.LBL_PV.TabIndex = 10;
            this.LBL_PV.Text = "Precio venta";
            // 
            // Input_PV
            // 
            this.Input_PV.Location = new System.Drawing.Point(12, 263);
            this.Input_PV.Margin = new System.Windows.Forms.Padding(0);
            this.Input_PV.Name = "Input_PV";
            this.Input_PV.Size = new System.Drawing.Size(152, 30);
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
            this.Input_PV.TabIndex = 11;
            // 
            // LBL_Presen
            // 
            this.LBL_Presen.AutoSize = true;
            this.LBL_Presen.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Presen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Presen.Location = new System.Drawing.Point(13, 129);
            this.LBL_Presen.Name = "LBL_Presen";
            this.LBL_Presen.Size = new System.Drawing.Size(107, 19);
            this.LBL_Presen.TabIndex = 8;
            this.LBL_Presen.Text = "Presentación";
            // 
            // Input_Presen
            // 
            this.Input_Presen.Location = new System.Drawing.Point(12, 149);
            this.Input_Presen.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Presen.Name = "Input_Presen";
            this.Input_Presen.Size = new System.Drawing.Size(152, 30);
            this.Input_Presen.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Presen.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Presen.StateCommon.Border.Rounding = 12;
            this.Input_Presen.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Presen.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Presen.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Presen.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Presen.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Presen.StateNormal.Border.Rounding = 20;
            this.Input_Presen.TabIndex = 9;
            // 
            // LBL_Detalle
            // 
            this.LBL_Detalle.AutoSize = true;
            this.LBL_Detalle.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Detalle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Detalle.Location = new System.Drawing.Point(13, 72);
            this.LBL_Detalle.Name = "LBL_Detalle";
            this.LBL_Detalle.Size = new System.Drawing.Size(62, 19);
            this.LBL_Detalle.TabIndex = 6;
            this.LBL_Detalle.Text = "Detalle";
            // 
            // Input_Detalle
            // 
            this.Input_Detalle.Location = new System.Drawing.Point(12, 92);
            this.Input_Detalle.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Detalle.Name = "Input_Detalle";
            this.Input_Detalle.Size = new System.Drawing.Size(152, 30);
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
            this.Input_Detalle.TabIndex = 7;
            // 
            // LBL_Articulo
            // 
            this.LBL_Articulo.AutoSize = true;
            this.LBL_Articulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Articulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Articulo.Location = new System.Drawing.Point(13, 17);
            this.LBL_Articulo.Name = "LBL_Articulo";
            this.LBL_Articulo.Size = new System.Drawing.Size(89, 19);
            this.LBL_Articulo.TabIndex = 1;
            this.LBL_Articulo.Text = "Articulo ID";
            // 
            // Input_ArtID
            // 
            this.Input_ArtID.Location = new System.Drawing.Point(12, 37);
            this.Input_ArtID.Margin = new System.Windows.Forms.Padding(0);
            this.Input_ArtID.Name = "Input_ArtID";
            this.Input_ArtID.Size = new System.Drawing.Size(152, 30);
            this.Input_ArtID.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_ArtID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_ArtID.StateCommon.Border.Rounding = 12;
            this.Input_ArtID.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_ArtID.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_ArtID.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_ArtID.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_ArtID.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_ArtID.StateNormal.Border.Rounding = 20;
            this.Input_ArtID.TabIndex = 5;
            this.Input_ArtID.TextChanged += new System.EventHandler(this.Input_ArtID_TextChanged);
            // 
            // DG_Articulos
            // 
            this.DG_Articulos.AllowUserToAddRows = false;
            this.DG_Articulos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DG_Articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Articulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DG_Articulos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DG_Articulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Articulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DG_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Articulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticuloID,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Detalle,
            this.Presentacion,
            this.Stock});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Articulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DG_Articulos.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DG_Articulos.Location = new System.Drawing.Point(182, 60);
            this.DG_Articulos.MultiSelect = false;
            this.DG_Articulos.Name = "DG_Articulos";
            this.DG_Articulos.ReadOnly = true;
            this.DG_Articulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Articulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DG_Articulos.RowHeadersVisible = false;
            this.DG_Articulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DG_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DG_Articulos.ShowCellErrors = false;
            this.DG_Articulos.ShowCellToolTips = false;
            this.DG_Articulos.ShowEditingIcon = false;
            this.DG_Articulos.ShowRowErrors = false;
            this.DG_Articulos.Size = new System.Drawing.Size(377, 322);
            this.DG_Articulos.TabIndex = 6;
            this.DG_Articulos.TabStop = false;
            this.DG_Articulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Articulos_CellContentClick);
            // 
            // ArticuloID
            // 
            this.ArticuloID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ArticuloID.HeaderText = "ID";
            this.ArticuloID.Name = "ArticuloID";
            this.ArticuloID.ReadOnly = true;
            this.ArticuloID.Width = 35;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioCompra.FillWeight = 37.03703F;
            this.PrecioCompra.HeaderText = "Precio compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 65;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioVenta.FillWeight = 162.963F;
            this.PrecioVenta.HeaderText = "Precio venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 65;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 45;
            // 
            // Presentacion
            // 
            this.Presentacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Presentacion.HeaderText = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            this.Presentacion.Width = 110;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 50;
            // 
            // Notificacion
            // 
            this.Notificacion.Text = "notifyIcon1";
            this.Notificacion.Visible = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.Location = new System.Drawing.Point(316, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "VER CAMARAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DG_Articulos);
            this.Controls.Add(this.Input_ArtID);
            this.Controls.Add(this.panel1);
            this.Name = "Articulos";
            this.Size = new System.Drawing.Size(584, 409);
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Articulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Articulo;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_ArtID;
        private System.Windows.Forms.Label LBL_Presen;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Presen;
        private System.Windows.Forms.Label LBL_Detalle;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Detalle;
        private System.Windows.Forms.Label LBL_PV;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_PV;
        private System.Windows.Forms.Label LBL_PC;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_PC;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.Label LBL_Stock;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Stock;
        private System.Windows.Forms.DataGridView DG_Articulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.Button button2;
    }
}
