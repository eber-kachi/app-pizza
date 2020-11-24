using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public class PizzaGrandeConcreteBuilder : PizzaBuilder
   {
        public void buildTipoPizza() {
            pizza.setPizza("Grande");
        }
        public void buildCobertura(List coberturas){
            pizza.addCobertura(coberturas);
        }
    }
}
