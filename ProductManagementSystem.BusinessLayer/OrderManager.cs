using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.DataAccessLayer.DAL;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.BusinessLayer
{
    public class OrderManager
    {
        OrderDal orderDal;
        public OrderManager(Context context)
        {
            orderDal = new OrderDal(context);
        }
        public List<object> GetOrderDetails(int id)
        {
            return orderDal.GetOrderDetails(id);
        }
        public List<object> GetOrders()
        {
            return orderDal.GetOrders();
        }
        public Order Get(int id)
        {
            return orderDal.Get(id);
        }
    }
}
