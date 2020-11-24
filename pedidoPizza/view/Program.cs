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
                Console.WriteLine("3. pequenia");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine(opcion);

                switch (opcion)
                {
                    case 1:

                        // CoberturaChorizo chorizo = new CoberturaChorizo(23.4, "chorizo");
                        //coberturas.Add(new CoberturaChorizo(13.4, "chorizo"));
                        PizzaGrandeConcreteBuilder grande = new PizzaGrandeConcreteBuilder();
                        cliente.setPizzaBuilder(grande);
                        cliente.construirPizza(agregarCoberturas());

                        break;
                    case 2:
                        //coberturas.Add(new CoberturaJamon(10.4, "Jamon"));
                        PizzaMedianaConcreteBuilder mediana = new PizzaMedianaConcreteBuilder();
                        
                        cliente.setPizzaBuilder(mediana);
                        cliente.construirPizza(agregarCoberturas());
                        break;
                    case 3:
                        // coberturas.Add(new CoberturaPinia(15.4, "pinia"));
                        cliente.setPizzaBuilder(new PizzaPequenaConcreteBuilder());
                        cliente.construirPizza(agregarCoberturas());
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
                //cliente.construirPizza(coberturas);

                //Console.WriteLine("Total de coberturas "+coberturas.Count);
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
                Console.WriteLine("2. jamon");
                Console.WriteLine("3. Pinia");
                Console.WriteLine("4. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());
                if(coberturas.Count <=6)
                {
                    switch (opcion)
                    {
                        case 1:
                            // CoberturaChorizo chorizo = new CoberturaChorizo(23.4, "chorizo");
                            coberturas.Add(new CoberturaChorizo(13.4, "chorizo"));
                            break;
                        case 2:
                            coberturas.Add(new CoberturaJamon(10.4, "Jamon"));
                            break;
                        case 3:
                            coberturas.Add(new CoberturaPinia(15.4, "pinia"));
                            break;
                        default:
                            Console.WriteLine("Opcion no valida");
                            break;
                    }
                }else
                    Console.WriteLine("ya no puede escojer mas coberturas");
            } while (opcion != 4 );

            return coberturas;
        }
    }
}
