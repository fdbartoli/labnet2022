using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tp05.Linq.Entities;

namespace Tp05.Linq.Logic 
{
    public class CustomersLogic : BaseLogic
    {


        public Customers ShowObjectCustomer()
        {
            return context.Customers.FirstOrDefault();
        }

        public List<Customers> CustomersFromWa()
        {
            return context.Customers.Where( c => c.Region == "wa").ToList();
        }                                                        

        public List<Customers> CustomerLowerCase()
        {
            return context.Customers.ToList();           
 
        }

        public List<CustomerOrder> CustomerJoinOrdersDate()
        {
            var query = from order in context.Orders
                        join customer in context.Customers on
                        order.CustomerID equals customer.CustomerID
                        where customer.Region == "WA" && order.OrderDate > new DateTime(1997, 1, 1)
                        select new CustomerOrder
                        {
                            Customer = customer,
                            Order = order,
                        };

            return query.ToList();  
            
        }

        public List<Customers> CustomersTake3WA()
        {
            var query = (from customer in context.Customers
                         where customer.Region == "WA"
                         select customer).Take(3);
            return query.ToList();

        }



    }
}
