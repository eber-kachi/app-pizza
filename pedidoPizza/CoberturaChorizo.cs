using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    class CoberturaChorizo : ICobertura
    {
        public double precio { get; set; }
        public string detalle { get; set; }
        public string getDetalle()
        {
            throw new NotImplementedException();
        }

        public double getPrecio()
        {
            throw new NotImplementedException();
        }
    }
}
