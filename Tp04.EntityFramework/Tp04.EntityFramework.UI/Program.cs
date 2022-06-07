using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Entities;
using Tp04.EntityFramework.Logic;

namespace Tp04.EntityFramework.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            SuppliersLogic suppliersLogic = new SuppliersLogic();

            Console.WriteLine("Company Names: ");

            foreach (Shippers shipper in shippersLogic.GetAll())
            {
                Console.WriteLine($" - {shipper.CompanyName}");
            }

            Console.WriteLine("\nSuppliers Contact Name: ");

            foreach (Suppliers supplier in suppliersLogic.GetAll())
            {
                Console.WriteLine($" - {supplier.ContactName}");
            }

            Console.ReadLine();
        }
    }
}
