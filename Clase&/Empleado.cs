using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_
{
    public class Empleado : Persona
    {
        protected string legajo;
        public Empleado(string legajo, long dni, string nombre, string domicilio) 
            : base(dni, nombre, domicilio)
        {
            this.legajo = legajo;
        }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Legajo: " + this.legajo);
        }
    }
}
