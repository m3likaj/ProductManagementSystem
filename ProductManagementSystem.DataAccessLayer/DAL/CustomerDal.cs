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
