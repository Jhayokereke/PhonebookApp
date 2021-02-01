using System.Windows.Forms;

namespace Phonebook.UI
{
    internal class Form1 : Form
    {
        private TextBox email_textbox;
        private TextBox password_textBox;
        private Button button1;
        private LinkLabel forgotPassword;
        private Label AppName;
        private Label email_label;
        private Label password_label;
        private Panel panel1;

        public Form1()
        {
            this.InitializeComponent();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.forgotPassword = new System.Windows.Forms.LinkLabel();
            this.AppName = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(375, 503);
            this.panel1.TabIndex = 0;
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email_textbox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.email_textbox.Location = new System.Drawing.Point(28, 134);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(399, 27);
            this.email_textbox.TabIndex = 1;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_textBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.password_textBox.Location = new System.Drawing.Point(28, 215);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.Size = new System.Drawing.Size(399, 27);
            this.password_textBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.button1.Location = new System.Drawing.Point(296, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // forgotPassword
            // 
            this.forgotPassword.AutoSize = true;
            this.forgotPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.forgotPassword.LinkColor = System.Drawing.Color.Blue;
            this.forgotPassword.Location = new System.Drawing.Point(114, 347);
            this.forgotPassword.Name = "forgotPassword";
            this.forgotPassword.Size = new System.Drawing.Size(161, 25);
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
            this.email_label.Location = new System.Drawing.Point(40, 171);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(71, 27);
            this.email_label.TabIndex = 6;
            this.email_label.Text = "Email";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(40, 252);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(110, 27);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(896, 494);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.AppName);
            this.Controls.Add(this.forgotPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }
    }
}