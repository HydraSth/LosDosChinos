using System.Drawing;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    partial class SignUp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.LabelHeader = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Description = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.UsuarioTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.userLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.passwordLabel = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ContraseñaTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.CorreoTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TelefonoTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NombreTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ApellidoTextBox = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.SignInBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelHeader
            // 
            this.LabelHeader.Location = new System.Drawing.Point(96, 30);
            this.LabelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.LabelHeader.Name = "LabelHeader";
            this.LabelHeader.Size = new System.Drawing.Size(186, 47);
            this.LabelHeader.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(158)))), ((int)(((byte)(123)))));
            this.LabelHeader.StateNormal.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(204)))));
            this.LabelHeader.StateNormal.Padding = new System.Windows.Forms.Padding(0);
            this.LabelHeader.StateNormal.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeader.TabIndex = 1;
            this.LabelHeader.Values.Text = "Registrate";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(65, 73);
            this.Description.Margin = new System.Windows.Forms.Padding(0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(273, 63);
            this.Description.StateNormal.AdjacentGap = 0;
            this.Description.StateNormal.Padding = new System.Windows.Forms.Padding(-1, -1, -1, 0);
            this.Description.TabIndex = 2;
            this.Description.Values.Text = "Completa los campos con informacion\r\nvalida y recorda tu contraseña.\r\n\r\n";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(64, 222);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(201, 34);
            this.UsuarioTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.UsuarioTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UsuarioTextBox.StateCommon.Border.Rounding = 12;
            this.UsuarioTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.UsuarioTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.UsuarioTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.UsuarioTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.UsuarioTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.UsuarioTextBox.StateNormal.Border.Rounding = 20;
            this.UsuarioTextBox.TabIndex = 4;
            this.UsuarioTextBox.Text = "Ingresa tu usuario";
            this.UsuarioTextBox.Enter += new System.EventHandler(this.UsuarioTextBox_Enter);
            this.UsuarioTextBox.Leave += new System.EventHandler(this.UsuarioTextBox_Leave);
            // 
            // userLabel
            // 
            this.userLabel.Location = new System.Drawing.Point(64, 199);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(71, 23);
            this.userLabel.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.userLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))), ((int)(((byte)(123)))));
            this.userLabel.StateCommon.ShortText.ColorAngle = 0F;
            this.userLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.TabIndex = 5;
            this.userLabel.Values.Text = "Usuario";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(287, 199);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(101, 23);
            this.passwordLabel.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.passwordLabel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))), ((int)(((byte)(123)))));
            this.passwordLabel.StateCommon.ShortText.ColorAngle = 0F;
            this.passwordLabel.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Values.Text = "Contraseña";
            // 
            // ContraseñaTextBox
            // 
            this.ContraseñaTextBox.Location = new System.Drawing.Point(287, 222);
            this.ContraseñaTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ContraseñaTextBox.Name = "ContraseñaTextBox";
            this.ContraseñaTextBox.Size = new System.Drawing.Size(201, 34);
            this.ContraseñaTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ContraseñaTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ContraseñaTextBox.StateCommon.Border.Rounding = 12;
            this.ContraseñaTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ContraseñaTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ContraseñaTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.ContraseñaTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.ContraseñaTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ContraseñaTextBox.StateNormal.Border.Rounding = 20;
            this.ContraseñaTextBox.TabIndex = 6;
            this.ContraseñaTextBox.Text = "Ingresa tu contraseña";
            this.ContraseñaTextBox.Enter += new System.EventHandler(this.ContraseñaTextBox_Enter);
            this.ContraseñaTextBox.Leave += new System.EventHandler(this.ContraseñaTextBox_Leave);
            // 
            // CorreoTextBox
            // 
            this.CorreoTextBox.Location = new System.Drawing.Point(64, 287);
            this.CorreoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.CorreoTextBox.Name = "CorreoTextBox";
            this.CorreoTextBox.Size = new System.Drawing.Size(201, 34);
            this.CorreoTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.CorreoTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CorreoTextBox.StateCommon.Border.Rounding = 12;
            this.CorreoTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.CorreoTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.CorreoTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.CorreoTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.CorreoTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.CorreoTextBox.StateNormal.Border.Rounding = 20;
            this.CorreoTextBox.TabIndex = 8;
            this.CorreoTextBox.Text = "e.g: juan@gmail.com";
            this.CorreoTextBox.Enter += new System.EventHandler(this.CorreoTextBox_Enter);
            this.CorreoTextBox.Leave += new System.EventHandler(this.CorreoTextBox_Leave);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(64, 264);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(162, 23);
            this.kryptonLabel1.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))), ((int)(((byte)(123)))));
            this.kryptonLabel1.StateCommon.ShortText.ColorAngle = 0F;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Correo electronico";
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(287, 287);
            this.TelefonoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(201, 34);
            this.TelefonoTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TelefonoTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TelefonoTextBox.StateCommon.Border.Rounding = 12;
            this.TelefonoTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.TelefonoTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.TelefonoTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.TelefonoTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.TelefonoTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TelefonoTextBox.StateNormal.Border.Rounding = 20;
            this.TelefonoTextBox.TabIndex = 10;
            this.TelefonoTextBox.Text = "e.g: 2954222222";
            this.TelefonoTextBox.Enter += new System.EventHandler(this.TelefonoTextBox_Enter);
            this.TelefonoTextBox.Leave += new System.EventHandler(this.TelefonoTextBox_Leave);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(287, 264);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(64, 23);
            this.kryptonLabel2.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))), ((int)(((byte)(123)))));
            this.kryptonLabel2.StateCommon.ShortText.ColorAngle = 0F;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 11;
            this.kryptonLabel2.Values.Text = "Celular";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(64, 159);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(201, 34);
            this.NombreTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NombreTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NombreTextBox.StateCommon.Border.Rounding = 12;
            this.NombreTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.NombreTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.NombreTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.NombreTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.NombreTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.NombreTextBox.StateNormal.Border.Rounding = 20;
            this.NombreTextBox.TabIndex = 12;
            this.NombreTextBox.Text = "e.g: Juan";
            this.NombreTextBox.Enter += new System.EventHandler(this.NombreTextBox_MouseEnter);
            this.NombreTextBox.Leave += new System.EventHandler(this.NombreTextBox_MouseLeave);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(64, 136);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(76, 23);
            this.kryptonLabel3.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))), ((int)(((byte)(123)))));
            this.kryptonLabel3.StateCommon.ShortText.ColorAngle = 0F;
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 13;
            this.kryptonLabel3.Values.Text = "Nombre";
            // 
            // ApellidoTextBox
            // 
            this.ApellidoTextBox.Location = new System.Drawing.Point(287, 159);
            this.ApellidoTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.ApellidoTextBox.Name = "ApellidoTextBox";
            this.ApellidoTextBox.Size = new System.Drawing.Size(201, 34);
            this.ApellidoTextBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ApellidoTextBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ApellidoTextBox.StateCommon.Border.Rounding = 12;
            this.ApellidoTextBox.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.ApellidoTextBox.StateCommon.Content.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ApellidoTextBox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.ApellidoTextBox.StateNormal.Border.Color1 = System.Drawing.Color.Silver;
            this.ApellidoTextBox.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ApellidoTextBox.StateNormal.Border.Rounding = 20;
            this.ApellidoTextBox.TabIndex = 14;
            this.ApellidoTextBox.Text = "e.g: Lopez";
            this.ApellidoTextBox.Enter += new System.EventHandler(this.ApellidoTextBox_Enter);
            this.ApellidoTextBox.Leave += new System.EventHandler(this.ApellidoTextBox_Leave);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(287, 136);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(76, 23);
            this.kryptonLabel4.StateCommon.Padding = new System.Windows.Forms.Padding(0);
            this.kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(108)))), ((int)(((byte)(178)))), ((int)(((byte)(123)))));
            this.kryptonLabel4.StateCommon.ShortText.ColorAngle = 0F;
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 15;
            this.kryptonLabel4.Values.Text = "Apellido";
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(65, 344);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.SignInBtn.OverrideDefault.Back.Color2 = System.Drawing.Color.MediumAquamarine;
            this.SignInBtn.OverrideDefault.Back.ColorAngle = 160F;
            this.SignInBtn.OverrideDefault.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.SignInBtn.OverrideDefault.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.SignInBtn.OverrideDefault.Border.ColorAngle = 160F;
            this.SignInBtn.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignInBtn.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SignInBtn.OverrideDefault.Border.Rounding = 20;
            this.SignInBtn.OverrideDefault.Border.Width = 1;
            this.SignInBtn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SignInBtn.Size = new System.Drawing.Size(421, 36);
            this.SignInBtn.StateCommon.Back.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.SignInBtn.StateCommon.Back.Color2 = System.Drawing.Color.MediumAquamarine;
            this.SignInBtn.StateCommon.Back.ColorAngle = 160F;
            this.SignInBtn.StateCommon.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.SignInBtn.StateCommon.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.SignInBtn.StateCommon.Border.ColorAngle = 160F;
            this.SignInBtn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignInBtn.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SignInBtn.StateCommon.Border.Rounding = 20;
            this.SignInBtn.StateCommon.Border.Width = 1;
            this.SignInBtn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.SignInBtn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.SignInBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.StatePressed.Back.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.SignInBtn.StatePressed.Back.Color2 = System.Drawing.Color.MediumAquamarine;
            this.SignInBtn.StatePressed.Back.ColorAngle = 20F;
            this.SignInBtn.StatePressed.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.SignInBtn.StatePressed.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.SignInBtn.StatePressed.Border.ColorAngle = 140F;
            this.SignInBtn.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignInBtn.StatePressed.Border.Rounding = 20;
            this.SignInBtn.StatePressed.Border.Width = 1;
            this.SignInBtn.StateTracking.Back.Color1 = System.Drawing.Color.Honeydew;
            this.SignInBtn.StateTracking.Back.Color2 = System.Drawing.Color.MintCream;
            this.SignInBtn.StateTracking.Back.ColorAngle = 45F;
            this.SignInBtn.StateTracking.Border.Color1 = System.Drawing.Color.DarkSeaGreen;
            this.SignInBtn.StateTracking.Border.Color2 = System.Drawing.Color.MediumAquamarine;
            this.SignInBtn.StateTracking.Border.ColorAngle = 160F;
            this.SignInBtn.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignInBtn.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.SignInBtn.StateTracking.Border.Rounding = 20;
            this.SignInBtn.StateTracking.Border.Width = 1;
            this.SignInBtn.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.MediumSeaGreen;
            this.SignInBtn.TabIndex = 1;
            this.SignInBtn.Values.Text = "Registrarse";
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Notificacion
            // 
            this.Notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacion.Icon")));
            this.Notificacion.Text = "notifyIcon1";
            this.Notificacion.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(417, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 71);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(66, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 19;
            this.pictureBox4.TabStop = false;
            // 
            // SignUp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(554, 411);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.ApellidoTextBox);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.CorreoTextBox);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.ContraseñaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.LabelHeader);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "SignUp";
            this.Text = "SignUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelHeader;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel Description;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox UsuarioTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel userLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel passwordLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ContraseñaTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox CorreoTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TelefonoTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox NombreTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ApellidoTextBox;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton SignInBtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}