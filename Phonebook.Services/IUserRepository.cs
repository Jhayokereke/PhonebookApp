using Phonebook.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    interface IUserRepository
    {
        Task<bool> AddUser(IUser user);
        IUser CreateUser(string firstName, string lastName, string email, string phonenumber, string password, Address address, List<string> phonenumbers, Dictionary<string, string> mediahandles);
        List<IUser> GetAllUsers();
        IUser GetUser(string userid);
        List<IUser> GetUsers(string name);
        void SetUserType(IUser user, string type);
    }
}