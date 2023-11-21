namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    partial class MainWindow
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.LabelHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Description = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.userTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSignIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.passwordTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.buttonSignUp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.Location = new System.Drawing.Point(319, 46);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(210, 37);
            this.LabelHeader.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(204)))));
            this.LabelHeader.StateNormal.Padding = new System.Windows.Forms.Padding(0);
            this.LabelHeader.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.TabIndex = 0;
            this.LabelHeader.Values.Text = "Los dos chinos";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(319, 83);
            this.Description.Margin = new System.Windows.Forms.Padding(0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(200, 51);
            this.Description.StateNormal.AdjacentGap = 0;
            this.Description.StateNormal.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 0);
            this.Description.TabIndex = 1;
            this.Description.Values.Text = "Facil gestión de supermercado con \r\nlas operaciones en un solo lugar.\r\n\r\n";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(319, 147);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(201, 31);
            this.userTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.userTextBox.StateCommon.Border.Rounding = 12;
            this.userTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.userTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.userTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.userTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.userTextBox.StateNormal.Border.Rounding = 20;
            this.userTextBox.TabIndex = 3;
            this.userTextBox.Text = "Ingresa tu usuario";
            this.userTextBox.Enter += new System.EventHandler(this.UserMouseEnter);
            this.userTextBox.Leave += new System.EventHandler(this.UserMouseLeave);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(319, 226);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignIn.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumAquamarine;
            this.buttonSignIn.OverrideDefault.Back.ColorAngle = 160F;
            this.buttonSignIn.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignIn.OverrideDefault.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.buttonSignIn.OverrideDefault.Border.ColorAngle = 160F;
            this.buttonSignIn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.OverrideDefault.Border.Rounding = 20;
            this.buttonSignIn.OverrideDefault.Border.Width = 1;
            this.buttonSignIn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonSignIn.Size = new System.Drawing.Size(201, 36);
            this.buttonSignIn.StateCommon.Back.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignIn.StateCommon.Back.Color2 = System.Drawing.Color.MediumAquamarine;
            this.buttonSignIn.StateCommon.Back.ColorAngle = 160F;
            this.buttonSignIn.StateCommon.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignIn.StateCommon.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.buttonSignIn.StateCommon.Border.ColorAngle = 160F;
            this.buttonSignIn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StateCommon.Border.Rounding = 20;
            this.buttonSignIn.StateCommon.Border.Width = 1;
            this.buttonSignIn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.buttonSignIn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.buttonSignIn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.StatePressed.Back.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignIn.StatePressed.Back.Color2 = System.Drawing.Color.MediumAquamarine;
            this.buttonSignIn.StatePressed.Back.ColorAngle = 20F;
            this.buttonSignIn.StatePressed.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignIn.StatePressed.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.buttonSignIn.StatePressed.Border.ColorAngle = 140F;
            this.buttonSignIn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.StatePressed.Border.Rounding = 20;
            this.buttonSignIn.StatePressed.Border.Width = 1;
            this.buttonSignIn.StateTracking.Back.Color1 = System.Drawing.Color.Honeydew;
            this.buttonSignIn.StateTracking.Back.Color2 = System.Drawing.Color.MintCream;
            this.buttonSignIn.StateTracking.Back.ColorAngle = 45F;
            this.buttonSignIn.StateTracking.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignIn.StateTracking.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.buttonSignIn.StateTracking.Border.ColorAngle = 160F;
            this.buttonSignIn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignIn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.buttonSignIn.StateTracking.Border.Rounding = 20;
            this.buttonSignIn.StateTracking.Border.Width = 1;
            this.buttonSignIn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.MediumSeaGreen;
            this.buttonSignIn.TabIndex = 2;
            this.buttonSignIn.Values.Text = "Ingresar";
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(319, 183);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(201, 31);
            this.passwordTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.passwordTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTextBox.StateCommon.Border.Rounding = 12;
            this.passwordTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.passwordTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.passwordTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.passwordTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passwordTextBox.StateNormal.Border.Rounding = 20;
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "Ingresa tu contraseña";
            this.passwordTextBox.Enter += new System.EventHandler(this.PasswordMouseEnter);
            this.passwordTextBox.Leave += new System.EventHandler(this.PasswordMouseLeave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.AutoSize = false;
            this.kryptonLabel1.Location = new System.Drawing.Point(324, 286);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(116, 16);
            this.kryptonLabel1.StateCommon.AdjacentGap = 0;
            this.kryptonLabel1.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.StateNormal.AdjacentGap = 0;
            this.kryptonLabel1.StateNormal.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 0);
            this.kryptonLabel1.StateNormal.ShortText.Color1 = System.Drawing.Color.Gray;
            this.kryptonLabel1.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 5;
            this.kryptonLabel1.Values.Text = "No estas registrado?";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(434, 282);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.buttonSignUp.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.buttonSignUp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.buttonSignUp.Size = new System.Drawing.Size(91, 25);
            this.buttonSignUp.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.buttonSignUp.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.buttonSignUp.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.buttonSignUp.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.buttonSignUp.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.buttonSignUp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.MediumSeaGreen;
            this.buttonSignUp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignUp.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.DarkOliveGreen;
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Values.Text = "Crea tu cuenta";
            this.buttonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Notificacion
            // 
            this.Notificacion.Text = "notifyIcon1";
            this.Notificacion.Visible = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(595, 368);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.buttonSignUp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Description;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox userTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton buttonSignUp;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox passwordTextBox;
        private System.Windows.Forms.NotifyIcon Notificacion;
    }
}

