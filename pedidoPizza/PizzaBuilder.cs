using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public abstract class PizzaBuilder
   {
        protected Pizza pizza { get; set; }
        public PrecioCalculator precioCalculator { get; set; }
        
        public void createNuevaPizza(){
            pizza = new Pizza();
        }

        public Pizza getPizza()
        {
            return this.pizza;
        }

        protected abstract void buildTipoPizza();
        public abstract void buildCobertura(List<ICobertura> coberturas);
    }
}
