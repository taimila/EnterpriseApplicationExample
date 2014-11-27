using System;

namespace EnterpriseApplication.Invoice
{
    public interface IInvoiceRepository
    {
        IInvoice GetById(Guid id);
        IInvoice GetByNumber(string invoiceNumber);

        void Save(IInvoice invoice);
    }
}
