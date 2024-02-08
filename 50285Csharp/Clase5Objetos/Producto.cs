using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Objetos
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
            get
            {
                return _codigo;
            }

            set
            {
                _codigo = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return _descripcion;
            }

            set
            {
                _descripcion = value;
            }
        }

        public double PrecioCompra
        {
            get
            {
                return _precioCompra;
            }

            set
            {
                _precioCompra = value;
            }
        }

        public double PrecioVenta
        {
            get
            {
                return _precioVenta;
            }

            set
            {
                _precioVenta = value;
            }
        }

        public string Categoria
        {
            get
            {
                if (!String.IsNullOrEmpty(this.Categoria))
                {
                    return this._categoria;
                }
                else 
                {
                    return "Sin categoría";
                }
                
            }
        }

        //propiedad autoimplementada

        // public string Color { get; set; }

        //propiedad autoimplementada solo lectura

        // public string Modelo { get; } 


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
            _codigo = codigo;
            _descripcion = descripcion;
            _precioCompra = precioCompra;
            _precioVenta = precioVenta;
            _categoria = categoria;
        }

        public bool HayPreciodeVenta()
        {
            return this._precioVenta > 0;
        }


    }
}
