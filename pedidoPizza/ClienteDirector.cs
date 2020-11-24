using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public class ClienteDirector
    {
        private PizzaBuilder pizzaBuilder { get; set; }
        public ClienteDirector()
        {

        }

        public void setPizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public void construirPizza(List<ICobertura> coberturas)
        {
            this.pizzaBuilder.createNuevaPizza();
            this.pizzaBuilder.buildCobertura(coberturas);

        }

      
    }
}
