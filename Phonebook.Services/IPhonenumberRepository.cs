using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public interface IPhonenumberRepository
    {
        Task<bool> AddPhonenumber(string userid, string phonenum, bool main);
        List<string> GetPhonenumbers(string userid);
        string GetMainPhonenumber(string userid);
        Task<bool> DeletePhonenumber(string userid, string phonenum);
        Task<bool> UpdatePhonenumber(string userid, string phonenum, string newPhonenum, bool main);
    }
}