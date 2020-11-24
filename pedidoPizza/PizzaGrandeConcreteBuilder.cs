using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    class PizzaGrandeConcreteBuilder: PizzaBuilder
    {

        protected override void buildTipoPizza()
        {

            pizza.setPizza("Grande", 100);
        }

        public override void buildCobertura(List<ICobertura> coberturas)
        {
            pizza.addCobertura(coberturas);
        }
    }
}
