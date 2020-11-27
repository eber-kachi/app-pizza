using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public class Delivery : AppTerceros
    {
        private List<Pizza> pedido { get; set; }
        private string destino { get; set; }
        private string ultimaPosicion { get; set; }
        public Delivery() {
            ultimaPosicion = "";
        }
        public void setDestino(string destino) {
            this.destino = destino;
        }
        public string getUltimaPosicion() {
            return " -- Destino: " + destino + " -- Ubicacion delivery: " + ultimaPosicion;
        }
        public void setUltimaPosicion(string ultimaPosicion) {
            this.ultimaPosicion = ultimaPosicion;
            notificarClientes();
        }
        public void setPedido(List<Pizza> pizzas) {
            this.pedido = pizzas;
        }
        public string printPedido() {
            return "Cantidad de pizzas del pedido: " + pedido.Count;
        }        
    }
}
