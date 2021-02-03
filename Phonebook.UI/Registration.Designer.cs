
namespace Phonebook.UI
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstName_txtbox = new System.Windows.Forms.TextBox();
            this.lastname_txtbox = new System.Windows.Forms.TextBox();
            this.phonenumber_txtbox = new System.Windows.Forms.TextBox();
            this.email_txtbox = new System.Windows.Forms.TextBox();
            this.confirm_password_txtbox = new System.Windows.Forms.TextBox();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.signup_button = new System.Windows.Forms.Button();
            this.firstname_label = new System.Windows.Forms.Label();
            this.Lastname_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.signin_link = new System.Windows.Forms.LinkLabel();
            this.signin_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstName_txtbox
            // 
            this.firstName_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstName_txtbox.Location = new System.Drawing.Point(37, 26);
            this.firstName_txtbox.Name = "firstName_txtbox";
            this.firstName_txtbox.PlaceholderText = "Ikemefuna";
            this.firstName_txtbox.Size = new System.Drawing.Size(426, 28);
            this.firstName_txtbox.TabIndex = 0;
            this.firstName_txtbox.Tag = "";
            // 
            // lastname_txtbox
            // 
            this.lastname_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastname_txtbox.Location = new System.Drawing.Point(37, 105);
            this.lastname_txtbox.Name = "lastname_txtbox";
            this.lastname_txtbox.PlaceholderText = "Carter";
            this.lastname_txtbox.Size = new System.Drawing.Size(426, 28);
            this.lastname_txtbox.TabIndex = 1;
            // 
            // phonenumber_txtbox
            // 
            this.phonenumber_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonenumber_txtbox.Location = new System.Drawing.Point(37, 268);
            this.phonenumber_txtbox.Name = "phonenumber_txtbox";
            this.phonenumber_txtbox.PlaceholderText = "+2340000000000";
            this.phonenumber_txtbox.Size = new System.Drawing.Size(426, 28);
            this.phonenumber_txtbox.TabIndex = 3;
            // 
            // email_txtbox
            // 
            this.email_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_txtbox.Location = new System.Drawing.Point(37, 183);
            this.email_txtbox.Name = "email_txtbox";
            this.email_txtbox.PlaceholderText = "ikem_carter@mailcom";
            this.email_txtbox.Size = new System.Drawing.Size(426, 28);
            this.email_txtbox.TabIndex = 2;
            // 
            // confirm_password_txtbox
            // 
            this.confirm_password_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirm_password_txtbox.Location = new System.Drawing.Point(37, 442);
            this.confirm_password_txtbox.Name = "confirm_password_txtbox";
            this.confirm_password_txtbox.PlaceholderText = "*******************";
            this.confirm_password_txtbox.Size = new System.Drawing.Size(426, 28);
            this.confirm_password_txtbox.TabIndex = 5;
            // 
            // password_txtbox
            // 
            this.password_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_txtbox.Location = new System.Drawing.Point(37, 355);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PlaceholderText = "*****************";
            this.password_txtbox.Size = new System.Drawing.Size(426, 28);
            this.password_txtbox.TabIndex = 4;
            // 
            // signup_button
            // 
            this.signup_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.signup_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signup_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.signup_button.Location = new System.Drawing.Point(326, 505);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(136, 40);
            this.signup_button.TabIndex = 6;
            this.signup_button.Text = "Sign up";
            this.signup_button.UseVisualStyleBackColor = false;
            this.signup_button.Click += new System.EventHandler(this.signup_button_ClickAsync);
            // 
            // firstname_label
            // 
            this.firstname_label.AutoSize = true;
            this.firstname_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.firstname_label.Location = new System.Drawing.Point(37, 57);
            this.firstname_label.Name = "firstname_label";
            this.firstname_label.Size = new System.Drawing.Size(114, 27);
            this.firstname_label.TabIndex = 7;
            this.firstname_label.Text = "Firstname";
            // 
            // Lastname_label
            // 
            this.Lastname_label.AutoSize = true;
            this.Lastname_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lastname_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Lastname_label.Location = new System.Drawing.Point(37, 136);
            this.Lastname_label.Name = "Lastname_label";
            this.Lastname_label.Size = new System.Drawing.Size(109, 27);
            this.Lastname_label.TabIndex = 8;
            this.Lastname_label.Text = "Lastname";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.email_label.Location = new System.Drawing.Point(37, 214);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(71, 27);
            this.email_label.TabIndex = 9;
            this.email_label.Text = "Email";
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phonenumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.phonenumber_label.Location = new System.Drawing.Point(37, 299);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(155, 27);
            this.phonenumber_label.TabIndex = 10;
            this.phonenumber_label.Text = "Phonenumber";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.password_label.Location = new System.Drawing.Point(37, 386);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(110, 27);
            this.password_label.TabIndex = 11;
            this.password_label.Text = "Password";
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.AutoSize = true;
            this.confirm_password_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirm_password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.confirm_password_label.Location = new System.Drawing.Point(37, 473);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(206, 27);
            this.confirm_password_label.TabIndex = 12;
            this.confirm_password_label.Text = "Confirm Password";
            // 
            // signin_link
            // 
            this.signin_link.AutoSize = true;
            this.signin_link.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signin_link.Location = new System.Drawing.Point(255, 566);
            this.signin_link.Name = "signin_link";
            this.signin_link.Size = new System.Drawing.Size(86, 27);
            this.signin_link.TabIndex = 13;
            this.signin_link.TabStop = true;
            this.signin_link.Text = "Sign in";
            this.signin_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signin_link_LinkClicked);
            // 
            // signin_label
            // 
            this.signin_label.AutoSize = true;
            this.signin_label.Font = new System.Drawing.Font("High Tower Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signin_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.signin_label.Location = new System.Drawing.Point(39, 571);
            this.signin_label.Name = "signin_label";
            this.signin_label.Size = new System.Drawing.Size(210, 20);
            this.signin_label.TabIndex = 14;
            this.signin_label.Text = "Already have an account?";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(526, 611);
            this.Controls.Add(this.signin_label);
            this.Controls.Add(this.signin_link);
            this.Controls.Add(this.confirm_password_label);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.phonenumber_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.Lastname_label);
            this.Controls.Add(this.firstname_label);
            this.Controls.Add(this.signup_button);
            this.Controls.Add(this.confirm_password_txtbox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.phonenumber_txtbox);
            this.Controls.Add(this.email_txtbox);
            this.Controls.Add(this.lastname_txtbox);
            this.Controls.Add(this.firstName_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Registration";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstName_txtbox;
        private System.Windows.Forms.TextBox lastname_txtbox;
        private System.Windows.Forms.TextBox phonenumber_txtbox;
        private System.Windows.Forms.TextBox email_txtbox;
        private System.Windows.Forms.TextBox confirm_password_txtbox;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Label firstname_label;
        private System.Windows.Forms.Label Lastname_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label confirm_password_label;
        private System.Windows.Forms.LinkLabel signin_link;
        private System.Windows.Forms.Label signin_label;
    }
}