using System;

namespace EnterpriseApplication.Invoice
{
    public interface IInvoice
    {
        void ChangeDuedate(DateTime newDuedate);
    }
}
