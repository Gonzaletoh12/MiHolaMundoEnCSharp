using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase_
{
    internal class Auto : Vehiculo, IVehiculo
    {
        public Auto(string numeroSerie, string Color, float velocidadmaxima, string marca, string Modelo)
            : base(numeroSerie, color, velocidadMaxima, marca, Modelo) 
        {
        }
        public void Acelerar()
        {
            this.velocidadActual = this.velocidadActual + 10;

            Console.WriteLine("Acelerando Auto a: {0} Km/h", this.velocidadActual);
        }

        public void Arrancar()
        {
            Console.WriteLine("Arrancando Auto.... En Arranque");
        }

        public void Detener()
        {
            Console.WriteLine("Deteniendo Auto.... Detenido");
        }
    }
}
