using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01_poo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string answer; 
            string continua = "s";
            int flag = 0;
            PublicTransport[] vehiclesArray = new PublicTransport[10];
  

            while (continua == "s" || continua == "S")
            {

                Console.Clear();
                Console.WriteLine("***MENU***\n" +
                "1- Ingresar la cantidad de pasajeros de los 10 transportes\n" +
                "2- Mostrar la cantidad de pasajeros de cada transporte\n" +
                "3- Eliminar la información\n" +
                "4- Salir.\n");
                answer = Console.ReadLine();

                switch (answer)
                {
                    case "1":
                        flag = 1;   
                        Console.WriteLine("Ingresar los pasajeros de los 5 TAXIS:");
                        int indexTaxi = 1;
                        for (int i = 0; i <5 ; i++)
                        {                            
                            Console.WriteLine("taxi nº {0}: ", indexTaxi);
                            try
                            {
                                int n = int.Parse(Console.ReadLine());
                                vehiclesArray[i] = new Taxi(n, indexTaxi);
                                indexTaxi++;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error! Por favor ingrese un número entero.");
                                i --;
                            }
                        }
                        Console.WriteLine("Ingresar los pasajeros de los 5 OMNIBUS:");
                        int indexBus = 1;
                        for (int i = 5; i < 10; i++)
                        {
                            Console.WriteLine("omnibus nº {0}: ", indexBus);
                            try
                            {
                                int n = int.Parse(Console.ReadLine());
                                vehiclesArray[i] = new Bus(n, indexBus);
                                indexBus++;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Error! Por favor ingrese un número entero");
                                i--;
                            }
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        if (flag == 0)
                        {
                            Console.WriteLine("Primero debe ingresar los pasajeros!");
                        }else
                            for (int i = 0; i < 10; i++)
                            {                                                          
                                Console.WriteLine(vehiclesArray[i] +" "+ vehiclesArray[i].NumberOfPassangers());
                            }                        
                        Console.ReadKey();
                        break;
                    case "3":
                        Array.Clear(vehiclesArray, 0, vehiclesArray.Length);
                        flag = 0;
                        Console.WriteLine("Los datos de los pasajeros fueron eliminados.");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Fin del programa. ADIOS!!!");
                        continua = "n";
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("**OPCIÓN INVÁLIDA!!!**");
                        Console.ReadKey();
                        break;
                }



            }
        }
    }
}

