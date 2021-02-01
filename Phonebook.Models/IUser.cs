using System.Collections.Generic;

namespace Phonebook.Models
{
    public interface IUser
    {
        Address Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PasswordHash { get; set; }
        string PasswordSalt { get; set; }
        List<string> PhoneNumber { get; set; }
        List<string> SocialMediaHandles { get; set; }
        string UserID { get; set; }
    }
}