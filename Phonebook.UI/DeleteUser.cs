using Microsoft.Extensions.Logging;
using NLog;
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
    public partial class DeleteUser : Form
    {
        private readonly IUserRepository _userRepo;
        Logger log = LogManager.GetCurrentClassLogger();
        public DeleteUser()
        {
            InitializeComponent();
            _userRepo = new UserRepository();
            confirm_btn.Enabled = false;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (userID_txtbox.Text == null)
                {
                    throw new NullReferenceException("Enter a userID");
                }
                User user = _userRepo.GetUser(userID_txtbox.Text);
                if (user == null)
                {
                    throw new NullReferenceException("User does not exist!");
                }
                Info_label.Text = $"Are you sure you want to delete User{user.UserID}?";
                confirm_btn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                log.Error(ex);
            }
        }

        private async void confirm_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool successful = await _userRepo.DeleteUserAsync(userID_txtbox.Text);
                if (!successful)
                {
                    throw new DBConcurrencyException("Failed to delete! Try again.");
                }
                confirm_btn.Enabled = false;
                Info_label.Text = $"User{userID_txtbox.Text} deleted";
                userID_txtbox.Text = null;
            }
            catch (Exception db)
            {
                MessageBox.Show(db.Message);
                confirm_btn.Enabled = false;
                userID_txtbox.Text = null;
                log.Error(db);
            }
        }

        private void back_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
