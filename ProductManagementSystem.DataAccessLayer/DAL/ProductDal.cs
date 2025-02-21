using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.DataAccessLayer.EntityFramework
{
    public class ProductDal : GenericFunctions<Product>
    {
        public Context context;
        public ProductDal()
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
        public List<Product> GetProductsByCategory(string category)
        {
            return context.Products
                .Where(p => p.Categories.Any(c => c.CategoryName == category))
                .ToList();
        }

        public List<Product> GetProductByName(string name)
        {
            var values = context.Products
                .Where(x => x.Name == name)
                .ToList();

            return values.Cast<Product>().ToList();
        }
        public void ResetContext()
        {
            context.Dispose();
            context = new Context();
        }
        public List<object> GetProductsWithCategory()
        {
            var values = context.Products
                                .Include(x => x.Categories) // Ensures categories are loaded
                                .ToList() // Brings data into memory, allowing string operations
                                .Select(x => new
                                {
                                    ProductID = x.ProductId,
                                    Name = x.Name,
                                    Price = x.Price,
                                    Stock = x.Stock,
                                    Category = getCategories(x.Categories) // Works in memory
                                })
                                .ToList();



            return values.Cast<object>().ToList();
        }


        public string getCategories(ICollection<Category> categories)
        {
            string Categories = "";
            foreach (Category item in categories)
            {
                Categories += item.CategoryName + " ";
            }
            return Categories;
        }
    }
}
