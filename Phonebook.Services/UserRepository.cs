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

        public UserRepository()
        {
            _addressRepo = new AddressRepository();
            _socialMediaRepo = new SocialMediaRepository();
            _phonenumberRepo = new PhonenumberRepository();
            _dataReader = new DataReader();
        }

        public IUser CreateUser(string firstName, string lastName, string email, string phonenumber, string password, Address address, List<string> phonenumbers, Dictionary<string, string> mediahandles)
        {
            string userId = new Guid().ToString().Substring(2, 5);
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
                Address = address,
                PhoneNumber = phonenumbers,
                SocialMediaHandles = mediahandles
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
            await _addressRepo.AddAddress(user.UserID, user.Address);
            foreach (var num in user.PhoneNumber)
            {
                await _phonenumberRepo.AddPhonenumber(user.UserID, num);
            }

            string cmdtxt = @"insert into tblUser UserID='" + user.UserID + "', FirstName='" + user.FirstName + "', LastName='" + user.LastName + "', Email='" + user.Email + "', MainPhoneNumber='" + user.MainPhoneNumber + "', UserType='" + user.UserType + "'";
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
    }
}
