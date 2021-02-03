
namespace Phonebook.UI
{
    partial class UpdatePhone
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
            this.phonenumber_label = new System.Windows.Forms.Label();
            this.phonenumber_txtbox = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.back_link = new System.Windows.Forms.LinkLabel();
            this.new_main_link = new System.Windows.Forms.LinkLabel();
            this.newnum_txtbox = new System.Windows.Forms.TextBox();
            this.new_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phonenumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.phonenumber_label.Location = new System.Drawing.Point(29, 61);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(155, 27);
            this.phonenumber_label.TabIndex = 9;
            this.phonenumber_label.Text = "Phonenumber";
            // 
            // phonenumber_txtbox
            // 
            this.phonenumber_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phonenumber_txtbox.Location = new System.Drawing.Point(29, 30);
            this.phonenumber_txtbox.Name = "phonenumber_txtbox";
            this.phonenumber_txtbox.PlaceholderText = "+2340000000000";
            this.phonenumber_txtbox.Size = new System.Drawing.Size(410, 28);
            this.phonenumber_txtbox.TabIndex = 10;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.add_btn.Location = new System.Drawing.Point(29, 180);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(99, 72);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.update_btn.Location = new System.Drawing.Point(186, 180);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(99, 72);
            this.update_btn.TabIndex = 12;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.delete_btn.Location = new System.Drawing.Point(340, 180);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(99, 72);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // back_link
            // 
            this.back_link.AutoSize = true;
            this.back_link.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_link.LinkColor = System.Drawing.Color.Blue;
            this.back_link.Location = new System.Drawing.Point(29, 282);
            this.back_link.Name = "back_link";
            this.back_link.Size = new System.Drawing.Size(82, 21);
            this.back_link.TabIndex = 14;
            this.back_link.TabStop = true;
            this.back_link.Text = "Go back";
            this.back_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.back_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_link_LinkClicked);
            // 
            // new_main_link
            // 
            this.new_main_link.AutoSize = true;
            this.new_main_link.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.new_main_link.LinkColor = System.Drawing.Color.Blue;
            this.new_main_link.Location = new System.Drawing.Point(237, 282);
            this.new_main_link.Name = "new_main_link";
            this.new_main_link.Size = new System.Drawing.Size(202, 21);
            this.new_main_link.TabIndex = 15;
            this.new_main_link.TabStop = true;
            this.new_main_link.Text = "Change main number";
            this.new_main_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.new_main_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.new_main_link_LinkClicked);
            // 
            // newnum_txtbox
            // 
            this.newnum_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.newnum_txtbox.Location = new System.Drawing.Point(29, 105);
            this.newnum_txtbox.Name = "newnum_txtbox";
            this.newnum_txtbox.PlaceholderText = "+2340000000000";
            this.newnum_txtbox.Size = new System.Drawing.Size(410, 28);
            this.newnum_txtbox.TabIndex = 17;
            // 
            // new_num
            // 
            this.new_num.AutoSize = true;
            this.new_num.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.new_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.new_num.Location = new System.Drawing.Point(29, 136);
            this.new_num.Name = "new_num";
            this.new_num.Size = new System.Drawing.Size(211, 27);
            this.new_num.TabIndex = 16;
            this.new_num.Text = "New Phonenumber";
            // 
            // UpdatePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(473, 338);
            this.Controls.Add(this.newnum_txtbox);
            this.Controls.Add(this.new_num);
            this.Controls.Add(this.new_main_link);
            this.Controls.Add(this.back_link);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.phonenumber_txtbox);
            this.Controls.Add(this.phonenumber_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "UpdatePhone";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.TextBox phonenumber_txtbox;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.LinkLabel back_link;
        private System.Windows.Forms.LinkLabel new_main_link;
        private System.Windows.Forms.TextBox newnum_txtbox;
        private System.Windows.Forms.Label new_num;
    }
}