using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public class ClienteDirector
    {
        private string nombre { get; set; }
        private string ubicacion { get; set; }
        private Delivery delivery { get; set; }
        private PizzaBuilder pizzaBuilder { get; set; }
        public ClienteDirector(string nombre, string ubicacion)
        {
            this.nombre = nombre;
            this.ubicacion = ubicacion;
        }

        public void setDelivery(Delivery delivery) {
            this.delivery = delivery;
        }

        public string getUbicacion() {
            return this.ubicacion;
        }

        public void setPizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            this.pizzaBuilder = pizzaBuilder;
        }

        public Pizza getPizza()
        {
            return this.pizzaBuilder.getPizza();
        }
        public void construirPizza(List<ICobertura> coberturas)
        {
            this.pizzaBuilder.createNuevaPizza();
            this.pizzaBuilder.buildTipoPizza();
            this.pizzaBuilder.buildCobertura(coberturas);
        }
    
        public void notificar() {
            System.Console.WriteLine("Pedido de: " + nombre + delivery.getUltimaPosicion());
        }
    }
}
