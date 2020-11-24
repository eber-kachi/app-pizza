using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public class PizzaPequenaConcreteBuilder : PizzaBuilder
   {
        protected override void buildTipoPizza()
        {
            pizza.setTipoPizza("Pequena", 50);
        }

        public override void buildCobertura(List<ICobertura> coberturas)
        {
            pizza.setCobertura(coberturas);
        }
    }
}
