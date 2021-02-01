namespace Phonebook.Models
{
    public interface IAddress
    {
        string City { get; set; }
        string Country { get; set; }
        string State { get; set; }
        string Street { get; set; }
        int ZipCode { get; set; }
    }
}