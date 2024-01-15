using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase_
{
    public class Persona
    {
        protected long dni;
        protected string nombre;
        protected string domicilioParticular;

        public Persona()
        {
            this.dni = 0;
            this.nombre = string.Empty;
            this.domicilioParticular = string.Empty;
        }

        public Persona(long dni, string nombre, string domicilio)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.domicilioParticular = domicilio;
        }

        // lo puedo sobreescribir en una clase derivada
        public virtual void MostrarDatos()
        {
            Console.WriteLine("DNI: " + this.dni);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Domicilio Particular: " + this.domicilioParticular);
        }

        public static string TelefonoEmargencia()
        {
            return "101, 103";
        }

    }
}
