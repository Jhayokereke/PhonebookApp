namespace Phonebook.Models
{
    public class Address : IAddress
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

        public string Country { get; set; }
    }
}