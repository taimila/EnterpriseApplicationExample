using System;

namespace EnterpriseApplication.Invoice
{
    public class Invoice : IInvoice
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public DateTime Duedate { get; set; }

        public void ChangeDuedate(DateTime newDuedate)
        {
            // There is more complex logic, but thats not the 
            // point of this blog post and therefore skipped.
            Duedate = newDuedate;
        }
    }
}
