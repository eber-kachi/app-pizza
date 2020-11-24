using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public class PizzaMedianaConcreteBuilder : PizzaBuilder
   {
        public void buildTipoPizza() {
            pizza.setPizza("Mediana");
        }
        public void buildCobertura(List coberturas){
            pizza.addCobertura(coberturas);
        }
    }
}
