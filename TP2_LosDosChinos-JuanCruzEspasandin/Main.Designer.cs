using System.Drawing;
using System.Windows.Forms;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.PanelMain = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresAside = new System.Windows.Forms.Panel();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnArticulos = new System.Windows.Forms.Button();
            this.ArticulosAside = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Venta = new System.Windows.Forms.Button();
            this.AsideVenta = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MiUsuarioAside = new System.Windows.Forms.Panel();
            this.BtnMiUsuario = new System.Windows.Forms.Button();
            this.Logout_Btn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logout_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.Location = new System.Drawing.Point(166, 21);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Black;
            this.PanelMain.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelCustom1;
            this.PanelMain.Size = new System.Drawing.Size(543, 449);
            this.PanelMain.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.PanelMain.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.PanelMain.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.69365F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25486F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.25486F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.68682F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.74298F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.17495F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 479);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.625F));
            this.tableLayoutPanel4.Controls.Add(this.ProveedoresAside, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.BtnProveedores, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(11, 285);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(128, 47);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // ProveedoresAside
            // 
            this.ProveedoresAside.BackColor = System.Drawing.Color.Transparent;
            this.ProveedoresAside.Location = new System.Drawing.Point(3, 3);
            this.ProveedoresAside.Name = "ProveedoresAside";
            this.ProveedoresAside.Size = new System.Drawing.Size(5, 41);
            this.ProveedoresAside.TabIndex = 24;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.BtnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnProveedores.FlatAppearance.BorderSize = 0;
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.ForeColor = System.Drawing.Color.Teal;
            this.BtnProveedores.Location = new System.Drawing.Point(12, 0);
            this.BtnProveedores.Margin = new System.Windows.Forms.Padding(0);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Size = new System.Drawing.Size(116, 47);
            this.BtnProveedores.TabIndex = 22;
            this.BtnProveedores.Text = "Proveedores";
            this.BtnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores.UseVisualStyleBackColor = false;
            this.BtnProveedores.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.625F));
            this.tableLayoutPanel1.Controls.Add(this.BtnArticulos, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ArticulosAside, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 219);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(128, 47);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // BtnArticulos
            // 
            this.BtnArticulos.BackColor = System.Drawing.Color.Transparent;
            this.BtnArticulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnArticulos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnArticulos.FlatAppearance.BorderSize = 0;
            this.BtnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnArticulos.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnArticulos.ForeColor = System.Drawing.Color.Teal;
            this.BtnArticulos.Location = new System.Drawing.Point(12, 0);
            this.BtnArticulos.Margin = new System.Windows.Forms.Padding(0);
            this.BtnArticulos.Name = "BtnArticulos";
            this.BtnArticulos.Size = new System.Drawing.Size(116, 47);
            this.BtnArticulos.TabIndex = 22;
            this.BtnArticulos.Text = "Articulos";
            this.BtnArticulos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnArticulos.UseVisualStyleBackColor = false;
            this.BtnArticulos.Click += new System.EventHandler(this.BtnArticulos_Click);
            // 
            // ArticulosAside
            // 
            this.ArticulosAside.BackColor = System.Drawing.Color.Teal;
            this.ArticulosAside.Location = new System.Drawing.Point(3, 3);
            this.ArticulosAside.Name = "ArticulosAside";
            this.ArticulosAside.Size = new System.Drawing.Size(5, 41);
            this.ArticulosAside.TabIndex = 23;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.625F));
            this.tableLayoutPanel5.Controls.Add(this.Btn_Venta, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.AsideVenta, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(11, 153);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(128, 47);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // Btn_Venta
            // 
            this.Btn_Venta.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Venta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Venta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Btn_Venta.FlatAppearance.BorderSize = 0;
            this.Btn_Venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Venta.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Venta.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Venta.Location = new System.Drawing.Point(12, 0);
            this.Btn_Venta.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Venta.Name = "Btn_Venta";
            this.Btn_Venta.Size = new System.Drawing.Size(116, 47);
            this.Btn_Venta.TabIndex = 22;
            this.Btn_Venta.Text = "Venta";
            this.Btn_Venta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Venta.UseVisualStyleBackColor = false;
            this.Btn_Venta.Click += new System.EventHandler(this.Btn_Venta_Click);
            // 
            // AsideVenta
            // 
            this.AsideVenta.BackColor = System.Drawing.Color.Transparent;
            this.AsideVenta.Location = new System.Drawing.Point(3, 3);
            this.AsideVenta.Name = "AsideVenta";
            this.AsideVenta.Size = new System.Drawing.Size(5, 41);
            this.AsideVenta.TabIndex = 24;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.375F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.625F));
            this.tableLayoutPanel3.Controls.Add(this.MiUsuarioAside, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnMiUsuario, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(11, 353);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(128, 47);
            this.tableLayoutPanel3.TabIndex = 23;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.BtnMiUsuario_Click);
            // 
            // MiUsuarioAside
            // 
            this.MiUsuarioAside.BackColor = System.Drawing.Color.Transparent;
            this.MiUsuarioAside.Location = new System.Drawing.Point(3, 3);
            this.MiUsuarioAside.Name = "MiUsuarioAside";
            this.MiUsuarioAside.Size = new System.Drawing.Size(5, 41);
            this.MiUsuarioAside.TabIndex = 24;
            // 
            // BtnMiUsuario
            // 
            this.BtnMiUsuario.BackColor = System.Drawing.Color.Transparent;
            this.BtnMiUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnMiUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnMiUsuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnMiUsuario.FlatAppearance.BorderSize = 0;
            this.BtnMiUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMiUsuario.Font = new System.Drawing.Font("Gotham", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMiUsuario.ForeColor = System.Drawing.Color.Teal;
            this.BtnMiUsuario.Location = new System.Drawing.Point(12, 0);
            this.BtnMiUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMiUsuario.Name = "BtnMiUsuario";
            this.BtnMiUsuario.Size = new System.Drawing.Size(116, 47);
            this.BtnMiUsuario.TabIndex = 22;
            this.BtnMiUsuario.Text = "Mi Usuario";
            this.BtnMiUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMiUsuario.UseVisualStyleBackColor = false;
            this.BtnMiUsuario.Click += new System.EventHandler(this.BtnMiUsuario_Click);
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logout_Btn.BackgroundImage")));
            this.Logout_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logout_Btn.Location = new System.Drawing.Point(724, 11);
            this.Logout_Btn.Margin = new System.Windows.Forms.Padding(2);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Size = new System.Drawing.Size(52, 58);
            this.Logout_Btn.TabIndex = 24;
            this.Logout_Btn.TabStop = false;
            this.Logout_Btn.Click += new System.EventHandler(this.Logout_Btn_Click);
            this.Logout_Btn.MouseLeave += new System.EventHandler(this.Logout_Btn_MouseLeave);
            this.Logout_Btn.MouseHover += new System.EventHandler(this.Logout_Btn_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 122);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 479);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.Logout_Btn);
            this.Controls.Add(this.PanelMain);
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.PanelMain)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logout_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelMain;
        private System.Windows.Forms.PictureBox Logout_Btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnArticulos;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel ProveedoresAside;
        private Button BtnProveedores;
        private Panel ArticulosAside;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel MiUsuarioAside;
        private Button BtnMiUsuario;
        private TableLayoutPanel tableLayoutPanel5;
        private Panel AsideVenta;
        private Button Btn_Venta;
        private PictureBox pictureBox1;
    }
}