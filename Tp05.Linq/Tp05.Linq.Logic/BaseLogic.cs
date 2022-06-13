using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp05.Linq.Data;

namespace Tp05.Linq.Logic
{
    public abstract class BaseLogic
     {
        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }


    }
}
