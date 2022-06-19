using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Entities;

namespace Tp04.EntityFramework.Logic
{
    public class TerritoriesLogic : BaseLogic, ILogic<Territories>
    {
        public void Add(Territories newItem)
        {
            throw new NotImplementedException();
        }

        public List<Territories> GetAll()
        {
            return _context.Territories.ToList();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Territories Item)
        {
            throw new NotImplementedException();
        }
    }
}
