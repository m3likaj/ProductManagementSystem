using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.DataAccessLayer.DAL;
using ProductManagementSystem.DataAccessLayer.EntityFramework;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.BusinessLayer
{
    public class CategoryManager
    {
        CategoryDal categoryDal;
        public CategoryManager(Context context) {
            categoryDal = new CategoryDal(context);
        }

       
        public List<Category> GetAll()
        {
            return categoryDal.GetAll();
        }
        public void Add(Category entity)
        {
            categoryDal.Add(entity);
        }
        public void Update(Category entity)
        {
            categoryDal.Update(entity);
        }
        public void Delete(Category customer)
        {
            categoryDal.Delete(customer);

        }
        public Category Get(int id)
        {
            return categoryDal.Get(id);
        }
        
        /*public void ResetContext()
        {
            categoryDal.ResetContext();
        }*/
        public Category GetByName(string name)
        {
            return categoryDal.GetByName(name);
        }

        public Context GetContext()
        {
            return categoryDal._context;
        }   
    }
}
