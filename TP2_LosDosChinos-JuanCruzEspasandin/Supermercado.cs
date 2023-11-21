using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public class Supermercado
    {
        public Supermercado(string cUIT, string nombre, string direccion)
        {
            CUIT = cUIT;
            Nombre = nombre;
            Direccion = direccion;
        }

        public string CUIT { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        private List<Articulo> Articulos { get; set; }

        public void AgregarArticulo(Articulo articulo)
        {
            Articulos.Add(articulo);
        }
    }
}