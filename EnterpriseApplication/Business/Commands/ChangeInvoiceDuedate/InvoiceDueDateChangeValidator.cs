using System;

namespace Business.Commands.ChangeInvoiceDuedate
{
    public class InvoiceDueDateChangeValidator
    {
        public bool IsDuedateValid(DateTime duedate)
        {
            // Dummy validation for illustration purposes
            return duedate > DateTime.Today;
        }
    }
}
