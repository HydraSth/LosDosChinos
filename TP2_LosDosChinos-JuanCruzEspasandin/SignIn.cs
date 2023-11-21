using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP2_LosDosChinos_JuanCruzEspasandin.src;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LabelHeadder_Paint(object sender, PaintEventArgs e)
        {
        }

        #region Placeholder

        //Placeholder para input user
        private void UserMouseEnter(object sender, EventArgs e)
        {
            var inputUserBox = userTextBox;
            if (inputUserBox.Text == "Ingresa tu usuario")
            {
                inputUserBox.Text = "";
            }
        }

        private void UserMouseLeave(object sender, EventArgs e)
        {
            var inputUserBox = userTextBox;
            if (inputUserBox.Text == "")
            {
                inputUserBox.Text = "Ingresa tu usuario";
            }
        }

        //Placeholder para input contraseña
        private void PasswordMouseEnter(object sender, EventArgs e)
        {
            var inputPasswordBox = passwordTextBox;
            if (inputPasswordBox.Text == "Ingresa tu contraseña")
            {
                inputPasswordBox.Text = "";
            }
        }

        private void PasswordMouseLeave(object sender, EventArgs e)
        {
            var inputPasswordBox = passwordTextBox;
            if (inputPasswordBox.Text == "")
            {
                inputPasswordBox.Text = "Ingresa tu contraseña";
            }
        }

        #endregion Placeholder

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            var WindowSignUp = new SignUp();
            WindowSignUp.Show();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var Conexion = new ControladorDB();
            if (userTextBox.Text == "Ingresa tu usuario" || passwordTextBox.Text == "Ingresa tu contraseña")
            {
                Notificacion.Icon = SystemIcons.Error;
                Notificacion.BalloonTipTitle = "Un error ocurrio";
                Notificacion.BalloonTipText = "No deben estar vacios los campos";
                Notificacion.ShowBalloonTip(400);
            }
            else
            {
                var respuesta = Conexion.Login(Conexion, userTextBox.Text, passwordTextBox.Text);
                if (respuesta == "Inicio de sesión fallido")
                {
                    Notificacion.ShowBalloonTip(400, "Error", respuesta, ToolTipIcon.Error);
                }
                else
                {
                    Notificacion.ShowBalloonTip(400, "Inicio de sesion exitoso", respuesta, ToolTipIcon.None);
                    string fechaActual = DateTime.Today.ToString();
                    TimeSpan horaActual = DateTime.Now.TimeOfDay;
                    string horaRedondeada = TimeSpan.FromSeconds(Math.Round(horaActual.TotalSeconds)).ToString();
                    var UserSession = new Sesion(userTextBox.Text, fechaActual, horaRedondeada);
                    var VentanaPrincipal = new Main(UserSession);
                    VentanaPrincipal.Show();
                    Visible = false;
                }
            }
        }
    }
}