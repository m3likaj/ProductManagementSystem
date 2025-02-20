using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.DataAccessLayer.EntityFramework
{
    public class CustomerDal : GenericFunctions<Customer>
    {
        Context context;
        public CustomerDal()
        {
            context = new Context();
        }
        public List<IEnumerable<object>> GetOrderHistory(int id)
        {
            var values = context.Invoices.Where(inv => inv.CustomerID == id).Select(i => new
            {
                order = i.Orders.Select(o => new
                {
                    o.OrderId,
                    product = o.OrderProducts.Where(op => o.OrderId == op.OrderID).Select(p => p.ProductID)

                })
            }).ToList();
            return values.Cast<IEnumerable<object>>().ToList();
        }
        public Customer GetCustomerByPhone(string phone)
        {
            return context.Customers.Where(x => x.PhoneNumber == phone).FirstOrDefault();
        }
        public Customer GetCustomerByEmail(string email)
        {
            return context.Customers.Where(x => x.Email == email).FirstOrDefault();
        }
        public List<Customer> GetCustomerByName(string name)
        {
            var values = context.Customers
                .Where(x => DbFunctions.Like(x.Name + " " + x.Surname, "%" + name + "%"))
                .ToList();

            return values.Cast<Customer>().ToList();
        }
        public void ResetContext()
        {
            context.Dispose();
            context = new Context();
        }
    }
}
