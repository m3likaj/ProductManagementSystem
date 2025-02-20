using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.DataAccessLayer.EntityFramework;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.BusinessLayer
{
    public class CustomerManager
    {
        CustomerDal customerDal = new CustomerDal();
        public List<Customer> GetAll()
        {
            return customerDal.GetAll();
        }
        public Customer Get(int id)
        {
            return customerDal.Get(id);
        }
        public void Add(Customer entity)
        {
      
            customerDal.Add(entity);
        }
        public void Update(Customer entity)
        {
            customerDal.Update(entity);
        }
        public void Delete(Customer customer)
        {
            customerDal.Delete(customer);

        }
        public List<IEnumerable<object>> GetOrderHistory(int id)
        {
            return customerDal.GetOrderHistory(id);
        }
        public Customer GetCustomerByPhone(string phone)
        {
            return customerDal.GetCustomerByPhone(phone);
        }
        public Customer GetCustomerByEmail(string email)
        {
            return customerDal.GetCustomerByEmail(email);
        }
        public List<Customer> GetCustomerByName(string name)
        {
            return customerDal.GetCustomerByName(name);
        }
        public void ResetContext()
        {
            customerDal.ResetContext();
        }
    }
}
