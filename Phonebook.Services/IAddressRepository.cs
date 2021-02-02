using Phonebook.Models;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public interface IAddressRepository
    {
        Task<bool> AddAddress(string userid, Address add);
        Address GetAddress(string userid);
        Task<bool> UpdateAddress(string userid, Address address);
    }
}