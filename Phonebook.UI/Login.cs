using Phonebook.Models;
using Phonebook.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phonebook.UI
{
    public partial class Login : Form
    {
        private readonly IUserRepository _userRepo;
        private readonly IAddressRepository _addressRepo;
        private readonly IPhonenumberRepository _phoneRepo;
        private readonly ISocialMediaRepository _mediaRepo;
        private readonly IUser _user;
        public Login(IUser user)
        {
            InitializeComponent();
            _user = user;
            _addressRepo = new AddressRepository();
            _mediaRepo = new SocialMediaRepository();
            _phoneRepo = new PhonenumberRepository();
            _userRepo = new UserRepository();
        }

        private void view_details_btn_Click(object sender, EventArgs e)
        {
            output_label.Text = OutputSchema(_user);
        }

        public string OutputSchema(IUser user)
        {
            string output = $"Name: {user.FirstName} {user.LastName}" +
                $"\nAddress: {user.Address.Street}, {user.Address.City}, {user.Address.State}, {user.Address.ZipCode}, {user.Address.Country}." +
                $"\nPhonenumber: {string.Join(", ", user.PhoneNumber)}" +
                $"\nSocialMediaHandles: {string.Join("\n\t", user.SocialMediaHandles)}";
            return output;
        }

        private void view_all_btn_Click(object sender, EventArgs e)
        {
            List<IUser> AllUsers = _userRepo.GetAllUsers();
            string output = "";
            foreach (var user in AllUsers)
            {
                output += OutputSchema(user) + "\n\n"; 
            }
            output_label.Text = output;
            
        }
    }
}
