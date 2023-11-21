using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2_LosDosChinos_JuanCruzEspasandin.Controladores
{
    public partial class MiUsuario : UserControl
    {
        private string usuarioId { get; set; }

        public MiUsuario(string userId)
        {
            InitializeComponent();
            usuarioId = userId;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            var Conexion = new ControladorDB();
            var response = Conexion.GetUser(Conexion, usuarioId);
            Console.WriteLine(response.Acceso);
            NombreTextBox.Text = response.Nombre;
            UsuarioTextBox.Text = response.Usuario;
            CorreoTextBox.Text = response.CorreoElectronico;
            TelefonoTextBox.Text = response.Telefono;
            if (response.Acceso == 0)
            {
                NivelAccesoTxt.Text = "administrador";
            }
            else
            {
                NivelAccesoTxt.Text = "operador";
            }
        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            var Conexion = new ControladorDB();
            var response = Conexion.UpdateUser(Conexion, NombreTextBox.Text, UsuarioTextBox.Text, CorreoTextBox.Text, TelefonoTextBox.Text);
            if (response)
            {
                Console.WriteLine("Salio bien");
            }
            else
            {
                Console.WriteLine("No salio bien");
            }
        }
    }
}