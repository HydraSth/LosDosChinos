using SchemaUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        #region Funcion que hace el placeholder universal para todos los campos
        private void HandleEnter(ComponentFactory.Krypton.Toolkit.KryptonTextBox inputName, string inputText)
        {
            var input = inputName;
            if (input.Text == inputText)
            {
                input.Text = "";
            }
        }
        private void HandleLeave(ComponentFactory.Krypton.Toolkit.KryptonTextBox inputName, string inputText)
        {
            var input = inputName;
            if (input.Text == "")
            {
                input.Text = inputText;
            }
        }

        private void NombreTextBox_MouseEnter(object sender, EventArgs e)
        {
            HandleEnter(NombreTextBox, "e.g: Juan");
        }

        private void NombreTextBox_MouseLeave(object sender, EventArgs e)
        {
           HandleLeave(NombreTextBox, "e.g: Juan");
        }

        private void ApellidoTextBox_Enter(object sender, EventArgs e)
        {
            HandleEnter(ApellidoTextBox, "e.g: Lopez");
        }

        private void ApellidoTextBox_Leave(object sender, EventArgs e)
        {
            HandleLeave(ApellidoTextBox, "e.g: Lopez");
        }

        private void UsuarioTextBox_Enter(object sender, EventArgs e)
        {
            HandleEnter(UsuarioTextBox, "Ingresa tu usuario");
        }

        private void UsuarioTextBox_Leave(object sender, EventArgs e)
        {
            HandleLeave(UsuarioTextBox, "Ingresa tu usuario");
        }


        private void ContraseñaTextBox_Enter(object sender, EventArgs e)
        {
            HandleEnter(ContraseñaTextBox, "Ingresa tu contraseña");
        }


        private void ContraseñaTextBox_Leave(object sender, EventArgs e)
        {
            HandleLeave(ContraseñaTextBox, "Ingresa tu contraseña");
        }

        private void CorreoTextBox_Enter(object sender, EventArgs e)
        {
            HandleEnter(CorreoTextBox, "e.g: juan@gmail.com");
        }

        private void CorreoTextBox_Leave(object sender, EventArgs e)
        {
            HandleLeave(CorreoTextBox, "e.g: juan@gmail.com");
        }

        private void TelefonoTextBox_Enter(object sender, EventArgs e)
        {
            HandleEnter(TelefonoTextBox, "e.g: 2954222222");
        }

        private void TelefonoTextBox_Leave(object sender, EventArgs e)
        {
            HandleLeave(TelefonoTextBox, "e.g: 2954222222");
        }



        #endregion

        private void SignInBtn_Click(object sender, EventArgs e)
        {
 
                var Conexion = new ControladorDB();
                var UserObj=new User(UsuarioTextBox.Text,ContraseñaTextBox.Text, NombreTextBox.Text, ApellidoTextBox.Text,CorreoTextBox.Text,TelefonoTextBox.Text);
                var RespuestaValidacion =UserObj.Validar(UserObj);
                if(RespuestaValidacion.IsValid)
                {
                    //Error si se loguea con un mail en uso
                    var respuesta = ControladorDB.AgregarUsuario(Conexion, UserObj);
                    Notificacion.ShowBalloonTip(400, "Informacion", respuesta, ToolTipIcon.Info);
                    if(respuesta!= "El nombre de usuario ya existe o el correo electronico esta en uso")
                    {
                        var ventaPrincipal = new MainWindow();
                        ventaPrincipal.Show();
                        Hide();
                    }
                }
                else
                {
                    //Errores por validacion
                    Notificacion.Icon = SystemIcons.Error;
                    Notificacion.BalloonTipTitle = "Un error ocurrio";
                    Notificacion.BalloonTipText = $"{RespuestaValidacion.Errors[0]}";
                    Notificacion.ShowBalloonTip(400);
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var ventaPrincipal = new MainWindow();
            ventaPrincipal.Show();
            Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\Usuario\\Desktop\\Practica Tp2\\TP2_LosDosChinos-JuanCruzEspasandin\\TP2_LosDosChinos-JuanCruzEspasandin\\src\\Btn_Home.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("C:\\Users\\Usuario\\Desktop\\Practica Tp2\\TP2_LosDosChinos-JuanCruzEspasandin\\TP2_LosDosChinos-JuanCruzEspasandin\\src\\Btn_Home_Push.png");
        }
    }
}
