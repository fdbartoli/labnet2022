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
            int number = 10;
            try
            {
                Console.WriteLine(number.DivideByZero());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fin de la operación.");
            }
            Console.ReadKey();
            
            

        }
    }
}
