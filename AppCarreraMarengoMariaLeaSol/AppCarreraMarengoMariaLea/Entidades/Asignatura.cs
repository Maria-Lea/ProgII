using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCarreraMarengoMariaLea.Datos
{
    internal class Asignatura
    {
        public int IdAsignatura { get; set; }
        public string NomAsignatura { get; set; }

        public Asignatura(int idAsignatura, string nomAsignatura)
        {
            IdAsignatura = idAsignatura;
            NomAsignatura = nomAsignatura;
        }

        public override string ToString()
        {
            return NomAsignatura;
        }
    }
}
