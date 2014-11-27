using EnterpriseApplication.Invoice;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Linq;

namespace Persistence
{
    public class InvoiceRepository : MongoRepository, IInvoiceRepository
    {
        public InvoiceRepository(MongoClient mongo) : base(mongo) { }

        public IInvoice GetById(Guid id)
        {
            return Invoices.AsQueryable<Invoice>()
                           .Single(c => c.Id == id);
        }

        public IInvoice GetByNumber(string invoiceNumber)
        {
            return Invoices.AsQueryable<Invoice>()
                           .Single(c => c.Number == invoiceNumber);
        }

        public void Save(IInvoice invoice)
        {
            Invoices.Save(invoice);
        }

        MongoCollection<IInvoice> Invoices
        {
            get { return Database.GetCollection<IInvoice>("invoices"); }
        }
    }
}
