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
            update_addr_btn.Visible = false;
            update_media_btn.Visible = false;
            update_phone_btn.Visible = false;
        }

        private void view_details_btn_Click(object sender, EventArgs e)
        {
            display_box.Text = OutputSchema(_user);
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
            display_box.Text = output;
            
        }

        private void display_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            display_box.Text = null;
        }

        private void Edit_btn_Click_1(object sender, EventArgs e)
        {
            update_addr_btn.Visible = true;
            update_media_btn.Visible = true;
            update_phone_btn.Visible = true;
        }

        private void update_addr_btn_Click(object sender, EventArgs e)
        {
            UpdateAddress ua = new UpdateAddress(_user);
            Hide();
            ua.ShowDialog();
            Show();
        }

        private void update_phone_btn_Click(object sender, EventArgs e)
        {
            UpdatePhone up = new UpdatePhone(_user);
            Hide();
            up.ShowDialog();
            Show();
        }

        private void update_media_btn_Click(object sender, EventArgs e)
        {
            UpdateMedia um = new UpdateMedia(_user);
            Hide();
            um.ShowDialog();
            Show();
        }

    }
}
