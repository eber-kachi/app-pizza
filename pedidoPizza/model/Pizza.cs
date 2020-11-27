using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public class Pizza
    {
        private string tipoPizza { get; set; }
        private List<ICobertura> coberturas { get; set; }
        private double precio { get; set; }

        public void setTipoPizza(string tipoPizza, double precio) {
            this.tipoPizza = tipoPizza;
            this.precio = precio;
        }

        public void setCoberturas(List<ICobertura> coberturas) {
            this.coberturas = coberturas;
        }

        public void setPrecio(double precio) {
            this.precio = precio;
        }
        public double getPrecio()
        {
            return this.precio;
        }
        public List<ICobertura> getCoberturas()
        {
            return this.coberturas;
        }

        public string print() {

            string res = "";

            res += "Tamano de la Pizza: " + tipoPizza + "\n" + "Coberturas: \n";

            foreach (var cobertura in coberturas)
            {
              res += "\t" + cobertura.getDetalle() + "\n";
            }
            res+= "-------------------------\n" +"Precio de la Pizza: " + precio + "Bs.";

            return res;
        }
    }
}
