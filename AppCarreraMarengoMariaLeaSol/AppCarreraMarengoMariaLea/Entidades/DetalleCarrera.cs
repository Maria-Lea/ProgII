using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCarreraMarengoMariaLea.Datos
{
    internal class DetalleCarrera
    {
        public DateTime AñoCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Asignatura Asignatura { get; set; }

        public DetalleCarrera(DateTime añoCursado, int cuatrimestre, Asignatura asignatura)
        {
            AñoCursado = añoCursado;
            Cuatrimestre = cuatrimestre;
            Asignatura = asignatura;
        }
    }
}
