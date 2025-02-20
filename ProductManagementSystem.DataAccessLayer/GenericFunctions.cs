using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.DataAccessLayer
{
    public class GenericFunctions<T> where T : class
    {
        Context context = new Context();
        private readonly DbSet<T> Object;
        public GenericFunctions()
        {
            Object = context.Set<T>();
        }
        public List<T> GetAll()
        {
            return Object.ToList();
        }
        public T Get(int id)
        {
            if(id>0)
                return Object.Find(id);
            return null;
        }
        public void Add(T entity)
        {
            Object.Add(entity);
            context.SaveChanges();
        }
        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void Delete(T entity) 
        {
            Object.Remove(entity);
            context.SaveChanges();
        }
        

    }
}