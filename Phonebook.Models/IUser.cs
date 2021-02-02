using Phonebook.Utilities.Enums;
using System.Collections.Generic;

namespace Phonebook.Models
{
    public interface IUser
    {
        Address Address { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        byte[] PasswordHash { get; set; }
        byte[] PasswordSalt { get; set; }
        string MainPhoneNumber { get; set; }
        List<string> PhoneNumber { get; set; }
        Dictionary<string, string> SocialMediaHandles { get; set; }
        string UserID { get; set; }
        string UserType { get; set; }
    }
}