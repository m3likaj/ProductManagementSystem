using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.DataAccessLayer.EntityFramework
{
    public class ProductDal : GenericFunctions<Product>
    {
        public Context _context;
        public ProductDal(Context context)
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
        public List<object> GetProductsByCategory(string category)
        {
            var values = _context.Products
                                .Where(p => p.Categories.Any(c => c.CategoryName == category))
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

        public List<object> GetProductByName(string name)
        {
            var values = _context.Products
                                .Where(x => x.Name == name)
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
       /* public void ResetContext()
        {
            _context.Dispose();
            _context = new Context();
        }*/

        public List<object> GetProductsWithCategory()
        {
            var values = _context.Products
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
                Categories += item.CategoryName + ", ";
            }
            return Categories;
        }

        public void AddCategoryToProduct(List<int> SelectedCategories, Product product)
        {
            // Ensure that the product is being tracked by the same context
            var trackedProduct = _context.Products
                                         .Include(p => p.Categories)
                                         .FirstOrDefault(p => p.ProductId == product.ProductId);

            if (trackedProduct != null)
            {
                // Fetch the categories from the same context
                var categories = _context.Categories
                                         .Where(c => SelectedCategories.Contains(c.CategoryID))
                                         .ToList();

                // Add categories to the tracked product
                foreach (var category in categories)
                {
                    if (!trackedProduct.Categories.Contains(category))
                    {
                        trackedProduct.Categories.Add(category);
                    }
                }

                // Save changes to the context
                _context.SaveChanges();
            }
        }
    }
}
