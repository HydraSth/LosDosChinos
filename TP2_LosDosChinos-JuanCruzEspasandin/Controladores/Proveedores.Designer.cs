namespace TP2_LosDosChinos_JuanCruzEspasandin.Controladores
{
    partial class Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DG_Provider = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Input_Nombre = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_Stock = new System.Windows.Forms.Label();
            this.Input_Direccion = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.LBL_PC = new System.Windows.Forms.Label();
            this.Input_Celular = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_PV = new System.Windows.Forms.Label();
            this.Input_Rubro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.Input_Email = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_CUIT = new System.Windows.Forms.Label();
            this.Input_Cuit = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Provider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DG_Provider
            // 
            this.DG_Provider.AllowUserToAddRows = false;
            this.DG_Provider.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DG_Provider.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DG_Provider.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DG_Provider.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DG_Provider.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Provider.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DG_Provider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Provider.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Detalle,
            this.Presentacion,
            this.Stock});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DG_Provider.DefaultCellStyle = dataGridViewCellStyle5;
            this.DG_Provider.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DG_Provider.Location = new System.Drawing.Point(183, 60);
            this.DG_Provider.MultiSelect = false;
            this.DG_Provider.Name = "DG_Provider";
            this.DG_Provider.ReadOnly = true;
            this.DG_Provider.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DG_Provider.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DG_Provider.RowHeadersVisible = false;
            this.DG_Provider.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DG_Provider.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DG_Provider.ShowCellErrors = false;
            this.DG_Provider.ShowCellToolTips = false;
            this.DG_Provider.ShowEditingIcon = false;
            this.DG_Provider.ShowRowErrors = false;
            this.DG_Provider.Size = new System.Drawing.Size(377, 322);
            this.DG_Provider.TabIndex = 10;
            this.DG_Provider.TabStop = false;
            this.DG_Provider.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_Provider_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 55;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioCompra.FillWeight = 37.03703F;
            this.PrecioCompra.HeaderText = "CUIT";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 65;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioVenta.FillWeight = 162.963F;
            this.PrecioVenta.HeaderText = "Email";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 65;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Detalle.HeaderText = "Celular";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 65;
            // 
            // Presentacion
            // 
            this.Presentacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Presentacion.HeaderText = "Rubro";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.ReadOnly = true;
            this.Presentacion.Width = 65;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Direccion";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 80;
            // 
            // Input_Nombre
            // 
            this.Input_Nombre.Location = new System.Drawing.Point(13, 37);
            this.Input_Nombre.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Nombre.Name = "Input_Nombre";
            this.Input_Nombre.Size = new System.Drawing.Size(152, 30);
            this.Input_Nombre.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Nombre.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Nombre.StateCommon.Border.Rounding = 12;
            this.Input_Nombre.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Nombre.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Nombre.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Nombre.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Nombre.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Nombre.StateNormal.Border.Rounding = 20;
            this.Input_Nombre.TabIndex = 9;
            this.Input_Nombre.TextChanged += new System.EventHandler(this.Input_Nombre_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_Stock);
            this.panel1.Controls.Add(this.Input_Direccion);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BTN_Agregar);
            this.panel1.Controls.Add(this.LBL_PC);
            this.panel1.Controls.Add(this.Input_Celular);
            this.panel1.Controls.Add(this.LBL_PV);
            this.panel1.Controls.Add(this.Input_Rubro);
            this.panel1.Controls.Add(this.LBL_Email);
            this.panel1.Controls.Add(this.Input_Email);
            this.panel1.Controls.Add(this.LBL_CUIT);
            this.panel1.Controls.Add(this.Input_Cuit);
            this.panel1.Controls.Add(this.LBL_Nombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 411);
            this.panel1.TabIndex = 8;
            // 
            // LBL_Stock
            // 
            this.LBL_Stock.AutoSize = true;
            this.LBL_Stock.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Stock.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Stock.Location = new System.Drawing.Point(13, 301);
            this.LBL_Stock.Name = "LBL_Stock";
            this.LBL_Stock.Size = new System.Drawing.Size(80, 19);
            this.LBL_Stock.TabIndex = 15;
            this.LBL_Stock.Text = "Direccion";
            // 
            // Input_Direccion
            // 
            this.Input_Direccion.Location = new System.Drawing.Point(12, 321);
            this.Input_Direccion.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Direccion.Name = "Input_Direccion";
            this.Input_Direccion.Size = new System.Drawing.Size(152, 30);
            this.Input_Direccion.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Direccion.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Direccion.StateCommon.Border.Rounding = 12;
            this.Input_Direccion.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Direccion.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Direccion.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Direccion.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Direccion.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Direccion.StateNormal.Border.Rounding = 20;
            this.Input_Direccion.TabIndex = 16;
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
            this.LBL_PC.Size = new System.Drawing.Size(61, 19);
            this.LBL_PC.TabIndex = 12;
            this.LBL_PC.Text = "Celular";
            // 
            // Input_Celular
            // 
            this.Input_Celular.Location = new System.Drawing.Point(12, 207);
            this.Input_Celular.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Celular.Name = "Input_Celular";
            this.Input_Celular.Size = new System.Drawing.Size(152, 30);
            this.Input_Celular.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Celular.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Celular.StateCommon.Border.Rounding = 12;
            this.Input_Celular.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Celular.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Celular.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Celular.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Celular.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Celular.StateNormal.Border.Rounding = 20;
            this.Input_Celular.TabIndex = 13;
            // 
            // LBL_PV
            // 
            this.LBL_PV.AutoSize = true;
            this.LBL_PV.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_PV.Location = new System.Drawing.Point(13, 243);
            this.LBL_PV.Name = "LBL_PV";
            this.LBL_PV.Size = new System.Drawing.Size(55, 19);
            this.LBL_PV.TabIndex = 10;
            this.LBL_PV.Text = "Rubro";
            // 
            // Input_Rubro
            // 
            this.Input_Rubro.Location = new System.Drawing.Point(12, 263);
            this.Input_Rubro.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Rubro.Name = "Input_Rubro";
            this.Input_Rubro.Size = new System.Drawing.Size(152, 30);
            this.Input_Rubro.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Rubro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Rubro.StateCommon.Border.Rounding = 12;
            this.Input_Rubro.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Rubro.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Rubro.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Rubro.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Rubro.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Rubro.StateNormal.Border.Rounding = 20;
            this.Input_Rubro.TabIndex = 11;
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Email.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Email.Location = new System.Drawing.Point(13, 129);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(50, 19);
            this.LBL_Email.TabIndex = 8;
            this.LBL_Email.Text = "Email";
            // 
            // Input_Email
            // 
            this.Input_Email.Location = new System.Drawing.Point(12, 149);
            this.Input_Email.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Email.Name = "Input_Email";
            this.Input_Email.Size = new System.Drawing.Size(152, 30);
            this.Input_Email.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Email.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Email.StateCommon.Border.Rounding = 12;
            this.Input_Email.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Email.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Email.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Email.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Email.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Email.StateNormal.Border.Rounding = 20;
            this.Input_Email.TabIndex = 9;
            // 
            // LBL_CUIT
            // 
            this.LBL_CUIT.AutoSize = true;
            this.LBL_CUIT.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CUIT.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_CUIT.Location = new System.Drawing.Point(13, 72);
            this.LBL_CUIT.Name = "LBL_CUIT";
            this.LBL_CUIT.Size = new System.Drawing.Size(45, 19);
            this.LBL_CUIT.TabIndex = 6;
            this.LBL_CUIT.Text = "CUIT";
            // 
            // Input_Cuit
            // 
            this.Input_Cuit.Location = new System.Drawing.Point(12, 92);
            this.Input_Cuit.Margin = new System.Windows.Forms.Padding(0);
            this.Input_Cuit.Name = "Input_Cuit";
            this.Input_Cuit.Size = new System.Drawing.Size(152, 30);
            this.Input_Cuit.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Input_Cuit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Cuit.StateCommon.Border.Rounding = 12;
            this.Input_Cuit.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.Input_Cuit.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Input_Cuit.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.Input_Cuit.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.Input_Cuit.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Input_Cuit.StateNormal.Border.Rounding = 20;
            this.Input_Cuit.TabIndex = 7;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LBL_Nombre.Location = new System.Drawing.Point(13, 17);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(72, 19);
            this.LBL_Nombre.TabIndex = 1;
            this.LBL_Nombre.Text = "Nombre";
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DG_Provider);
            this.Controls.Add(this.Input_Nombre);
            this.Controls.Add(this.panel1);
            this.Name = "Proveedores";
            this.Size = new System.Drawing.Size(568, 411);
            this.Load += new System.EventHandler(this.Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_Provider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DG_Provider;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LBL_Stock;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Direccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Label LBL_PC;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Celular;
        private System.Windows.Forms.Label LBL_PV;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Rubro;
        private System.Windows.Forms.Label LBL_Email;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Email;
        private System.Windows.Forms.Label LBL_CUIT;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox Input_Cuit;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}
