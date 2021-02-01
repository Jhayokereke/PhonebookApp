using Phonebook.DataAccessLayer;
using Phonebook.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    class SocialMediaRepository : ISocialMediaRepository
    {
        private readonly DataReader _dataReader;
        public SocialMediaRepository()
        {
            _dataReader = new DataReader();
        }
        public async Task<bool> AddSocialMediaHandle(string userid, string handle)
        {
            //Adds user media handle to database
            string cmdtxt = @"insert into tblSocialMediaHandle (UserID, SocialMediaHandle) Values ('" + userid + "', '" + handle + "')";
            return await _dataReader.WriteToDatabase(cmdtxt);
        }
        public List<string> GetSocialMediaHandle(string userid)
        {
            //retrieves user media handle from database
            List<string> socialMediaHandles = new List<string>();
            string cmdtxt = @"select * from tblSocialMediaHandle";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select($"UserID = '{userid}'"))
            {
                socialMediaHandles.Add((string)add["SocialMediaHandle"]);
            }
            return socialMediaHandles;
        }

        public async Task<bool> UpdateSocialMediaHandle(string userid, string newhandle, string mediatype)
        {
            //Updates handle in database
            string cmdtxt = @"Update tblSocialMediaHandle set SocialMediaHandle='" + newhandle + "' where UserID='" + userid + "', MediaType='" + mediatype + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }

        public async Task<bool> DeleteSocialMediaHandle(string userid, string newhandle, string mediatype)
        {
            //Deletes handle from database
            string cmdtxt = @"Delete tblSocialMediaHandle where UserID='" + userid + "', MediaType='" + mediatype + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }
    }
}
