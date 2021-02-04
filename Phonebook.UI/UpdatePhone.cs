using Phonebook.Models;
using Phonebook.Services;
using Phonebook.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phonebook.UI
{
    public partial class UpdatePhone : Form
    {
        private readonly IPhonenumberRepository _phoneRepo;
        private User _currentuser;

        public UpdatePhone(User currentuser)
        {
            InitializeComponent();
            _phoneRepo = new PhonenumberRepository();
            _currentuser = currentuser;
            newnum_txtbox.Visible = false;
            new_num.Visible = false;
        }

        private async void add_btn_Click(object sender, EventArgs e)
        {
            if (delete_btn.Visible && update_btn.Visible && phonenumber_txtbox.Visible && phonenumber_label.Visible)
            {
                try
                {
                    if (!Validation.ValidatePhonenumber(phonenumber_txtbox.Text) || string.IsNullOrWhiteSpace(phonenumber_txtbox.Text))
                    { throw new FormatException("Invalid Phonenumber!"); }
                    if (_currentuser.PhoneNumber.Contains(phonenumber_txtbox.Text))
                    {
                        throw new DuplicateNameException("Oops! Phonenumber already exists");
                    }
                    _currentuser.PhoneNumber.Add(phonenumber_txtbox.Text);
                    bool addedSuccesfully = await _phoneRepo.AddPhonenumber(_currentuser.UserID, phonenumber_txtbox.Text, false);
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
            else
            {
                try
                {
                    if (!Validation.ValidatePhonenumber(phonenumber_txtbox.Text) || string.IsNullOrWhiteSpace(phonenumber_txtbox.Text))
                    { throw new FormatException("Invalid Phonenumber!"); }
                    if (!Validation.ValidatePhonenumber(newnum_txtbox.Text) || string.IsNullOrWhiteSpace(newnum_txtbox.Text))
                    { throw new FormatException("Invalid Phonenumber!"); }
                    string oldMain = _phoneRepo.GetMainPhonenumber(_currentuser.UserID);
                    bool addedSuccesfully = _currentuser.PhoneNumber.Contains(newnum_txtbox.Text)
                        ? await _phoneRepo.UpdatePhonenumber(_currentuser.UserID, newnum_txtbox.Text, newnum_txtbox.Text, true)
                        : await _phoneRepo.AddPhonenumber(_currentuser.UserID, newnum_txtbox.Text, true);

                    if (!addedSuccesfully)
                    {
                        delete_btn.Visible = true;
                        update_btn.Visible = true;
                        phonenumber_txtbox.Visible = true;
                        phonenumber_label.Visible = true;
                        newnum_txtbox.Visible = false;
                        new_num.Visible = false;
                        new_main_link.Visible = true;
                        throw new DataException("Oops! Please try again.");
                    }
                    bool success = await _phoneRepo.UpdatePhonenumber(_currentuser.UserID, oldMain, oldMain, false);
                    _currentuser.PhoneNumber.Add(newnum_txtbox.Text);
                    MessageBox.Show("Success!");

                    delete_btn.Visible = true;
                    update_btn.Visible = true;
                    phonenumber_txtbox.Visible = true;
                    phonenumber_label.Visible = true;
                    newnum_txtbox.Visible = false;
                    new_num.Visible = false;
                    new_main_link.Visible = true;
                }
                catch (Exception ea)
                {
                    delete_btn.Visible = true;
                    update_btn.Visible = true;
                    phonenumber_txtbox.Visible = true;
                    phonenumber_label.Visible = true;
                    newnum_txtbox.Visible = false;
                    new_num.Visible = false;
                    new_main_link.Visible = true;
                    MessageBox.Show(ea.Message);
                }
            }
            
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            if (newnum_txtbox.Visible && new_num.Visible)
            {
                try
                {
                    bool addedSuccesfully = await _phoneRepo.UpdatePhonenumber(_currentuser.UserID, phonenumber_txtbox.Text, newnum_txtbox.Text, false);
                    if (!addedSuccesfully)
                    {
                        throw new DataException("Oops! Please try again.");
                    }
                    _currentuser.PhoneNumber.Add(phonenumber_txtbox.Text);
                    MessageBox.Show("Success!");
                    newnum_txtbox.Visible = false;
                    new_num.Visible = false;
                }
                catch (DuplicateNameException ev)
                {
                    newnum_txtbox.Visible = false;
                    new_num.Visible = false;
                    MessageBox.Show(ev.Message);
                }
            }
            newnum_txtbox.Visible = true;
            new_num.Visible = true;
        }

        private async void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (phonenumber_txtbox.Text == _currentuser.MainPhoneNumber)
                {
                    throw new NotSupportedException("Sorry, you cannot delete your main number!");
                }
                bool addedSuccesfully = await _phoneRepo.DeletePhonenumber(_currentuser.UserID, phonenumber_txtbox.Text);
                if (!addedSuccesfully)
                {
                    throw new DataException("Oops! Please try again.");
                }
                _currentuser.PhoneNumber.Remove(phonenumber_txtbox.Text);
                MessageBox.Show("Success!");
            }
            catch (DuplicateNameException ev)
            {
                MessageBox.Show(ev.Message);
            }
        }

        private void back_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (delete_btn.Visible && update_btn.Visible && phonenumber_txtbox.Visible && phonenumber_label.Visible)
            {
                Close();
            }
            delete_btn.Visible = true;
            update_btn.Visible = true;
            phonenumber_txtbox.Visible = true;
            phonenumber_label.Visible = true;
            newnum_txtbox.Visible = false;
            new_num.Visible = false;
            new_main_link.Visible = true;
        }

        private void new_main_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            delete_btn.Visible = false;
            update_btn.Visible = false;
            phonenumber_txtbox.Visible = false;
            phonenumber_label.Visible = false;
            newnum_txtbox.Visible = true;
            new_num.Visible = true;
            new_main_link.Visible = false;
        }
    }
}
