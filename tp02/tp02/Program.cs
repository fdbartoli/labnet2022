using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp02.Extensions;

namespace tp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;

            while (continua == true)
            {
            Console.Clear();
            Console.WriteLine("TP Nº2");
            Console.WriteLine("1) Generar excepción al intentar dividir por 0.");
            Console.WriteLine("2) Realizar una división de 2 números.");
            Console.WriteLine("3) Disparar una excepción.");
            Console.WriteLine("4) Disparar una excepción personalizada.");


                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Ingrese un número entero para intentar dividir por 0");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                        Console.WriteLine(number.DivideByZero());
                        } catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        } catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }finally
                        {
                            Console.WriteLine("Fin del intento.");
                        }
                        break;
                    case "2":
                        try
                        {
                            Console.WriteLine("Ingrese el dividendo: ");
                            float dividendo = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el divisor: ");
                            float divisor = float.Parse(Console.ReadLine());
                            Console.WriteLine(dividendo.division(divisor));
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Solo Chuck Norris divide por cero!" + ex.Message);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Seguro ingresó una letra o no ingresó nada!");
                        }
                        finally
                        {
                            Console.WriteLine("Fin del intento.");
                        }
                        break;
                    case "3":
                        Console.WriteLine("dispara expeción");                      
                        break;
                    default:
                        Console.WriteLine("Opción inválida, vuelva a intentar");
                        break;
                }
                Console.WriteLine("\nPresione cualquier tecla para continuar");
                Console.ReadKey();

            }
        }
    }
}



    
    

