using SchemaUser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TP2_LosDosChinos_JuanCruzEspasandin.Controladores;
using TP2_LosDosChinos_JuanCruzEspasandin.src;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public partial class Main : Form
    {
        public Sesion SesionActual { get; set; }
        public User UsuarioActual = new User();

        public Main(Sesion ParamSesionActual)
        {
            InitializeComponent();
            SesionActual = ParamSesionActual;
            inicializarControlNavegacion();
        }

        private ControlNavegacion controlNavegacion;

        private void inicializarControlNavegacion()
        {
            List<UserControl> userControls = new List<UserControl>(){
                new Articulos(SesionActual), new Proveedores(),new MiUsuario(SesionActual.MostrarUsuarioId()),new Ventas(SesionActual)
            };
            UsuarioActual.CompletarUser(SesionActual.UsuarioId);
            controlNavegacion = new ControlNavegacion(userControls, PanelMain);
            if (UsuarioActual.Rango())
            {
                controlNavegacion.Display(0);
            }
            else
            {
                controlNavegacion.Display(2);
                ArticulosAside.BackColor = Color.Transparent;
                ProveedoresAside.BackColor = Color.Transparent;
                MiUsuarioAside.BackColor = Color.Teal;

                BtnArticulos.BackColor = Color.Transparent;
                BtnArticulos.Enabled = false;
            }
        }

        private void BtnArticulos_Click(object sender, EventArgs e)
        {
            controlNavegacion.Display(0);
            ArticulosAside.BackColor = Color.Teal;
            ProveedoresAside.BackColor = Color.Transparent;
            MiUsuarioAside.BackColor = Color.Transparent;
            AsideVenta.BackColor = Color.Transparent;
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            controlNavegacion.Display(1);
            ArticulosAside.BackColor = Color.Transparent;
            ProveedoresAside.BackColor = Color.Teal;
            MiUsuarioAside.BackColor = Color.Transparent;
            AsideVenta.BackColor = Color.Transparent;
        }

        private void BtnMiUsuario_Click(object sender, EventArgs e)
        {
            controlNavegacion.Display(2);
            ArticulosAside.BackColor = Color.Transparent;
            ProveedoresAside.BackColor = Color.Transparent;
            MiUsuarioAside.BackColor = Color.Teal;
            AsideVenta.BackColor = Color.Transparent;
        }

        private void Btn_Venta_Click(object sender, EventArgs e)
        {
            controlNavegacion.HideActual(3);
            controlNavegacion.Display(3);
            ArticulosAside.BackColor = Color.Transparent;
            ProveedoresAside.BackColor = Color.Transparent;
            MiUsuarioAside.BackColor = Color.Transparent;
            AsideVenta.BackColor = Color.Teal;
        }

        private void Logout_Btn_Click(object sender, EventArgs e)
        {
            SesionActual.CerrarSesion();
            SesionActual.MostrarSesion();
            var ventaPrincipal = new MainWindow();
            ventaPrincipal.Show();
            Close();
        }

        private void Logout_Btn_MouseHover(object sender, EventArgs e)
        {
            Logout_Btn.BackgroundImage = Image.FromFile("C:\\Users\\Usuario\\Desktop\\Practica Tp2\\TP2_LosDosChinos-JuanCruzEspasandin\\TP2_LosDosChinos-JuanCruzEspasandin\\src\\Btn_Logout_Push.png");
        }

        private void Logout_Btn_MouseLeave(object sender, EventArgs e)
        {
            Logout_Btn.BackgroundImage = Image.FromFile("C:\\Users\\Usuario\\Desktop\\Practica Tp2\\TP2_LosDosChinos-JuanCruzEspasandin\\TP2_LosDosChinos-JuanCruzEspasandin\\src\\Btn_Logout.png");
        }
    }
}