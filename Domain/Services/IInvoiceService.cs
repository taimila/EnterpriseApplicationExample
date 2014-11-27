using System;
using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface IInvoiceService
    {
        [OperationContract]
        void ChangeInvoiceDuedate(string invoiceNumber, DateTime newDuedate);
    }
}