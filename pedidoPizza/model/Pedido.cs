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
    }
}
