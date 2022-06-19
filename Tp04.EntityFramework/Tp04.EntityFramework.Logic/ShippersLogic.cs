using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Data;
using Tp04.EntityFramework.Entities; 
using Tp04.EntityFramework.Utils;


namespace Tp04.EntityFramework.Logic
{
    public class ShippersLogic : BaseLogic, ILogic<Shippers>
    {
        public void Add(Shippers shipper)
        {
            _context.Shippers.Add(shipper);
            _context.SaveChanges();
        }

        public List<Shippers> GetAll()
        {
            return _context.Shippers.ToList();
        }
           
        public void Remove(int id)
        {
            var ShipperToRemove = _context.Shippers.First(s => s.ShipperID == id);
            _context.Shippers.Remove(ShipperToRemove);
            _context.SaveChanges();
        }


        public void Update(Shippers updateShipper)
        {
            try
            {
                var bufferShippers = _context.Shippers.Find(updateShipper.ShipperID);
                if (bufferShippers != null)
                {
                    bufferShippers.CompanyName = updateShipper.CompanyName;
                    bufferShippers.Phone = updateShipper.Phone;
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("No se encontró shipper.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
