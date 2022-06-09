using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp04.EntityFramework.Utils
{
    public class NotEsistsException:Exception

    {
        
        public new string Message()
        {
            return "El ID no existe.";
        }
    }
}
