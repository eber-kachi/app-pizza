using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public class Pedido
    {
        private List<Pizza> pizzas { get; set; }
        private double precioTotalPedido { get; set; }

        public Pedido()
        {
            this.pizzas = new List<Pizza>();
        }
        public void addPizzaPedido(Pizza pizza) {
            this.pizzas.Add(pizza);
        }

        public List<Pizza> getPedido()
        {
            return this.pizzas;
        }

        public void setPrecioTotalPedido(double precioTotalPedido) {
            this.precioTotalPedido = precioTotalPedido;
        }

        public string printDetallePedido() {
            string res = "\n<<< DETALLES DEL PEDIDO >>>\n";
            int num = 1;

            foreach (var pizza in pizzas)
            {
                res += "\n--- Pizza N° " + num + " ---";
                res += "\nTamano de la Pizza: " + pizza.getTipoPizza() + "\n" + "Coberturas: \n";

                foreach (var cobertura in pizza.getCoberturas())
                {
                res += "\t" + cobertura.getDetalle() + "\n";
                }
                res+= "-------------------------\n" +"Precio individual de la Pizza: " + pizza.getPrecio() + "Bs.\n";
                num++;
            }
            res += "\n********* Precio total del pedido: " + precioTotalPedido + "Bs. *********\n";

            return res;
        }
    }
}
