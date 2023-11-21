using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public class ArticuloCarrito
    {
        public ArticuloCarrito(int cantidad, long id, string detalle)
        {
            Cantidad = cantidad;
            Id = id;
            Detalle = detalle;
        }

        public string Detalle { get; set; }
        public int Cantidad { get; set; }
        public long Id { get; set; }
    }
}