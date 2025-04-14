using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.DataAccessLayer;
using ProductManagementSystem.DataAccessLayer.DAL;
using ProductManagementSystem.EntityLayer.Concrete;

namespace ProductManagementSystem.BusinessLayer
{
    public class InvoiceManager
    {
        InvoiceDal invoicedal;
        public InvoiceManager(Context context)
        {
            invoicedal = new InvoiceDal(context);
        }
        public void Add(Invoice invoice)
        {
            invoicedal.Add(invoice);
        }
        public Invoice Get(int id)
        {
            return invoicedal.Get(id);
        }
        public Invoice GetByOrder(int orderId)
        {
            return invoicedal.GetByOrder(orderId);
        }
    }
}
