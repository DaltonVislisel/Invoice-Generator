namespace InvoiceGenerator.MVM.Model
{
    internal class Client
    {
        public int ClientId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string? Email { get; set; }

        public Client(int clientId, string name, string address, string phoneNumber, string? email)
        {
            ClientId = clientId;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
