using NLog;
using Phonebook.Models;
using Phonebook.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace Phonebook.UI
{
    public partial class AnotherReg : Form
    {
        private readonly IUserRepository _userRepo;
        private readonly IAddressRepository _addressRepository;
        private User _user;
        Logger log = LogManager.GetCurrentClassLogger();
        public AnotherReg(User user)
        {
            InitializeComponent();
            _user = user;
            _userRepo = new UserRepository();
            _addressRepository = new AddressRepository();
        }

        private async void done_btn_Click(object sender, EventArgs e)
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
                bool addedSuccesfully = await _addressRepository.AddAddress(_user.UserID, _user.Address);
                if (!addedSuccesfully)
                {
                    throw new DataException("Oops! Please try again.");
                }
                MessageBox.Show("Success");
                OtherRegistration o = new OtherRegistration(_user);
                Hide();
                o.ShowDialog();
                Close();
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
                log.Error(ev);
            }
        }
    }
}
