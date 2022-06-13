using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp05.Linq.Entities;

namespace Tp05.Linq.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> OutOfSotck()
        {
            return context.Products.Where(p => p.UnitsInStock == 0).ToList();
        }

        public List<Products> WithStockExpensiveThanThree()
        {
            return context.Products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3).ToList();
        }

        public String FirstByIdOrNUll (int productId)
        {
            var query = context.Products.Where(p => p.ProductID == productId);
            var result =query.FirstOrDefault();
            if (result != null) {
                return $"{result.ProductName}";
            }
            else
            {
                return $"No existe ningún producto con este ID.";
            }
        }

        public List<Products> ProductsOrderByName()
        {
            var query = from products in context.Products
                        orderby products.ProductName
                        select products;
            return query.ToList();
        }

        public List<Products> ProductsOrderByStock()
        {
            return context.Products.OrderByDescending(p => p.UnitsInStock).ToList();
        }


        public Products FirstProduct()
        {
            return context.Products.FirstOrDefault();
        }

    }
}
