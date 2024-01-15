using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_
{
    public class Administrativo : Empleado
    {
        public Administrativo(string legajo, long dni, string nombre, string domicilio)
            : base(legajo, dni, nombre, domicilio)
        {

        }
    }
}
