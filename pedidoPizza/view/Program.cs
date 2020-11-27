using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrecioCalculator calculadora = new PrecioCalculator();
            ClienteDirector cliente = new ClienteDirector("Clara Luz","Calle Ecuador");
            Delivery delivery = new Delivery();
            Pedido pedido = new Pedido();

            int opcion;
            int cantidad;
            int numPizza = 1;
            int latitud = 50;
            int longitud = 13;

            Console.WriteLine("\n==== Ingrese la cantidad de pizzas que desea ====");

            cantidad = Convert.ToInt32(Console.ReadLine());
            
            do
            {
                Console.WriteLine("\n*** Caracteristicas de la pizza N° " + numPizza + " ***");
                Console.WriteLine("==== Tipo de pizza ====");
                Console.WriteLine("1. Grande");
                Console.WriteLine("2. Mediana");
                Console.WriteLine("3. Pequenia");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion < 4)
                {
                    
                    if (opcion == 1)
                    {
                        cliente.setPizzaBuilder(new PizzaGrandeConcreteBuilder());    
                    }
                    else if (opcion == 2)
                    {
                        cliente.setPizzaBuilder(new PizzaMedianaConcreteBuilder());    
                    }
                    else if (opcion == 3)
                    {
                        cliente.setPizzaBuilder(new PizzaPequenaConcreteBuilder());    
                    }

                    cliente.construirPizza(agregarCoberturas());
                    Pizza pizza = cliente.getPizza();
                    calculadora.calculatePrecioPizza(cliente.getPizza());
                    pedido.addPizzaPedido(pizza);
                    cantidad--;
                    numPizza++;
                }
                else if (opcion != 4)
                {
                    System.Console.WriteLine("Opcion no valida");
                }
            } while ( cantidad != 0 && opcion != 4);
            
            if (pedido.getPedido().Count != 0)
            {
                calculadora.calculatePrecioPedido(pedido);
                Console.WriteLine(pedido.printDetallePedido());
                delivery.setPedido(pedido.getPedido());
                cliente.setDelivery(delivery);
                delivery.asignarCliente(cliente);
                delivery.setDestino(cliente.getUbicacion());
                do
                {
                    delivery.setUltimaPosicion("Latitud: " + latitud + "°38'65''N ; Longitud: " + longitud + "°41'77''E");
                    latitud += 10;
                    longitud += 5;
                    System.Threading.Thread.Sleep(2000);
                } while (latitud <= 80);
                delivery.setUltimaPosicion("Destino alcanzado, pedido entregado");
                delivery.retirarCliente(cliente); 
            }

            Console.ReadKey();

        }

        static List<ICobertura> agregarCoberturas()
        {
            List<ICobertura> coberturas = new List<ICobertura>();

            int opcion;
            do
            {
                Console.WriteLine("\n==== Selecciona las coberturas para la pizza ====");
                Console.WriteLine("1. Chorizo");
                Console.WriteLine("2. Jamon");
                Console.WriteLine("3. Pinia");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                if(coberturas.Count < 6)
                {
                    if (opcion < 4)
                    {
                        if (opcion == 1)
                        {
                            coberturas.Add(new CoberturaChorizo(13.4, "Chorizo en rodajas"));
                        }
                        else if (opcion == 2)
                        {
                            coberturas.Add(new CoberturaJamon(10.4, "Jamon picado"));
                        }
                        else if (opcion == 3)
                        {
                            coberturas.Add(new CoberturaPinia(15.4, "Pinia en pedazos"));
                        }
                    }
                    else if (opcion != 4)
                    {
                        System.Console.WriteLine("Opcion no valida");
                    }
                }
                else
                {
                    Console.WriteLine("Ya no puede escojer mas coberturas");
                    opcion = 4;
                }
            } while (opcion != 4 );

            return coberturas;
        }
    }
}
