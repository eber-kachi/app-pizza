using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    class CoberturaPinia : ICobertura
    {
        private double precio { get; set; }
        private string detalle { get; set; }
        public CoberturaPinia(double precio, string detalle)
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
