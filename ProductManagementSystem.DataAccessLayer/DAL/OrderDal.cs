using System.Collections.Generic;
using System.Linq;
using ProductManagementSystem.DataAccessLayer.EntityFramework;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.DataAccessLayer.DAL
{
    public class OrderDal : GenericFunctions<Order>
    {
        public Context context;
        public OrderDal(Context _context)
        {
            context = _context;
        }
        public List<object> GetOrderDetails(int id)
        {
            Order order = Get(id);
            var values = context.OrderProducts.Where(o => o.OrderID == id)
                                              .Join(context.Products,
                                              o => o.ProductID,
                                              p => p.ProductId,
                                              (o, p) => new
                                              {
                                                  p.Name,
                                                  p.Price,
                                                  o.Quantity,
                                                  TotalPrice = o.Quantity * p.Price
                                              }).ToList();
            return values.Cast <object>().ToList();
        }
        public List<object> GetOrders()
        {
            var values = context.Orders
                                .AsNoTracking()
                                .ToList()
                                .Select(x => new
                                {
                                    OrderID = x.OrderId,
                                    Products = (x.OrderProducts.Count() > 0) ? getProducts(x.OrderProducts) : "no products" ,// Works in memory
                                    Price = x.TotalPrice,
                                    Status = x.OrderStatus
                                })
                                .ToList();

            return values.Cast<object>().ToList();
        }
        public string getProducts(ICollection<OrderProduct> products)
        {
            string Products = "";
            foreach (OrderProduct item in products)
                Products += item.Product.Name + " x " + item.Quantity.ToString()+ ", ";

            return Products.TrimEnd(',', ' ');
        }
    }
}
