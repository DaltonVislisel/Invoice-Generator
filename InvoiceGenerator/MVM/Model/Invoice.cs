using System.Collections.Generic;

namespace InvoiceGenerator.MVM.Model
{
    internal class Invoice
    {
        public int InvoiceNumber { get; set; }

        public readonly Dictionary<Service, int> _services;

        public Client Client { get; set; }

        public Invoice(int invoiceNumber, Client client, Dictionary<Service, int> services)
        {
            InvoiceNumber = invoiceNumber;
            _services = services;
            Client = client;
        }
    }
}
