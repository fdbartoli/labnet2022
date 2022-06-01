using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02.Extensions
{
    public static class IntExtensions
    {

        public static int DivideByZero(this int number)
        {
            return number / 0;       

        }   
        
        public static float division (this float dividendo, float divisor)
        {
            return dividendo / divisor;
        }
            
    }
} 
