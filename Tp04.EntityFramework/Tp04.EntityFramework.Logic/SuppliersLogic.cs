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
            try
            {
                _context.Suppliers.Add(newItem);
                _context.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Suppliers> GetAll()
        {
            try { 
            return _context.Suppliers.ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            try { 
            var supplierToRemove = _context.Suppliers.First(s => s.SupplierID == id);
            _context.Suppliers.Remove(supplierToRemove);
            _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Suppliers supplier)
        {

            try { 
            var actualizarSupplier = _context.Suppliers.Find(supplier.SupplierID);
            actualizarSupplier.CompanyName = supplier.CompanyName;
            actualizarSupplier.ContactName = supplier.ContactName;
            actualizarSupplier.Phone = supplier.Phone;
            _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Suppliers GetOneByID (int id)
        {
            try { 
            return _context.Suppliers.FirstOrDefault(s =>s.SupplierID == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}

