using System.Collections.Generic;

namespace InvoiceGenerator.MVM.Model
{
    internal class Business
    {
        private string Name { get; }

        private readonly List<Invoice> _invoices;

        public Business(string name)
        {
            Name = name;
            _invoices = new List<Invoice>();
        }
    }
}
