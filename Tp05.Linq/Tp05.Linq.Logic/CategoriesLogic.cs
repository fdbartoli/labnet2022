using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp05.Linq.Entities;

namespace Tp05.Linq.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        public List<CategoriesProduct> CategoriesPrdudct()
        {
            var query = from products in context.Products
                        join idCategories in context.Categories
                        on products.CategoryID equals idCategories.CategoryID
                        select new CategoriesProduct
                        {
                            Category = idCategories,
                            Product = products
                        };
                     

            return query.ToList();
        }

    }
}
