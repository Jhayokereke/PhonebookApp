
namespace Phonebook.UI
{
    partial class AnotherReg
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
            this.address = new System.Windows.Forms.Label();
            this.countrybox = new System.Windows.Forms.ComboBox();
            this.zipcode = new System.Windows.Forms.Label();
            this.zipcode_txtbox = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.Label();
            this.state_txtbox = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.Label();
            this.city_txtbox = new System.Windows.Forms.TextBox();
            this.street = new System.Windows.Forms.Label();
            this.street_txtbox = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.Label();
            this.done_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.address.Location = new System.Drawing.Point(123, 22);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(119, 34);
            this.address.TabIndex = 60;
            this.address.Text = "Address";
            // 
            // countrybox
            // 
            this.countrybox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.countrybox.FormattingEnabled = true;
            this.countrybox.Items.AddRange(new object[] {
            "Nigeria",
            "U.S.A"});
            this.countrybox.Location = new System.Drawing.Point(13, 319);
            this.countrybox.Name = "countrybox";
            this.countrybox.Size = new System.Drawing.Size(361, 28);
            this.countrybox.TabIndex = 59;
            // 
            // zipcode
            // 
            this.zipcode.AutoSize = true;
            this.zipcode.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.zipcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.zipcode.Location = new System.Drawing.Point(13, 288);
            this.zipcode.Name = "zipcode";
            this.zipcode.Size = new System.Drawing.Size(109, 27);
            this.zipcode.TabIndex = 58;
            this.zipcode.Text = "Zip Code";
            // 
            // zipcode_txtbox
            // 
            this.zipcode_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zipcode_txtbox.Location = new System.Drawing.Point(13, 259);
            this.zipcode_txtbox.Name = "zipcode_txtbox";
            this.zipcode_txtbox.PlaceholderText = "100218";
            this.zipcode_txtbox.Size = new System.Drawing.Size(361, 28);
            this.zipcode_txtbox.TabIndex = 57;
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.state.Location = new System.Drawing.Point(13, 229);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(65, 27);
            this.state.TabIndex = 56;
            this.state.Text = "State";
            // 
            // state_txtbox
            // 
            this.state_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.state_txtbox.Location = new System.Drawing.Point(13, 200);
            this.state_txtbox.Name = "state_txtbox";
            this.state_txtbox.PlaceholderText = "Texas";
            this.state_txtbox.Size = new System.Drawing.Size(361, 28);
            this.state_txtbox.TabIndex = 55;
            // 
            // city
            // 
            this.city.AutoSize = true;
            this.city.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.city.Location = new System.Drawing.Point(13, 170);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(57, 27);
            this.city.TabIndex = 54;
            this.city.Text = "City";
            // 
            // city_txtbox
            // 
            this.city_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.city_txtbox.Location = new System.Drawing.Point(13, 139);
            this.city_txtbox.Name = "city_txtbox";
            this.city_txtbox.PlaceholderText = "Houston";
            this.city_txtbox.Size = new System.Drawing.Size(361, 28);
            this.city_txtbox.TabIndex = 53;
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.street.Location = new System.Drawing.Point(13, 109);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(75, 27);
            this.street.TabIndex = 52;
            this.street.Text = "Street";
            // 
            // street_txtbox
            // 
            this.street_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.street_txtbox.Location = new System.Drawing.Point(13, 77);
            this.street_txtbox.Name = "street_txtbox";
            this.street_txtbox.PlaceholderText = "17 Palms Avenue";
            this.street_txtbox.Size = new System.Drawing.Size(361, 28);
            this.street_txtbox.TabIndex = 51;
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Country.Location = new System.Drawing.Point(13, 350);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(99, 27);
            this.Country.TabIndex = 50;
            this.Country.Text = "Country";
            // 
            // done_btn
            // 
            this.done_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.done_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.done_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.done_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.done_btn.Location = new System.Drawing.Point(80, 396);
            this.done_btn.Name = "done_btn";
            this.done_btn.Size = new System.Drawing.Size(212, 42);
            this.done_btn.TabIndex = 61;
            this.done_btn.Text = "Done";
            this.done_btn.UseVisualStyleBackColor = false;
            this.done_btn.Click += new System.EventHandler(this.done_btn_Click);
            // 
            // AnotherReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(397, 450);
            this.Controls.Add(this.done_btn);
            this.Controls.Add(this.address);
            this.Controls.Add(this.countrybox);
            this.Controls.Add(this.zipcode);
            this.Controls.Add(this.zipcode_txtbox);
            this.Controls.Add(this.state);
            this.Controls.Add(this.state_txtbox);
            this.Controls.Add(this.city);
            this.Controls.Add(this.city_txtbox);
            this.Controls.Add(this.street);
            this.Controls.Add(this.street_txtbox);
            this.Controls.Add(this.Country);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnotherReg";
            this.Text = "AnotherReg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label address;
        private System.Windows.Forms.ComboBox countrybox;
        private System.Windows.Forms.Label zipcode;
        private System.Windows.Forms.TextBox zipcode_txtbox;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.TextBox state_txtbox;
        private System.Windows.Forms.Label city;
        private System.Windows.Forms.TextBox city_txtbox;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.TextBox street_txtbox;
        private System.Windows.Forms.Label Country;
        private System.Windows.Forms.Button done_btn;
    }
}