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
    public partial class UpdateAddress : Form
    {
        private User _user;
        private readonly IAddressRepository _addressRepo;
        public UpdateAddress(User currentuser)
        {
            InitializeComponent();
            _user = currentuser;
            _addressRepo = new AddressRepository();
        }

        private async void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(street_txtbox.Text) || string.IsNullOrWhiteSpace(city_txtbox.Text)
                    || string.IsNullOrWhiteSpace(state_txtbox.Text) || string.IsNullOrWhiteSpace(zipcode_txtbox.Text)
                    || string.IsNullOrWhiteSpace(countrybox.SelectedItem.ToString()))
                {
                    throw new ArgumentNullException("Incomplete address!");
                }
                if (!int.TryParse(zipcode_txtbox.Text, out _))
                {
                    throw new FormatException("Oops! Zipcode is not valid");
                }
                _user.Address = new Address()
                {
                    Street = street_txtbox.Text,
                    City = city_txtbox.Text,
                    State = state_txtbox.Text,
                    ZipCode = int.Parse(zipcode_txtbox.Text),
                    Country = countrybox.SelectedItem.ToString()
                };
                bool addedSuccesfully = await _addressRepo.UpdateAddress(_user.UserID, _user.Address);
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

        private void back_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }
    }
}
