using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Data;

namespace Tp04.EntityFramework.Logic
{
    public abstract class BaseLogic
    {
        protected readonly NortwindContext _context;

        public BaseLogic()
        {
            _context = new NortwindContext();
        }

    }
}
