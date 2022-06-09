using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp04.EntityFramework.Entities;
using Tp04.EntityFramework.Logic;
using Tp04.EntityFramework.Utils;

namespace Tp04.EntityFramework.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continua = true;
            while (continua == true)
            {
                Console.Clear();
                Console.WriteLine("TP Nº4: Elija una opción.");
                Console.WriteLine("1) Listar Shippers.");
                Console.WriteLine("2) Listar Suppliers.");
                Console.WriteLine("3) Agregar Shipper.");
                Console.WriteLine("4) Agregar supplier.");
                Console.WriteLine("5) Eliminar Shipper.");
                Console.WriteLine("6) Eliminar supplier.");
                Console.WriteLine("7) Actualizar Shipper.");
                Console.WriteLine("8) Actualizar supplier.");
                Console.WriteLine("9) Salir");


                switch (Console.ReadLine())
                {
                    case "1":
                        ViewShippers();
                        break;
                    case "2":
                        ViewSuppliers();
                        break;                   
                    case "3":
                        AddShipper();
                        break;
                    case "4":
                        AddSupplier();
                        break;
                    case "5":
                        RemoveShipper();
                        break;
                    case "6":
                        RemoveSupplier();
                        break;
                    case "7":
                        UpdateShipper();
                        break;
                    case "8":
                        UpdateSupplier();
                        break;
                    case "9":
                        continua = false;
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta!");
                        break;
                }


                Console.WriteLine("\nPresione cualquier tecla para continuar");
                Console.ReadKey();
            }
        }
        
        
        static void ViewShippers()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            Console.Clear();
            Console.WriteLine("Listado de Shippers: ");
            try
            {
                foreach (Shippers shipper in shippersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {shipper.ShipperID} - Compañía: {shipper.CompanyName} - Teléfono: {shipper.Phone}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado", ex.Message);
            }
        }

        static void ViewSuppliers()
        {
            SuppliersLogic suppliersLogic = new SuppliersLogic();
            Console.Clear();
            Console.WriteLine("Listado de suppliers: ");
            try
            {
                foreach (Suppliers suppliers in suppliersLogic.GetAll())
                {
                    Console.WriteLine($"ID: {suppliers.SupplierID} - Compañía: {suppliers.CompanyName} - Nombre de contacto: {suppliers.ContactName}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado", ex.Message);
            }            
        }

        static void AddShipper()
        {

            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                Console.Clear();
                Console.WriteLine("Insertar Shipper");
                Console.WriteLine("Ingrese el nombre de la compañía");
                string companyName = Console.ReadLine();
                Console.WriteLine("ingrese número telefónico");
                string phone = Console.ReadLine();
                shippersLogic.Add(new Shippers
                {
                    CompanyName = companyName,
                    Phone = phone
                });
            } catch (DbEntityValidationException ex)
            {
                Console.WriteLine("El nombre de la compañía es obligatorio", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error, vuelva a intentar", ex.Message);
            }
            
        }

        static void AddSupplier()
        {
            try
            {
                SuppliersLogic suppliersLogic = new SuppliersLogic();
                Console.Clear();
                Console.WriteLine("Insertar Supplier");
                Console.WriteLine("Ingrese el nombre de la compañía");
                string companyName = Console.ReadLine();
                Console.WriteLine("ingrese nombre de contacto");
                string contactName = Console.ReadLine();
                suppliersLogic.Add(new Suppliers
                {
                    CompanyName = companyName,
                    ContactName = contactName
                });
            }
            catch (DbEntityValidationException ex)
            {
                Console.WriteLine("El nombre de la compañia es obligatorio", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error, vuelva a intentar", ex.Message );
            }
        }

        static void RemoveShipper()
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            Console.Clear();
            try
            {
                Console.WriteLine("Eliminar registro de shippers");
                Console.WriteLine("Ingrese el id del registro a eliminar");
                int id = int.Parse(Console.ReadLine());
                shippersLogic.Remove(id);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                Console.WriteLine("No se puede eliminar el registro porque tiene campos vinculados.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ocurrio un error inesperado", ex.Message );
            }

        }

        static void RemoveSupplier()
        {
            try { 
            SuppliersLogic suppliersLogic = new SuppliersLogic();
            Console.Clear();
            Console.WriteLine("Eliminar registro de Suppliers");
            Console.WriteLine("Ingrese el id del registro a eliminar");
            int id = int.Parse(Console.ReadLine());
            suppliersLogic.Remove(id);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                Console.WriteLine("No se puede eliminar el registro porque tiene campos vinculados.");
            }

            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }

        }

        static void UpdateShipper()
        {
            
            
            Console.Clear();
            Console.WriteLine("Modificar registro Shipper");
            try
            {
                ShippersLogic shippersLogic = new ShippersLogic();
                Console.WriteLine("Ingrese ID del shipper a actualizar: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo nombre de la compañía");
                string companyName = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo número de teléfono");
                string phone = Console.ReadLine();
                shippersLogic.Update(new Shippers
                {
                    CompanyName = companyName,
                    Phone = phone,
                    ShipperID = id
                });

            }

            catch (System.NullReferenceException  ex)
            {
                Console.WriteLine("error", ex.Message    );
            }
            catch (DbEntityValidationException ex)
            {
                Console.WriteLine("El nombre de la empresa es obligatorio!", ex.Message);
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrio un error inesperado.", ex.Message);
            }

        }

        static void UpdateSupplier()
        {
            SuppliersLogic suppliersLogic = new SuppliersLogic();
            Console.WriteLine("Modificar registro Supplier");
            Console.WriteLine("Ingrese ID del Supplier a modificar");
            try
            {
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el nuevo nombre de la compañía: ");
                string companyName = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo nombre de contacto: ");
                string contactName = Console.ReadLine();

                suppliersLogic.Update(new Suppliers
                {
                    CompanyName = companyName,
                    ContactName = contactName,
                    SupplierID = id
                });
            }
            catch (DbEntityValidationException ex)
            {
                Console.WriteLine("El nombre de la empresa es obligatorio!", ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.AddMessage());
            }
        }
    }
}
