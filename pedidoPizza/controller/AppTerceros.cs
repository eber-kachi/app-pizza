using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public class AppTerceros
    {
        private List<ClienteDirector> clientes;
        public AppTerceros() {
            clientes = new List<ClienteDirector>();
        }
        public void asignarCliente(ClienteDirector cliente) {
            clientes.Add(cliente);
        }
        public void retirarCliente(ClienteDirector cliente) {
            clientes.Remove(cliente);
        }
        public void notificarClientes() {
            foreach (var cliente in clientes)
            {
                cliente.notificar();
            }
        }
    }
}
