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
        public Context _context;
        public CustomerDal(Context context)
        {
            _context = context;
        }
        public List<IEnumerable<object>> GetOrderHistory(int id)
        {
            var values = _context.Invoices.Where(inv => inv.CustomerID == id).Select(i => new
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
            return _context.Customers.Where(x => x.PhoneNumber == phone).FirstOrDefault();
        }
        public Customer GetCustomerByEmail(string email)
        {
            return _context.Customers.Where(x => x.Email == email).FirstOrDefault();
        }
        public List<Customer> GetCustomerByName(string name)
        {
            var values = _context.Customers
                .Where(x => DbFunctions.Like(x.Name + " " + x.Surname, "%" + name + "%"))
                .ToList();

            return values.Cast<Customer>().ToList();
        }
        public void ResetContext()
        {
            _context.Dispose();
            _context = new Context();
        }
    }
}
