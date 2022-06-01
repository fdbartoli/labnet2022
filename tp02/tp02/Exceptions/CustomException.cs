using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp02.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException():base("Se lanzó una excepción personalizada")
        {

        }

        public new string Message()
        {
            return "Se lanzó una excepción personalizada";
        }

    }
}
