using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.DataAccessLayer.EntityFramework;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.BusinessLayer
{
    public class ProductManager
    {
        ProductDal productDal;
        public ProductManager(Context context)
        {
            productDal= new ProductDal(context);
        }
        
        public List<Product> GetAll()
        {
            return productDal.GetAll();
        }
        public Product Get(int id)
        {
            return productDal.Get(id);
        }
        public void Add(Product entity)
        {

            productDal.Add(entity);
        }
        public void Update(Product entity)
        {
            productDal.Update(entity);
        }
        public void Delete(Product customer)
        {
            productDal.Delete(customer);

        }
        public List<IEnumerable<object>> GetOrderHistory(int id)
        {
            return productDal.GetOrderHistory(id);
        }


        public List<object> GetProductsByName(string name)
        {
            return productDal.GetProductByName(name);
        }
        public List<object> GetProductsByCategory(string category)
        {
            return productDal.GetProductsByCategory(category);
        }
        public List<object> GetProductsWithCategory()
        {
            return productDal.GetProductsWithCategory();
        }
        public void ResetContext()
        {
            productDal.ResetContext();
        }
        public Context GetContext() { 
            return productDal._context;
        }
        public void AddCategoryToProduct(List<int> SelectedCategories, Product product)
        {
            productDal.AddCategoryToProduct(SelectedCategories, product);
        }
        public List<object> getProductsWithPrice()
        {
            return productDal.getProductsWithPrice();
        }
    }
}
