using Microsoft.Extensions.Logging;
using NLog;
using Phonebook.Models;
using Phonebook.Services;
using Phonebook.Utilities.Enums;
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
        private readonly User _user;
        private string data = "";
        Logger log = LogManager.GetCurrentClassLogger();
        public Login(User user)
        {
            InitializeComponent();
            _user = user;
            _userRepo = new UserRepository();
            update_addr_btn.Visible = false;
            update_media_btn.Visible = false;
            update_phone_btn.Visible = false;
        }

        private void view_details_btn_Click(object sender, EventArgs e)
        {
            display_box.Text = OutputSchema(_user);
        }

        public string OutputSchema(User user)
        {
            string output = $"UserID: {user.UserID}" +
                $"\nName: {user.FirstName} {user.LastName}" +
                $"\nAddress: {user.Address.Street}, {user.Address.City}, {user.Address.State}, {user.Address.ZipCode}, {user.Address.Country}." +
                $"\nPhonenumber: {string.Join(", ", user.PhoneNumber)}" +
                $"\nSocialMediaHandles: {string.Join("\n\t", user.SocialMediaHandles)}";
            return output;
        }

        private void view_all_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_user.UserType == "Regular")
                {
                    throw new AccessViolationException("Sorry, You are not an admin.");
                }
                List<User> AllUsers = _userRepo.GetAllUsers();
                string output = "";
                foreach (var user in AllUsers)
                {
                    output += OutputSchema(user) + "\n\n";
                }
                display_box.Text = output;
            }
            catch (AccessViolationException av)
            {
                MessageBox.Show(av.Message);
                log.Error(av);
            }
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
            update_addr_btn.Visible = false;
            update_media_btn.Visible = false;
            update_phone_btn.Visible = false;
        }

        private void update_phone_btn_Click(object sender, EventArgs e)
        {
            UpdatePhone up = new UpdatePhone(_user);
            Hide();
            up.ShowDialog();
            Show();
            update_addr_btn.Visible = false;
            update_media_btn.Visible = false;
            update_phone_btn.Visible = false;
        }

        private void update_media_btn_Click(object sender, EventArgs e)
        {
            UpdateMedia um = new UpdateMedia(_user);
            Hide();
            um.ShowDialog();
            Show();
            update_addr_btn.Visible = false;
            update_media_btn.Visible = false;
            update_phone_btn.Visible = false;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            data += display_box.Text + "\n\n";
        }

        private void show_all_btn_Click(object sender, EventArgs e)
        {
            display_box.Text = data;
        }

        private void clear_all_btn_Click(object sender, EventArgs e)
        {
            data = "";
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            Close();
        }

        private void delete_user_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_user.UserType == "Regular")
                {
                    throw new AccessViolationException("Sorry, You are not an admin.");
                }
                DeleteUser du = new DeleteUser();
                Hide();
                du.ShowDialog();
                Show();
            }
            catch (AccessViolationException ae)
            {
                MessageBox.Show(ae.Message);
                log.Error(ae);
            }
        }
    }
}
