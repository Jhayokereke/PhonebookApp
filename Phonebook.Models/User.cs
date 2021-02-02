using Phonebook.Utilities.Enums;
using System;
using System.Collections.Generic;

namespace Phonebook.Models
{
    public class User : IUser
    {
        public string UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public List<string> PhoneNumber { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public Address Address { get; set; }

        public Dictionary<string, string> SocialMediaHandles { get; set; }
        public string MainPhoneNumber { get; set; }
        public string UserType { get; set; }
    }
}
