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
                        Console.Clear();
                        Console.WriteLine("Listado de Shippers: ");
                        try { 
                        foreach (Shippers shipper in shippersLogic.GetAll())
                        {
                            Console.WriteLine($"ID: {shipper.ShipperID} - Compañía: {shipper.CompanyName} - Teléfono: {shipper.Phone}");
                        }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Ocurrió un error inesperado", ex.Message);
                        }                        
                        break;
                    case "2":
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
                        break;
                    case "3":
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
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Insertar Supplier");
                        Console.WriteLine("Ingrese el nombre de la compañía");
                        companyName = Console.ReadLine();
                        Console.WriteLine("ingrese nombre de contacto");
                        string contactName = Console.ReadLine();
                        suppliersLogic.Add(new Suppliers
                        {
                            CompanyName = companyName,
                            ContactName = contactName,
                        });
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Eliminar registro de Shippers");
                        Console.WriteLine("Ingrese id del registro a eliminar");
                        try { 
                        int id = int.Parse(Console.ReadLine());
                        shippersLogic.Remove(id);
                        } catch (FormatException ex)
                        {
                            Console.WriteLine("Debe ingresar un número entero.", ex.Message);
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Eliminar registro de Suppliers");
                        Console.WriteLine("Ingrese el id del registro a eliminar");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            suppliersLogic.Remove(id);
                        } catch (FormatException ex)
                        {
                            Console.WriteLine("Debe ingresar un número entero.", ex.Message);
                        }
                        break;
                    case "7":
                        Console.Clear();
                        Console.WriteLine("Modificar registro Shipper");
                        Console.WriteLine("Ingrese ID del shipper a actualizar: ");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());                            
                            Console.WriteLine("Ingrese el nuevo nombre de la compañía");
                            companyName = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo número de teléfono");
                            phone = Console.ReadLine();

                            shippersLogic.Update(new Shippers
                            {
                                CompanyName = companyName,
                                Phone = phone,
                                ShipperID = id
                            });

                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine("Debe ingresar un número entero: ", ex.Message);
                        }
                        break;
                    case "8":
                        Console.WriteLine("Modificar registro Supplier");
                        Console.WriteLine("Ingrese ID del Supplier a modificar");
                        try
                        {
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el nuevo nombre de la compañía: ");
                            companyName = Console.ReadLine();
                            Console.WriteLine("Ingrese el nuevo nombre de contacto: ");
                            contactName = Console.ReadLine();

                            suppliersLogic.Update(new Suppliers
                            {
                                CompanyName = companyName,
                                ContactName = contactName,
                                SupplierID = id
                            }) ;


                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Debe ingresar un numero entero", ex.Message);
                        }
                        break;
                }



                Console.WriteLine("\nPresione cualquier tecla para continuar");
                Console.ReadKey();
            }



            //Console.WriteLine("Lista de suppliers:\n ");



            //Console.ReadKey();


            ////shippersLogic.Addd(new Shippers
            ////{
            ////    CompanyName = "EjemploEFFFFF"

            ////});

            //foreach (Shippers shipper in shippersLogic.GetAll())
            //{
            //    Console.WriteLine($"{shipper.ShipperID}");
            //};

            //Console.ReadKey();

        }
    }
}
