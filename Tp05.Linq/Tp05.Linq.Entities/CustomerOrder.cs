using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp05.Linq.Entities
{
    public class CustomerOrder
    {
        public Customers ContactName { get; set; }

        public Customers Customer { get; set; }
        public Orders Order { get; set; }

        public int Quantity { get; set; }

    }
}
