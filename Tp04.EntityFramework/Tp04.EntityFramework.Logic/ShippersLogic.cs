using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Data;
using Tp04.EntityFramework.Entities;

namespace Tp04.EntityFramework.Logic
{
    public class ShippersLogic
    {
        private readonly NortwindContext _context;

        public ShippersLogic()
        {
            _context = new NortwindContext();   
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }

    }
}
