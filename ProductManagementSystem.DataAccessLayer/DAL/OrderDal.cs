using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.DataAccessLayer.DAL
{
    public class OrderDal : GenericFunctions<Order>
    {
        Context context = new Context();
       public List<object> GetOrderDetails(int id)
        {
            Order order = Get(id);
            var values = context.OrderProducts.Where(o => o.OrderID == id)
                                              .Join(context.Products,
                                              o => o.ProductID,
                                              p => p.ProductId,
                                              (o,p) => new
                                              {
                                                  p.Name,
                                                  p.Price,
                                                  o.Quantity,
                                                  TotalPrice = o.Quantity * p.Price,
                                              }).ToList();
            return values.Cast<object>().ToList();
        }
    }
}
