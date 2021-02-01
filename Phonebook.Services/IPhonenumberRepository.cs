using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public interface IPhonenumberRepository
    {
        Task<bool> AddPhonenumber(string userid, string phonenum);
        List<string> GetPhonenumbers(string userid);
        Task<bool> DeletePhonenumber(string userid, string phonenum);
    }
}