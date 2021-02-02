using Phonebook.DataAccessLayer;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public class PhonenumberRepository : IPhonenumberRepository
    {
        private readonly DataReader _dataReader;

        public PhonenumberRepository()
        {
            _dataReader = new DataReader();
        }

        public async Task<bool> AddPhonenumber(string userid, string phonenum)
        {
            //Adds user phonenumber to database
            string cmdtxt = @"insert into tblPhonenumber (UserID, Phonenumber) Values ('" + userid + "', '" + phonenum + "')";
            return await _dataReader.WriteToDatabase(cmdtxt);
        }

        public List<string> GetPhonenumbers(string userid)
        {
            //retrieves user phone number from database
            List<string> phonenumbers = new List<string>();
            string cmdtxt = @"select * from tblPhonenumber";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select($"UserID = '{userid}'"))
            {
                phonenumbers.Add((string)add["Phonenumber"]);
            }
            return phonenumbers;
        }

        public async Task<bool> UpdatePhonenumber(string userid, string phonenum, string newPhonenum)
        {
            //Updates phonenumber in database
            string cmdtxt = @"Update tblPhonenumber set Phonenumber='" + newPhonenum + "' where UserID='" + userid + "', Phonenumber='" + phonenum + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }

        public async Task<bool> DeletePhonenumber(string userid, string phonenum)
        {
            //Deletes phonenumber from database
            string cmdtxt = @"Delete tblPhonenumber where UserID='"+userid+ "', Phonenumber='" + phonenum + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }
    }
}
