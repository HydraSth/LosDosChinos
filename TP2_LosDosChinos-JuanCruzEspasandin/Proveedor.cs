using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using TP2_LosDosChinos_JuanCruzEspasandin.Controladores;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public class Proveedor
    {
        public Proveedor(int proveedorId, string nombre, string cUIT, string email, string celular, string rubro, string direccion)
        {
            ProveedorId = proveedorId;
            Nombre = nombre;
            CUIT = cUIT;
            Email = email;
            Celular = celular;
            Rubro = rubro;
            Direccion = direccion;
        }

        public int ProveedorId { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Rubro { get; set; }
        public string Direccion { get; set; }
    }
}