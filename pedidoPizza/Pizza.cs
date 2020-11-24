using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    class Pizza
    {
        private string tipoPizza { get; set; }
        private List<ICobertura> coberturas { get; set; }
        private double precio { get; set; }

        public void setTipoPizza(string tipoPizza, double precio) {
            this.tipoPizza = tipoPizza;
            this.precio = precio;
        }

        public void setCobertura(List<ICobertura> coberturas) {
            this.coberturas = coberturas;
        }

        public void setPrecio(double precio) {
            this.precio = precio;
        }

        public string print() {

            string res = "";

            res += "Tamano de la Pizza: " + tipoPizza + "\n" + "Coberturas: ";

            foreach (var cobertura in coberturas)
            {
              res += "\t" + cobertura + "\n";
            }
            res+= "-------------------------\n" +"Precio de la Pizza: " + precio + "Bs.";

            return res;
        }
    }
}
