using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp04.EntityFramework.Common
{
    public class CustomException : Exception
    {
        public CustomException ():base("El número de carácteres es muy grande.")
        {

        }

        public new string Message()
        {
            return "El número de caracteres es muy grande";
        }

    }

}
