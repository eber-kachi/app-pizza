using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public abstract class PizzaBuilder
   {
        private Pizza pizza { get; set; }
        public PrecioCalculator precioCalculator { get; set; }
        
        public Pizza getPizza() {
            return pizza;
        }
        public void createNuevaPizza(){
            pizza = new Pizza();
        }

        protected abstract void buildTipoPizza();
        protected abstract void buildCobertura(array coberturas);
    }
}
