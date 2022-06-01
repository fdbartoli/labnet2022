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
                            Console.WriteLine("Fin de la operación.");
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
                            Console.WriteLine("Fin de la operación.");
                        }
                        break;
                    case "3":
                        try
                        {
                            Logic.ThrowException();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Mensaje de la excepción: {0}", ex.Message);
                            Console.WriteLine("Tipo de excepción: {0}",ex.GetType());
                        }                  
                        break;
                    case "4":
                        try
                        {
                            throw new Exceptions.CustomException();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Mensaje de la excepción: {0}", ex.Message);
                            Console.WriteLine("Tipo de excepción: {0}", ex.GetType());
                        }
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



    
    

