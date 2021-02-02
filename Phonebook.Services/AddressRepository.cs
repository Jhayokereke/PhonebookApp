using Phonebook.DataAccessLayer;
using Phonebook.Models;
using System.Data;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DataReader _dataReader;

        public AddressRepository()
        {
            _dataReader = new DataReader();
        }
        public async Task<bool> AddAddress(string userid, Address address)
        {
            //Adds address to database
            string cmdtxt = @"insert into tblAddress (UserID, Street, City, State, ZipCode, Country) Values ('" + userid + "', '" + address.Street + "', '" + address.City + "', '" + address.State + "', '" + address.ZipCode + "', '" + address.Country + "')";

            return await _dataReader.WriteToDatabase(cmdtxt);
        }

        public Address GetAddress(string userid)
        {
            //Returns an address from database
            Address address = new Address();
            string cmdtxt = @"select * from tblAddress";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select($"UserID = '{userid}'"))
            {
                address.Street = (string)add["Street"];
                address.City = (string)add["City"];
                address.State = (string)add["State"];
                address.ZipCode = (int)add["ZipCode"];
                address.Country = (string)add["Country"];
            }
            return address;
        }

        public async Task<bool> UpdateAddress(string userid, Address address)
        {
            //Updates Address in database
            string cmdtxt = @"Update tblAddress set Street='" + address.Street + "', City='" + address.City + "', State='" + address.State + "', ZipCode='" + address.ZipCode + "', Country='" + address.Country + "' where UserID='" + userid + "'";
            return await _dataReader.UpdateDatabase(cmdtxt);
        }
    }
}
