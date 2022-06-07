using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Data;
using Tp04.EntityFramework.Entities;

namespace Tp04.EntityFramework.Logic
{
    public class SuppliersLogic
    {
        private readonly NortwindContext _context;

        public SuppliersLogic()
        {
            _context = new NortwindContext();
        }

        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

    }


}
