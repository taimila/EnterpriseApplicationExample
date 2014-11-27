using Business.Commands.ChangeInvoiceDuedate;
using System;

namespace Services
{
    public class InvoiceService : IInvoiceService
    {
        ChangeInvoiceDuedateCommand changeInvoiceDuedate;

        public InvoiceService(ChangeInvoiceDuedateCommand changeInvoiceDuedate)
        {
            this.changeInvoiceDuedate = changeInvoiceDuedate;
        }

        public void ChangeInvoiceDuedate(string invoiceNumber, DateTime newDuedate)
        {
            var request = new ChangeInvoiceDuedateRequest
            {
                Number = invoiceNumber,
                NewDuedate = newDuedate
            };

            changeInvoiceDuedate.Execute(request);
        }
    }
}
