using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.DataAccessLayer.DAL
{
    public class CategoryDal: GenericFunctions<Category>
    {
        Context context;
        public CategoryDal()
        {
            context = new Context();
        }
        public Category GetByName(string name)
        {
            return context.Categories.Where(c=>c.CategoryName==name).FirstOrDefault();
        }
        public void ResetContext()
        {
            context.Dispose();
            context = new Context();
        }

    }
}
