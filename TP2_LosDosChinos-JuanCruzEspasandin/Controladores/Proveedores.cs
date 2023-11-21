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
    public partial class Proveedores : UserControl
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            if (BTN_Agregar.Text == "AGEGAR")
            {
                var Controlador = new ControladorDB();
                int numeroAleatorio = new Random().Next(0, 1001);
                Proveedor provider = new Proveedor(numeroAleatorio, Input_Nombre.Text, Input_Cuit.Text, Input_Email.Text, Input_Celular.Text, Input_Rubro.Text, Input_Direccion.Text);
                var response = Controlador.AddProveedor(Controlador, provider);
                if (response)
                {
                    NotifyIcon notificacion = new NotifyIcon();
                    notificacion.Icon = SystemIcons.Information;
                    notificacion.Visible = true;
                    notificacion.ShowBalloonTip(200, "Exitoso", "Nuevo proveedor agregado", ToolTipIcon.Info);
                }
                else
                {
                    NotifyIcon notificacion = new NotifyIcon();
                    notificacion.Icon = SystemIcons.Information;
                    notificacion.Visible = true;
                    notificacion.ShowBalloonTip(400, "Error", "Error al agregar proveedor", ToolTipIcon.Info);
                }
                DG_Provider.Rows.Clear();
                CargarProveedores();
            }
            else
            {
                var Controlador = new ControladorDB();
                int numeroAleatorio = new Random().Next(0, 1001);
                Proveedor provider = new Proveedor(numeroAleatorio, Input_Nombre.Text, Input_Cuit.Text, Input_Email.Text, Input_Celular.Text, Input_Rubro.Text, Input_Direccion.Text);
                var response = Controlador.ModificarProveedor(Controlador, provider);
                if (response)
                {
                    NotifyIcon notificacion = new NotifyIcon();
                    notificacion.Icon = SystemIcons.Information;
                    notificacion.Visible = true;
                    notificacion.ShowBalloonTip(200, "Exitoso", "Nuevo proveedor modificado", ToolTipIcon.Info);
                }
                else
                {
                    NotifyIcon notificacion = new NotifyIcon();
                    notificacion.Icon = SystemIcons.Information;
                    notificacion.Visible = true;
                    notificacion.ShowBalloonTip(400, "Error", "Error al modificar proveedor", ToolTipIcon.Info);
                }
                DG_Provider.Rows.Clear();
                CargarProveedores();
            }
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            var ControladorDb = new ControladorDB();
            var response = ControladorDb.GetProveedores(ControladorDb);
            response.ForEach(provider =>
            {
                var N = DG_Provider.Rows.Add();
                DG_Provider.Rows[N].Cells[0].Value = provider.Nombre;
                DG_Provider.Rows[N].Cells[1].Value = provider.CUIT;
                DG_Provider.Rows[N].Cells[2].Value = provider.Email;
                DG_Provider.Rows[N].Cells[3].Value = provider.Celular;
                DG_Provider.Rows[N].Cells[4].Value = provider.Rubro;
                DG_Provider.Rows[N].Cells[5].Value = provider.Direccion;
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ControladorDb = new ControladorDB();
            ControladorDb.EliminarProveedor(ControladorDb, Input_Nombre.Text);
            DG_Provider.Rows.Clear();
            CargarProveedores();
        }

        private void DG_Provider_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Input_Nombre.Text = DG_Provider.CurrentRow.Cells[0].Value.ToString();
            Input_Cuit.Text = DG_Provider.CurrentRow.Cells[1].Value.ToString();
            Input_Email.Text = DG_Provider.CurrentRow.Cells[2].Value.ToString();
            Input_Celular.Text = DG_Provider.CurrentRow.Cells[3].Value.ToString();
            Input_Rubro.Text = DG_Provider.CurrentRow.Cells[4].Value.ToString();
            Input_Direccion.Text = DG_Provider.CurrentRow.Cells[5].Value.ToString();
        }

        private void Input_Nombre_TextChanged(object sender, EventArgs e)
        {
            var Conexion = new ControladorDB();
            var response = Conexion.ExisteProveedor(Conexion, Input_Nombre.Text);
            if (response)
            {
                BTN_Agregar.Text = "MODIFICAR";
                BTN_Agregar.ForeColor = System.Drawing.Color.Blue;
            }
            else
            {
                BTN_Agregar.Text = "AGEGAR";
                BTN_Agregar.ForeColor = System.Drawing.Color.MediumSeaGreen;
            }
        }
    }
}