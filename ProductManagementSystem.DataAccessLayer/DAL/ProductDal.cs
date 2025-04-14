using ProductManagementSystem.EntityLayer.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ProductManagementSystem.DataAccessLayer.EntityFramework
{
    public class ProductDal : GenericFunctions<Product>
    {
        public Context _context;
        public ProductDal(Context context)
        {
            _context = context;
        }

        
        public List<object> GetProductsByCategory(string category, bool productPage=true)
        {
            if (productPage)
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
            else
            {
                var values = _context.Products
                                    .Where(p => p.Categories.Any(c => c.CategoryName == category) && p.Stock>0)
                                    .Include(x => x.Categories) // Ensures categories are loaded
                                    .ToList() // Brings data into memory, allowing string operations
                                    .Select(x => new
                                    {
                                        ProductID = x.ProductId,
                                        Name = x.Name,
                                        Price = x.Price
                                    })
                                    .ToList();

                return values.Cast<object>().ToList();
            }
        }

        public List<object> GetProductByName(string name, bool productsPage=true)
        {
            name = name.ToLower();
            if (productsPage)
            {
                var values = _context.Products
                                    .Where(x => x.Name.ToLower().Contains(name))
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
            else
            {
                var values = _context.Products
                                   .Where(x => x.Name.ToLower().Contains(name) && x.Stock>0)
                                   .Select(x => new
                                   {
                                       ProductID = x.ProductId,
                                       Name = x.Name,
                                       Price = x.Price,
                                   })
                                   .ToList();
                return values.Cast<object>().ToList();
            }
        }
        public void ResetContext()
        {
            var entries = _context.ChangeTracker.Entries().ToList();
            foreach (var entry in entries)
            {
                entry.State = EntityState.Detached;
            }
        }

        public List<object> GetProductsWithCategory()
        {
            var values = _context.Products
                                .Include(x => x.Categories) // Ensures categories are loaded
                                .AsNoTracking()
                                .ToList() // Brings data into memory, allowing string operations
                                .Select(x => new
                                {
                                    ProductID = x.ProductId,
                                    Name = x.Name,
                                    Price = x.Price,
                                    Stock = x.Stock,
                                    Category = (x.Categories.Count() > 0) ? getCategories(x.Categories) : "no category" // Works in memory
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

        public List<object> getProductsWithPrice()
        {
            var values = _context.Products
                                .Select(x => new
                                {
                                    ProductID = x.ProductId,
                                    Name = x.Name,
                                    Price = x.Price,
                                })
                                .ToList();

            return values.Cast<object>().ToList();
        }
       
    }
}

