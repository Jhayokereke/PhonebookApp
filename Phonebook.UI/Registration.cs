using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Phonebook.UI
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void signin_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Homepage h = new Homepage();
            
            h.Show();

            this.Dispose();
        }
    }
}
