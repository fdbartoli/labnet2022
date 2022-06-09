﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Data;
using Tp04.EntityFramework.Entities;

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

        public void Update(Shippers shippers)
        {
            var shipperUpdate = _context.Shippers.Find(shippers.ShipperID);
            
                shipperUpdate.CompanyName = shippers.CompanyName;
                shipperUpdate.Phone = shippers.Phone;
                _context.SaveChanges();
        }
    }
}
