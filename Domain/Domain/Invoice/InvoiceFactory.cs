using System;

namespace EnterpriseApplication.Invoice
{
    public class InvoiceFactory
    {
        public virtual IInvoice Create(string number, DateTime duedate)
        {
            return new Invoice
            {
                Id = Guid.NewGuid(),
                Number = number,
                Duedate = duedate
            };
        }
    }
}
