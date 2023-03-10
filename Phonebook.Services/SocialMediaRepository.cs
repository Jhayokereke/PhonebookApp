using Phonebook.DataAccessLayer;
using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public class SocialMediaRepository : ISocialMediaRepository
    {
        private readonly DataReader _dataReader;
        public SocialMediaRepository()
        {
            _dataReader = new DataReader();
        }
        public async Task<bool> AddSocialMediaHandle(string userid, string type, string handle)
        {
            //Adds user media handle to database
            string cmdtxt = @"insert into tblSocialMediaHandle (UserID, MediaType, SocialMediaHandle) Values ('" + userid + "', '" + type + "', '" + handle + "')";
            return await _dataReader.WriteToDatabase(cmdtxt);
        }
        public Dictionary<string, string> GetSocialMediaHandle(string userid)
        {
            //retrieves user media handle from database
            Dictionary<string, string> socialMediaHandles = new Dictionary<string, string>();
            string cmdtxt = @"select * from tblSocialMediaHandle";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select($"UserID = '{userid}'"))
            {
                socialMediaHandles.Add((string)add["MediaType"], (string)add["SocialMediaHandle"]);
            }
            return socialMediaHandles;
        }

        public async Task<bool> UpdateSocialMediaHandle(string userid, string newhandle, string mediatype)
        {
            //Updates handle in database
            string cmdtxt = @"Update tblSocialMediaHandle set SocialMediaHandle='" + newhandle + "' where UserID='" + userid + "' and MediaType='" + mediatype + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }

        public async Task<bool> DeleteSocialMediaHandle(string userid, string mediatype)
        {
            //Deletes handle from database
            string cmdtxt = @"Delete tblSocialMediaHandle where UserID='" + userid + "', MediaType='" + mediatype + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }
    }
}
