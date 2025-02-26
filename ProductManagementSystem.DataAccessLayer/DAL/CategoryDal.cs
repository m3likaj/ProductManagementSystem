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
        public Context _context;
        public CategoryDal(Context context)
        {
            this._context = context;
        }
        public Category GetByName(string name)
        {
            return _context.Categories.Where(c=>c.CategoryName==name).FirstOrDefault();
        }
       /* public void ResetContext()
        {
            _context.Dispose();
            _context = new Context();
        }*/

    }
}
