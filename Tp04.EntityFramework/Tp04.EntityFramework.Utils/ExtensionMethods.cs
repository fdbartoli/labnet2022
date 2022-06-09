using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp04.EntityFramework.Utils
{
    public static class ExtensionMethods
    {

        public static string AddMessage(this InvalidOperationException ex)
        {
            return "El número ID ingresado no existe!";
        }

        public static string AddMessage(this FormatException ex)
        {
            return "Debe ingresar un número entero!";
        }

        public static string AddMessage(this OverflowException ex)
        {
            return "El número es muy grande!";
        }

        public static string AddMessage (this NullReferenceException ex)
        {
            return "ID inexistente";
        }

    }
}
