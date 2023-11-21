namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    partial class Camaras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CB_Camaras = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(189, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE VIGILANCIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(189, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "SISTEMA DE VIGILANCIA";
            // 
            // pictureBoxVideo
            // 
            this.pictureBoxVideo.Location = new System.Drawing.Point(144, 89);
            this.pictureBoxVideo.Name = "pictureBoxVideo";
            this.pictureBoxVideo.Size = new System.Drawing.Size(285, 151);
            this.pictureBoxVideo.TabIndex = 2;
            this.pictureBoxVideo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(183, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "ENCEDER / DESACTIVAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CB_Camaras
            // 
            this.CB_Camaras.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Camaras.ForeColor = System.Drawing.Color.SeaGreen;
            this.CB_Camaras.FormattingEnabled = true;
            this.CB_Camaras.Location = new System.Drawing.Point(228, 54);
            this.CB_Camaras.Name = "CB_Camaras";
            this.CB_Camaras.Size = new System.Drawing.Size(121, 27);
            this.CB_Camaras.TabIndex = 4;
            // 
            // Camaras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 330);
            this.Controls.Add(this.CB_Camaras);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Camaras";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxVideo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CB_Camaras;
    }
}