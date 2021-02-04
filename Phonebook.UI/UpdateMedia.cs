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
    public partial class UpdateMedia : Form
    {
        private readonly ISocialMediaRepository _socialRepo;
        private readonly IUserRepository _userRepo;
        private User _currentuser;
        public UpdateMedia(User currentuser)
        {
            InitializeComponent();
            _userRepo = new UserRepository();
            _socialRepo = new SocialMediaRepository();
            _currentuser = currentuser;
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (handle_txtbox.Text == null)
                {
                    throw new NullReferenceException("Field cannot be empty!");
                }
                if (mediacombo.SelectedItem == null)
                {
                    throw new NullReferenceException("Please select a valid media type");
                }
                if (_currentuser.SocialMediaHandles.ContainsKey(mediacombo.SelectedItem.ToString()))
                {
                    throw new DuplicateNameException("Oops! Handle already exists for this media type");
                }
                _currentuser.SocialMediaHandles.Add(mediacombo.SelectedItem.ToString(), handle_txtbox.Text);
                bool addedSuccesfully = await _socialRepo.AddSocialMediaHandle(_currentuser.UserID, mediacombo.SelectedItem.ToString(), handle_txtbox.Text);
                if (!addedSuccesfully)
                {
                    throw new DataException("Oops! Please try again.");
                }
                MessageBox.Show("Success!");
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool addedSuccesfully = await _socialRepo.UpdateSocialMediaHandle(_currentuser.UserID, handle_txtbox.Text, mediacombo.SelectedItem.ToString());
                if (!addedSuccesfully)
                {
                    throw new DataException("Oops! Please try again.");
                }
                MessageBox.Show("Success!");
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool addedSuccesfully = await _socialRepo.DeleteSocialMediaHandle(_currentuser.UserID, mediacombo.SelectedItem.ToString());
                if (!addedSuccesfully)
                {
                    throw new DataException("Unable to delete! Try again.");
                }
                MessageBox.Show("Success!");
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void back_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
