
namespace Phonebook.UI
{
    partial class DeleteUser
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
            this.UserID_label = new System.Windows.Forms.Label();
            this.userID_txtbox = new System.Windows.Forms.TextBox();
            this.delete_button = new System.Windows.Forms.Button();
            this.confirm_btn = new System.Windows.Forms.Button();
            this.back_link = new System.Windows.Forms.LinkLabel();
            this.Info_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserID_label
            // 
            this.UserID_label.AutoSize = true;
            this.UserID_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserID_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.UserID_label.Location = new System.Drawing.Point(35, 61);
            this.UserID_label.Name = "UserID_label";
            this.UserID_label.Size = new System.Drawing.Size(90, 27);
            this.UserID_label.TabIndex = 8;
            this.UserID_label.Text = "UserID";
            // 
            // userID_txtbox
            // 
            this.userID_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userID_txtbox.Location = new System.Drawing.Point(35, 30);
            this.userID_txtbox.Name = "userID_txtbox";
            this.userID_txtbox.PlaceholderText = "Ikemefuna";
            this.userID_txtbox.Size = new System.Drawing.Size(267, 28);
            this.userID_txtbox.TabIndex = 7;
            this.userID_txtbox.Tag = "";
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.delete_button.Location = new System.Drawing.Point(35, 149);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(123, 40);
            this.delete_button.TabIndex = 13;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // confirm_btn
            // 
            this.confirm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.confirm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirm_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.confirm_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.confirm_btn.Location = new System.Drawing.Point(179, 149);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(123, 40);
            this.confirm_btn.TabIndex = 14;
            this.confirm_btn.Text = "Confirm";
            this.confirm_btn.UseVisualStyleBackColor = false;
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // back_link
            // 
            this.back_link.AutoSize = true;
            this.back_link.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_link.Location = new System.Drawing.Point(35, 209);
            this.back_link.Name = "back_link";
            this.back_link.Size = new System.Drawing.Size(62, 27);
            this.back_link.TabIndex = 15;
            this.back_link.TabStop = true;
            this.back_link.Text = "Back";
            this.back_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.back_link_LinkClicked);
            // 
            // Info_label
            // 
            this.Info_label.AutoSize = true;
            this.Info_label.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Info_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Info_label.Location = new System.Drawing.Point(35, 103);
            this.Info_label.Name = "Info_label";
            this.Info_label.Size = new System.Drawing.Size(0, 21);
            this.Info_label.TabIndex = 16;
            // 
            // DeleteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(374, 258);
            this.Controls.Add(this.Info_label);
            this.Controls.Add(this.back_link);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.UserID_label);
            this.Controls.Add(this.userID_txtbox);
            this.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteUser";
            this.Text = "DeleteUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserID_label;
        private System.Windows.Forms.TextBox userID_txtbox;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button confirm_btn;
        private System.Windows.Forms.LinkLabel back_link;
        private System.Windows.Forms.Label Info_label;
    }
}