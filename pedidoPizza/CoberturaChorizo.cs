using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    class CoberturaChorizo : ICobertura
    {
        private double precio { get; set; }
        private string detalle { get; set; }
        public CoberturaChorizo(double precio, string detalle)
        {
            this.precio = precio;
            this.detalle = detalle;
        }
        public string getDetalle()
        {
            return this.detalle;
        }

        public double getPrecio()
        {
            return this.precio;
        }
    }
}
