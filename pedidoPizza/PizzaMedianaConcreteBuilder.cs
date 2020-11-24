using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public class PizzaMedianaConcreteBuilder : PizzaBuilder
   {
        protected override void buildTipoPizza()
        {
            pizza.setTipoPizza("Mediana", 75);
        }

        public override void buildCobertura(List<ICobertura> coberturas)
        {
            pizza.setCobertura(coberturas);
        }
    }
}
