using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public interface IUserRepository
    {
        Task<bool> AddUser(IUser user);
        IUser CreateUser(string firstName, string lastName, string email, string phonenumber, string password, List<string> phonenumbers);
        List<IUser> GetAllUsers();
        IUser GetUser(string userid);
        IUser GetUserByEmail(string email);
        List<IUser> GetUsers(string name);
        Tuple<string, byte[], byte[]> GetAuth(string email, string password);
        void SetUserType(IUser user, string type);
    }
}