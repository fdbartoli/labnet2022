using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tp05.Linq.Data;
using Tp05.Linq.Logic;

namespace Tp05.Linq.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomersLogic customerLogic = new CustomersLogic();
            ProductsLogic productsLogic = new ProductsLogic();
            CategoriesLogic categoriesLogic = new CategoriesLogic();

            //ejercicio 1
            Console.WriteLine("Devolver un objeto Customer\n");
            Console.WriteLine(customerLogic.ShowObjectCustomer().ContactName);


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 2
            Console.Clear();
            Console.WriteLine("Devolver todos los productos sin stock\n");

            foreach (var item in productsLogic.OutOfSotck())
            {
                Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 3
            Console.Clear();
            Console.WriteLine("Devolver todos los productos que tienen stock y que cuestan más de 3 por unidad\n");

            foreach (var item in productsLogic.WithStockExpensiveThanThree())
            {
                Console.WriteLine($"Producto: {item.ProductName} - Stock: {item.UnitsInStock} - $: {item.UnitPrice}");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 4
            Console.Clear();
            Console.WriteLine("Devolver los Customers de la región WA\n");

            foreach (var item in customerLogic.CustomersFromWa())
            {
                Console.WriteLine($"Nombre del Cliente: {item.CompanyName} - Región {item.Region}");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 5
            Console.Clear();
            Console.WriteLine("Devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789\n");

            Console.WriteLine(productsLogic.FirstByIdOrNUll(789));

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();



            //ejercicio 6
            Console.Clear();
            Console.WriteLine("Devolver los nombre de los Customers. Mostrarlos en Mayuscula y en Minuscula.\n");

            foreach (var item in customerLogic.CustomerLowerCase())
            {
                Console.WriteLine($"Company name minúsculas: {item.CompanyName.ToLower()}");
                Console.WriteLine($"COMPANY NAME MAYÚSCULAS: {item.CompanyName.ToUpper()}\n");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 7
            Console.Clear();
            Console.WriteLine("Devolver Join entre Customers y Orders donde los customer sean de la Region WA y la fecha de orden sea mayor a 1/1/1997\n");

            foreach (var item in customerLogic.CustomerJoinOrdersDate())
            {
                Console.WriteLine($"{item.Customer.CompanyName} - {item.Order.OrderDate}");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 8
            Console.Clear();
            Console.WriteLine("Devolver los primeros 3 Customers de la  Región WA\n");

            foreach (var item in customerLogic.CustomersTake3WA())
            {
                Console.WriteLine($"{item.ContactName} - {item.Region}");
            }


            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 9
            Console.Clear();
            Console.WriteLine("Devolver lista de productos ordenados por nombre\n");

            foreach (var item in productsLogic.ProductsOrderByName())
            {
                Console.WriteLine(item.ProductName);
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 10
            Console.Clear();
            Console.WriteLine("Devolver lista de productos ordenados por stock de mayor a menor\n");

            foreach (var item in productsLogic.ProductsOrderByStock())
            {
                Console.WriteLine($"Producto: {item.ProductName} - Stock disponible: {item.UnitsInStock}");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio\n");
            Console.ReadKey();

            //ejercicio 11

            Console.Clear();
            Console.WriteLine("Devolver las distintas categorías asociadas a los productos\n");

            foreach (var item in categoriesLogic.CategoriesPrdudct())
            {
                Console.WriteLine($"IDCategoria: {item.Category.CategoryID} - Producto: {item.Product.ProductName}");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();


            //ejercicio 12
            Console.Clear();
            Console.WriteLine("Devolver el primer elemento de una lista de productos\n");

            Console.WriteLine(productsLogic.FirstProduct().ProductName);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Presione cualquier tecla para ver el próximo ejercicio");
            Console.ReadKey();

            //ejercicio 13
            Console.Clear();
            Console.WriteLine("Devolver los customer con la cantidad de ordenes asociadas\n");

            foreach (var item in customerLogic.GroupCustomers())
            {
                Console.WriteLine($"Contacto del Customer {item.Customer.ContactName} - Cantidad de ordenes: {item.Quantity}" );
            }

            Console.WriteLine("\n\n*******¡¡¡¡FIN DEL TP!!!!*********");
            Console.ReadKey();


        }
    }
}
