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
    public partial class AdminLogin : Form
    {
        private readonly IUserRepository _userRepo;
        private readonly IAddressRepository _addressRepo;
        private readonly IPhonenumberRepository _phoneRepo;
        private readonly ISocialMediaRepository _mediaRepo;
        private readonly IUser _user;
        public AdminLogin(IUser user)
        {
            InitializeComponent();
            _user = user;
            _addressRepo = new AddressRepository();
            _mediaRepo = new SocialMediaRepository();
            _phoneRepo = new PhonenumberRepository();
            _userRepo = new UserRepository();
        }
    }
}
