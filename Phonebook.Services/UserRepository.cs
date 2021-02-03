using Phonebook.DataAccessLayer;
using Phonebook.Models;
using System;
using System.Collections.Generic;
using Phonebook.Utilities.Helpers;
using Phonebook.Utilities.Enums;
using System.Threading.Tasks;
using System.Data;

namespace Phonebook.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly IAddressRepository _addressRepo;

        private readonly ISocialMediaRepository _socialMediaRepo;

        private readonly IPhonenumberRepository _phonenumberRepo;

        private readonly DataReader _dataReader;

        private readonly FileIO _fileIO;

        public UserRepository()
        {
            _addressRepo = new AddressRepository();
            _socialMediaRepo = new SocialMediaRepository();
            _phonenumberRepo = new PhonenumberRepository();
            _dataReader = new DataReader();
            _fileIO = new FileIO();
        }

        public IUser CreateUser(string firstName, string lastName, string email, string phonenumber, string password, List<string> phonenumbers)
        {
            string userId = Guid.NewGuid().ToString().Substring(9, 12);
            List<byte[]> encryptedPassword = PasswordEncryptor.EncryptPassword(password);
            User newUser = new User()
            {
                UserID = userId,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                MainPhoneNumber = phonenumber,
                PasswordHash = encryptedPassword[0],
                PasswordSalt = encryptedPassword[1],
                PhoneNumber = phonenumbers,
                UserType = UserType.Regular.ToString()
            };
            return newUser;
        }

        public void SetUserType(IUser user, string type)
        {
            if (type == UserType.Admin.ToString())
            {
                user.UserType = type;
            }
            if (type == UserType.Regular.ToString())
            {
                user.UserType = type;
            }
        }

        public async Task<bool> AddUser(IUser user)
        {
            string cmdtxt = @"insert into tblUser (UserID, FirstName, LastName, Email, MainPhoneNumber, UserType) values ('" + user.UserID + "', '" + user.FirstName + "', '" + user.LastName + "', '" + user.Email + "', '" + user.MainPhoneNumber + "', '" + user.UserType + "')";
            return await _dataReader.WriteToDatabase(cmdtxt);
        }

        public IUser GetUser(string userid)
        {
            IUser userToReturn = new User();
            string cmdtxt = @"select * from tblUser";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select($"UserID = '{userid}'"))
            {
                userToReturn.UserID = (string)add["UserID"];
                userToReturn.FirstName = (string)add["FirstName"];
                userToReturn.LastName = (string)add["LastName"];
                userToReturn.Email = (string)add["Email"];
                userToReturn.MainPhoneNumber = (string)add["MainPhoneNumber"];
                userToReturn.UserType = (string)add["UserType"];
                userToReturn.Address = _addressRepo.GetAddress(userid);
                userToReturn.PhoneNumber = _phonenumberRepo.GetPhonenumbers(userid);
                userToReturn.SocialMediaHandles = _socialMediaRepo.GetSocialMediaHandle(userid);
            }

            return userToReturn;
        }

        public IUser GetUserByEmail(string email)
        {
            IUser userToReturn = new User();
            string cmdtxt = @"select * from tblUser";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select($"Email = '{email}'"))
            {
                userToReturn.UserID = (string)add["UserID"];
                userToReturn.FirstName = (string)add["FirstName"];
                userToReturn.LastName = (string)add["LastName"];
                userToReturn.Email = (string)add["Email"];
                userToReturn.MainPhoneNumber = (string)add["MainPhoneNumber"];
                userToReturn.UserType = (string)add["UserType"];
                userToReturn.Address = _addressRepo.GetAddress(userToReturn.UserID);
                userToReturn.PhoneNumber = _phonenumberRepo.GetPhonenumbers(userToReturn.UserID);
                userToReturn.SocialMediaHandles = _socialMediaRepo.GetSocialMediaHandle(userToReturn.UserID);
            }

            return userToReturn;
        }

        public List<IUser> GetAllUsers()
        {
            List<IUser> Users = new List<IUser>();

            string cmdtxt = @"select * from tblUser";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select())
            {
                IUser user = new User
                {
                    UserID = (string)add["UserID"],
                    FirstName = (string)add["FirstName"],
                    LastName = (string)add["LastName"],
                    Email = (string)add["Email"],
                    MainPhoneNumber = (string)add["MainPhoneNumber"],
                    UserType = (string)add["UserType"]
                };
                user.Address = _addressRepo.GetAddress(user.UserID);
                user.PhoneNumber = _phonenumberRepo.GetPhonenumbers(user.UserID);
                user.SocialMediaHandles = _socialMediaRepo.GetSocialMediaHandle(user.UserID);

                Users.Add(user);
            }

            return Users;
        }

        public List<IUser> GetUsers(string name)
        {
            List<IUser> Users = new List<IUser>();

            string cmdtxt = @"select * from tblUser";

            DataTable tbl = _dataReader.ReadFromDatabase(cmdtxt);
            foreach (DataRow add in tbl.Select($"FirstName='{name}'"))
            {
                IUser user = new User
                {
                    UserID = (string)add["UserID"],
                    FirstName = (string)add["FirstName"],
                    LastName = (string)add["LastName"],
                    Email = (string)add["Email"],
                    MainPhoneNumber = (string)add["MainPhoneNumber"],
                    UserType = (string)add["UserType"]
                };
                user.Address = _addressRepo.GetAddress(user.UserID);
                user.PhoneNumber = _phonenumberRepo.GetPhonenumbers(user.UserID);
                user.SocialMediaHandles = _socialMediaRepo.GetSocialMediaHandle(user.UserID);

                Users.Add(user);
            }
            foreach (DataRow add in tbl.Select($"LastName='{name}'"))
            {
                IUser user = new User
                {
                    UserID = (string)add["UserID"],
                    FirstName = (string)add["FirstName"],
                    LastName = (string)add["LastName"],
                    Email = (string)add["Email"],
                    MainPhoneNumber = (string)add["MainPhoneNumber"],
                    UserType = (string)add["UserType"]
                };
                user.Address = _addressRepo.GetAddress(user.UserID);
                user.PhoneNumber = _phonenumberRepo.GetPhonenumbers(user.UserID);
                user.SocialMediaHandles = _socialMediaRepo.GetSocialMediaHandle(user.UserID);

                Users.Add(user);
            }

            return Users;
        }

        public Tuple<string, byte[], byte[]> GetAuth(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool AuthUser(string email, string password)
        {
            //authenticates user using a file reader to get and compare the data entered against the existing ones
            Dictionary<string,string> data = _fileIO.ReadPasswordFile();
            foreach (var kvp in data)
            {
                if (kvp.Key == email && kvp.Value == password)
                {
                    return true;
                }
            }
            return false;
        }

        public void StorePassword(string email, string password)
        {
            //formats password and email and sends it to the file writer
            string format = email + "|" + password;
            _fileIO.WritePasswordFile(format);
        }
    }
}
