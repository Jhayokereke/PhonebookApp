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
    public partial class OtherRegistration : Form
    {
        private readonly IUserRepository _userRepo;
        private readonly IPhonenumberRepository _phoneRepo;
        private readonly ISocialMediaRepository _socialRepo;
        private IUser _user;

        public OtherRegistration(IUser user)
        {
            InitializeComponent();
            _user = user;
            _userRepo = new UserRepository();
            _phoneRepo = new PhonenumberRepository();
            _socialRepo = new SocialMediaRepository();
            _user.SocialMediaHandles = new Dictionary<string, string>();
        }

        private async void add_media_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_user.SocialMediaHandles.ContainsKey((string)mediacombo.SelectedItem))
                {
                    throw new DuplicateNameException("Oops! Handle already exists");
                }
                _user.SocialMediaHandles.Add(mediacombo.SelectedItem.ToString(), handle_txtbox.Text);
                bool addedSuccesfully = await _socialRepo.AddSocialMediaHandle(_user.UserID, mediacombo.SelectedItem.ToString(), handle_txtbox.Text);
                if (!addedSuccesfully)
                {
                    throw new DataException("Oops! Please try again.");
                }
                MessageBox.Show("Success!");
            }
            catch (DuplicateNameException ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private async void add_phone_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_user.PhoneNumber.Contains(phonenumber_txtbox.Text))
                {
                    throw new DuplicateNameException("Oops! Phonenumber already exists");
                }
                _user.PhoneNumber.Add(phonenumber_txtbox.Text);
                bool addedSuccesfully = await _phoneRepo.AddPhonenumber(_user.UserID, phonenumber_txtbox.Text);
                if (!addedSuccesfully)
                {
                    throw new DataException("Oops! Please try again.");
                }
                MessageBox.Show("Success!");
            }
            catch (DuplicateNameException ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            Login l = new Login(_user);
            Hide();
            l.ShowDialog();
            Close();
        }
    }
}
