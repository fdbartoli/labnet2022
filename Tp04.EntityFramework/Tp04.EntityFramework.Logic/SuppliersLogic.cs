using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Data;
using Tp04.EntityFramework.Entities;

namespace Tp04.EntityFramework.Logic
{
    public class SuppliersLogic : BaseLogic, ILogic<Suppliers>
    {

        public void Add(Suppliers newItem)
        {
            _context.Suppliers.Add(newItem);
            _context.SaveChanges();
        }

        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public void Remove(int id)
        {
            var supplierToRemove = _context.Suppliers.First(s => s.SupplierID == id);
            _context.Suppliers.Remove(supplierToRemove);
            _context.SaveChanges();
        }

        public void Update(Suppliers supplier)
        {
            var actualizarSupplier = _context.Suppliers.Find(supplier.SupplierID);
            actualizarSupplier.CompanyName = supplier.CompanyName;
            actualizarSupplier.ContactName = supplier.ContactName;
            actualizarSupplier.Phone = supplier.Phone;
            _context.SaveChanges();
        }

        public Suppliers GetOneByID (int id)
        {
            return _context.Suppliers.Find(id);
        }

    }
}

