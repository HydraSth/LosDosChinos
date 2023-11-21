using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_LosDosChinos_JuanCruzEspasandin.src
{
    public class Sesion
    {
        public double SesionId { get; set; }
        public string UsuarioId { get; set; }
        public string Fecha { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }

        public Sesion(string UserId, string ParamFecha, string ParamHoraInicio)
        {
            Random random = new Random();
            int SessionId = random.Next(1001);
            SesionId = SessionId;
            UsuarioId = UserId;
            Fecha = ParamFecha;
            HoraInicio = ParamHoraInicio;
            HoraFin = "0";
        }

        public void CerrarSesion()
        {
            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            HoraFin = TimeSpan.FromSeconds(Math.Round(horaActual.TotalSeconds)).ToString();
            var Conexion = new ControladorDB();
            Conexion.CloseSesion(Conexion, this);
        }

        public string MostrarUsuarioId()
        {
            return UsuarioId.ToString();
        }

        public void MostrarSesion()
        {
            Console.WriteLine("Sesion Id: " + SesionId);
            Console.WriteLine("Usuario Id: " + UsuarioId);
            Console.WriteLine("Fecha: " + Fecha);
            Console.WriteLine("Hora Inicio: " + HoraInicio);
            Console.WriteLine("Hora Fin: " + HoraFin);
        }
    }
}