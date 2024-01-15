using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    internal class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private string _categoria;

        public int Codigo
        {
            get // getter lectura
            {
                // logica               
                return _codigo;
            }
            set // setter escritura
            {
                //logica
                _codigo = value;
            }
        }

        public string Descripcion
        {
            get // getter lectura
            {
                // logica               
                return _descripcion;
            }
            set // setter escritura
            {
                //logica
                _descripcion = value;
            }
        }

        public double PrecioCompra
        {
            get // getter lectura
            {
                // logica               
                return _precioCompra;
            }
            set // setter escritura
            {
                //logica
                _precioCompra = value;
            }
        }

        public double PrecioVenta
        {
            get // getter lectura
            {
                // logica               
                return _precioVenta;
            }
            set // setter escritura
            {
                //logica
                _precioVenta = value;
            }
        }

        public string Categoria
        {
            get // getter lectura
            {
                // logica
                if (!string.IsNullOrEmpty(this.Categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "Sin Categoria";
                }
                
            }
        }

        // propiedad autoimplementada
        public X500DistinguishedName Color { get; set; }


        public Producto()
        {
            _codigo = 0;
            _descripcion = String.Empty;
            _precioCompra = 0;
            _precioVenta = 0;
            _categoria = String.Empty;
        }

        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
            this._categoria = categoria;
        }

        public  bool HayPrecioVenta()
        {
            return this._precioVenta > 0;
        }

    }
}
