using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    class Pizza
    {
        private String tipoPizza { get; set; };
        private List<ICobertura> coberturas { get; set; };
        private double precio { get; set; };

        public void setTipoPizza(String tipoPizza) {
            this.tipoPizza = tipoPizza;
        }

        public void setCobertura(List coberturas) {
            this.coberturas = coberturas;
        }

        public void setPrecio(double precio) {
            this.precio = precio;
        }

        public String print() {
            return "Tamano de la Pizza: " + tipoPizza + "\n" +
                    "Coberturas: " +
                    foreach (var cobertura in coberturas)
                    {
                        "\t" + cobertura + "\n" +
                    }
                    "-------------------------\n" +
                    "Precio de la Pizza: " + precio + "Bs.";
        }
    }
}
