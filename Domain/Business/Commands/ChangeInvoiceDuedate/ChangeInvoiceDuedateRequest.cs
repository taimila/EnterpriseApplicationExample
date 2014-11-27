using System;

namespace Business.Commands.ChangeInvoiceDuedate
{
    public class ChangeInvoiceDuedateRequest
    {
        public string Number { get; set; }
        public DateTime NewDuedate { get; set; }
    }
}
