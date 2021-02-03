using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public interface IUserRepository
    {
        Task<bool> AddUser(User user);
        User CreateUser(string firstName, string lastName, string email, string phonenumber, string password, List<string> phonenumbers);
        List<User> GetAllUsers();
        User GetUser(string userid);
        User GetUserByEmail(string email);
        List<User> GetUsers(string name);
        Tuple<string, byte[], byte[]> GetAuth(string email, string password);
        void SetUserType(User user, string type);
        bool AuthUser(string email, string password);
        void StorePassword(string email, string password);
    }
}