using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_
{
    public abstract class Vehiculo
    {
        public string numeroSerie {  get; set; }
        public string color { get; set; }
        public float velocidadMaxima { get; set; }
        public string marca {  get; set; }
        public string modelo { get; set; }
        protected float velocidadActual {  get; set; }

        public Vehiculo(string numeroSerie, string color, float velocidadMaxima,
            string marca, string modelo)
        {
            this.numeroSerie = numeroSerie;
            this.color = color;
            this.velocidadMaxima = velocidadMaxima;
            this.marca = marca;
            this.modelo = modelo;
            this.velocidadActual = 0;
        }

        public override string ToString()
        {
            return "Numero de serie:" + this.numeroSerie + "\nColor:" +
                this.color + "\nVelocidadMaxima:" + this.velocidadMaxima + "\nMarca:"
                + this.marca + "\nModelo:" + this.modelo;
        }
    }
}
