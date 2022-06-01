using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02.Extensions
{
    public static class Extensions
    {

        public static int DivideByZero(this int number)
        {
            return number / 0;       

        }   
        
        public static decimal Division (this int dividendo, int divisor)
        {
            return Math.Round((decimal)dividendo / (decimal)divisor, 2);
        }

        public static string AddMessage (this Exceptions.CustomException ex, string message)
        {
            return $"{message} {ex.Message}";
        }
            
    }
} 
