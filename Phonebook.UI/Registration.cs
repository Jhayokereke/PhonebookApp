using Phonebook.Models;
using Phonebook.Services;
using Phonebook.Utilities;
using Phonebook.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook.UI
{
    public partial class Registration : Form
    {
        private readonly IUserRepository _userRepo;
        private readonly IPhonenumberRepository _phoneRepo;

        public Registration()
        {
            InitializeComponent();
            _userRepo = new UserRepository();
            _phoneRepo = new PhonenumberRepository();
        }

        private void signin_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private async void signup_button_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.ValidateName(firstName_txtbox.Text))
                {
                    throw new FormatException("Invalid firstname!");
                }
                if (!Validation.ValidateName(lastname_txtbox.Text))
                {
                    throw new FormatException("Invalid lastname!");
                }
                if (!Validation.ValidateEmail(email_txtbox.Text))
                {
                    throw new FormatException("Invalid email!");
                }
                if (!Validation.ValidatePhonenumber(phonenumber_txtbox.Text))
                {
                    throw new FormatException("Invalid phonenumber!");
                }
                if (password_txtbox.Text != confirm_password_txtbox.Text)
                {
                    throw new FormatException("Password does not match!");
                }
                else
                {
                    string firstName = firstName_txtbox.Text,lastName = lastname_txtbox.Text,
                        email = email_txtbox.Text, mainPhoneNumber = phonenumber_txtbox.Text,
                        password = password_txtbox.Text;
                    List<string> phoneNumber = new List<string>() { phonenumber_txtbox.Text };
                    _userRepo.StorePassword(email, password);
                    IUser newUser = _userRepo.CreateUser(firstName, lastName, email, mainPhoneNumber, password, phoneNumber);
                    bool addedSuccesfully = await _userRepo.AddUser(newUser);
                    bool success = await _phoneRepo.AddPhonenumber(newUser.UserID, mainPhoneNumber);
                    if (!addedSuccesfully||!success)
                    {
                        throw new DataException("Oops! Please try again.");
                    }
                    
                    MessageBox.Show(this, "Successful");
                    AnotherReg a = new AnotherReg(newUser);
                    Hide();
                    a.ShowDialog();
                    Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(this, es.Message);
            }
        }
    }
}
