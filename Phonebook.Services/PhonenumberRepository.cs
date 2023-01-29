using Phonebook.DataAccessLayer;
using Phonebook.Utilities;
using System;
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

        public async Task<bool> AddPhonenumber(string userid, string phonenum, bool main)
        {
            //Adds user phonenumber to database
            if (Validation.ValidatePhonenumber(phonenum))
            {
                string index = main ? "0" : "1";
                string cmdtxt = @"insert into tblPhonenumber (UserID, Phonenumber, MainPhonenumber) Values ('" + userid + "', '" + phonenum + "', '" + index + "')";
                return await _dataReader.WriteToDatabase(cmdtxt);
            }
            throw new FormatException("Invalid phonenumber!");
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

        public string GetMainPhonenumber(string userid)
        {
            //retrieves user main phone number from database
            string cmdtxt = @"select * from tblPhonenumber";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select(@"UserID = '"+userid+"' AND MainPhonenumber ='0'"))
            {
                return (string)add["Phonenumber"];
            }
            return null;
        }

        public async Task<bool> UpdatePhonenumber(string userid, string phonenum, string newPhonenum, bool main)
        {
            //Updates phonenumber in database
            if (Validation.ValidatePhonenumber(phonenum))
            {
                string index = main ? "1" : "0";
                string cmdtxt = @"Update tblPhonenumber set Phonenumber='" + newPhonenum + "', MainPhonenumber='" + index + "' where UserID='" + userid + "' and Phonenumber='" + phonenum + "'";
                return await _dataReader.UpdateDatabase(cmdtxt);
            }
            throw new FormatException("Invalid phonenumber!");
            
        }

        public async Task<bool> DeletePhonenumber(string userid, string phonenum)
        {
            //Deletes phonenumber from database
            string cmdtxt = @"Delete tblPhonenumber where UserID='"+userid+ "' and Phonenumber='" + phonenum + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }
    }
}
