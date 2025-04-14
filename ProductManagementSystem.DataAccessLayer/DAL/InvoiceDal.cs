using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.DataAccessLayer.DAL
{
    public class InvoiceDal: GenericFunctions<Invoice>
    {
        public Context context;
        public InvoiceDal(Context _context)
        {
            context = _context;
        }
        //public List<object> GetInvoices()
        //{
        //}
        public Invoice GetByOrder(int orderId)
        {
            return context.Invoices.FirstOrDefault(i => i.OrderID == orderId);
        }
    }
    
}
