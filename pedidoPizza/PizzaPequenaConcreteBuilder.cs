using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public class PizzaPequenaConcreteBuilder : PizzaBuilder
   {
        public void buildTipoPizza() {
            pizza.setPizza("Pequena",50);
        }
        public void buildCobertura(List coberturas){
            pizza.addCobertura(coberturas);
        }
    }
}
