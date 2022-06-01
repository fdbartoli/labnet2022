using System;
using System.Windows;
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
            bool result;
            while (continua == true)
            {
            Console.Clear();
            Console.WriteLine("TP Nº2: Elija una opción.");
            Console.WriteLine("1) Generar excepción al intentar dividir por 0.");
            Console.WriteLine("2) Realizar una división de 2 números.");
            Console.WriteLine("3) Disparar una excepción.");
            Console.WriteLine("4) Disparar una excepción personalizada.");
            Console.WriteLine("5) Salir");


                switch (Console.ReadLine())
                {
                    case "1":
                        result = true;
                        Console.Clear();
                        Console.WriteLine("Se intenta dividir por 0 \n");
                        Console.WriteLine("Ingrese un número entero para intentar dividir por 0");
                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                        Console.WriteLine(number.DivideByZero());
                        } 
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                        } 
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message);
                            result = false;
                        }
                        finally
                        {
                            string final = (result) ? "No se puede dividir por cero!" : "Falló el intento porque no ingresaste un número entero :(";
                            Console.WriteLine("\n" + final);
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("División de dos números enteros. \n");
                        result = true;
                        try
                        {
                            Console.WriteLine("Ingrese el dividendo: ");
                            int dividendo = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el divisor: ");
                            int divisor = int.Parse(Console.ReadLine());
                            Console.WriteLine(dividendo.Division(divisor));
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine("Solo Chuck Norris divide por cero!" + ex.Message);
                            result = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Seguro ingresó una letra o no ingresó nada!");
                            result = false;
                        }
                        finally
                        {
                            string final = (result) ? " ha sido exitosa!" : " no ha sido exitosa!";
                            Console.WriteLine("\n La operación {0}", final);
                        }
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Se lanza una exepción. \n");
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
                        Console.Clear();
                        Console.WriteLine("Se lanza una excepción personalizada\n");
                        try
                        {
                            Logic.ThrowCustomException();
                        }
                        catch (Exceptions.CustomException ex)
                        {
                            Console.WriteLine("Tipo de excepción: {0}", ex.GetType());
                            MessageBox.Show(ex.AddMessage("Mensaje personalizado!..."), "Ejercicio 4");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa");
                        continua = false;
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



    
    

