using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
   public class PrecioCalculator
    {
        private double precioPizza;
        
        public void calculatePrecioPizza(Pizza pizza) {
            precioPizza = pizza.getPrecio();
            if (pizza.getCoberturas().Count > 2)
            {
                int i = 1;
                foreach (var cobertura in pizza.getCoberturas())
                {
                    if (i > 2)
                    {
                        precioPizza += cobertura.getPrecio(); 
                    }
                    i++;
                }
            }
            pizza.setPrecio(precioPizza);
        }
    }
}
