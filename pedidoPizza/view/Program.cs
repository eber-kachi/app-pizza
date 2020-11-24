using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pedidoPizza
{
    class Program
    {
        static void Main(string[] args)
        {
            PrecioCalculator calculadora = new PrecioCalculator();
            ClienteDirector cliente = new ClienteDirector();

            int opcion;
            
            do
            {
                Console.WriteLine("\n==== Tipos de pizza ====");
                Console.WriteLine("1. Grande");
                Console.WriteLine("2. Mediana");
                Console.WriteLine("3. Pequenia");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        cliente.setPizzaBuilder(new PizzaGrandeConcreteBuilder());
                        break;
                    case 2:
                        
                        cliente.setPizzaBuilder(new PizzaMedianaConcreteBuilder());
                        break;
                    case 3:

                        cliente.setPizzaBuilder(new PizzaPequenaConcreteBuilder());
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

                cliente.construirPizza(agregarCoberturas());
                Pizza pizza = cliente.getPizza();
                calculadora.calculatePrecioPizza(cliente.getPizza());
                Console.WriteLine(pizza.print());

            } while ( opcion !=4);

            Console.ReadKey();

        }

        static List<ICobertura> agregarCoberturas()
        {
            List<ICobertura> coberturas = new List<ICobertura>();

            int opcion;
            do
            {
                Console.WriteLine("\n==== Selecciona coberturas para pizza ====");
                Console.WriteLine("1. Chorizo");
                Console.WriteLine("2. Jamon");
                Console.WriteLine("3. Pinia");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                if(coberturas.Count <=6)
                {
                    switch (opcion)
                    {
                        case 1:
                            // CoberturaChorizo chorizo = new CoberturaChorizo(23.4, "chorizo");
                            coberturas.Add(new CoberturaChorizo(13.4, "Chorizo en rodajas"));
                            break;
                        case 2:
                            coberturas.Add(new CoberturaJamon(10.4, "Jamon picado"));
                            break;
                        case 3:
                            coberturas.Add(new CoberturaPinia(15.4, "Pinia en pedazos"));
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                }else
                    Console.WriteLine("Ya no puede escojer mas coberturas");
            } while (opcion != 4 );

            return coberturas;
        }
    }
}
