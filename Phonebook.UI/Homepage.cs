using Phonebook.Utilities;
using Phonebook.Services;
using System;
using System.Threading;
using System.Windows.Forms;
using Phonebook.Models;
using Phonebook.Utilities.Helpers;

namespace Phonebook.UI
{
    internal class Homepage : Form
    {
        private readonly IUserRepository _userRepo;

        private TextBox email_textbox;
        private TextBox password_textBox;
        private Button sign_in_button;
        private LinkLabel forgotPassword;
        private Label AppName;
        private Label email_label;
        private Label password_label;
        private LinkLabel linkLabel1;
        private Label theme_label;
        private Label signup_label;
        private Panel panel1;

        public Homepage()
        {
            InitializeComponent();
            _userRepo = new UserRepository();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.AppName = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.theme_label = new System.Windows.Forms.Label();
            this.signup_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(522, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 465);
            this.panel1.TabIndex = 0;
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_textbox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.email_textbox.Location = new System.Drawing.Point(28, 134);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(399, 28);
            this.email_textbox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_textBox.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.password_textBox.Location = new System.Drawing.Point(28, 215);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(399, 28);
            this.password_textBox.TabIndex = 2;
            // 
            // sign_in_button
            // 
            this.sign_in_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.sign_in_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sign_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sign_in_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sign_in_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.sign_in_button.Location = new System.Drawing.Point(296, 284);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(131, 36);
            this.sign_in_button.TabIndex = 3;
            this.sign_in_button.Text = "Sign in";
            this.sign_in_button.UseVisualStyleBackColor = false;
            this.sign_in_button.Click += new System.EventHandler(this.sign_in_button_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forgotPassword.LinkColor = System.Drawing.Color.Blue;
            this.forgotPassword.Location = new System.Drawing.Point(78, 325);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(163, 21);
            this.forgotPassword.TabIndex = 4;
            this.forgotPassword.TabStop = true;
            this.forgotPassword.Text = "Forgot password?";
            this.forgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.Font = new System.Drawing.Font("High Tower Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AppName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.AppName.Location = new System.Drawing.Point(48, 37);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(179, 39);
            this.AppName.TabIndex = 5;
            this.AppName.Text = "Phonebook";
            this.AppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.email_label.Location = new System.Drawing.Point(40, 171);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(71, 27);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.password_label.Location = new System.Drawing.Point(40, 252);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(110, 27);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(221, 421);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 27);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // theme_label
            // 
            this.theme_label.AutoSize = true;
            this.theme_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.theme_label.Location = new System.Drawing.Point(606, 466);
            this.theme_label.Name = "theme_label";
            this.theme_label.Size = new System.Drawing.Size(207, 27);
            this.theme_label.TabIndex = 9;
            this.theme_label.Text = "Devote your heart!";
            // 
            // signup_label
            // 
            this.signup_label.AutoSize = true;
            this.signup_label.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.signup_label.Location = new System.Drawing.Point(106, 425);
            this.signup_label.Name = "signup_label";
            this.signup_label.Size = new System.Drawing.Size(109, 23);
            this.signup_label.TabIndex = 15;
            this.signup_label.Text = "New here?";
            // 
            // Homepage
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(896, 494);
            this.Controls.Add(this.signup_label);
            this.Controls.Add(this.theme_label);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.sign_in_button);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Registration r =  new Registration();
            r.ShowDialog();
            Show();
        }

        private void sign_in_button_Click(object sender, System.EventArgs e)
        {
            string email = email_textbox.Text;
            string password = password_textBox.Text;
            User user = new User();
            try
            {
                if (string.IsNullOrWhiteSpace(email)||string.IsNullOrWhiteSpace(password))
                {
                    throw new FormatException("Invalid entry!");
                }
                if (_userRepo.AuthUser(email, password))
                {
                    user = _userRepo.GetUserByEmail(email);
                    if (user != null)
                    {
                        email_textbox.Clear();
                        password_textBox.Clear();
                        Login l = new Login(user);
                        Hide();
                        l.ShowDialog();
                        Show();
                    }
                    else throw new NullReferenceException("User not found!");
                }
                else throw new NullReferenceException("Invalid email or password!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}