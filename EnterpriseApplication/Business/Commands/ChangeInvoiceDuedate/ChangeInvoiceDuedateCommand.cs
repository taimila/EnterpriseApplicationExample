using EnterpriseApplication.Invoice;

namespace Business.Commands.ChangeInvoiceDuedate
{
    public class ChangeInvoiceDuedateCommand
    {
        IInvoiceRepository invoiceRepository;
        InvoiceDueDateChangeValidator validator;

        public ChangeInvoiceDuedateCommand(IInvoiceRepository invoiceRepository)
        {
            this.invoiceRepository = invoiceRepository;
            this.validator = new InvoiceDueDateChangeValidator();
        }

        public void Execute(ChangeInvoiceDuedateRequest request)
        {
            if(validator.IsDuedateValid(request.NewDuedate))
            {
                IInvoice invoice = invoiceRepository.GetByNumber(request.Number);
                invoice.ChangeDuedate(request.NewDuedate);
                invoiceRepository.Save(invoice);
            }
            else
            {
                throw new InvalidDueDateException();
            }
        }
    }
}
