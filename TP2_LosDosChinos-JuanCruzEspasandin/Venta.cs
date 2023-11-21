using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LosDosChinos_JuanCruzEspasandin
{
    public class Venta
    {
        public int VentaId;
        public int MontoTotal;
        public string Fecha;
        public string UsuarioId;

        public Venta(int ventaId, int montoTotal, string fecha, string id)
        {
            VentaId = ventaId;
            MontoTotal = montoTotal;
            Fecha = fecha;
            UsuarioId = id;
        }
    }
}