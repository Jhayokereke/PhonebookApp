using System.Collections.Generic;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public interface ISocialMediaRepository
    {
        Task<bool> AddSocialMediaHandle(string userid, string handle);
        Dictionary<string, string> GetSocialMediaHandle(string userid);
        Task<bool> UpdateSocialMediaHandle(string userid, string newhandle, string mediatype);
        Task<bool> DeleteSocialMediaHandle(string userid, string newhandle, string mediatype);
    }
}