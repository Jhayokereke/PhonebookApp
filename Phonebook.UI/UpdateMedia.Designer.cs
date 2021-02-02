
namespace Phonebook.UI
{
    partial class UpdateMedia
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.back_link = new System.Windows.Forms.LinkLabel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.handle_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phonenumber_label
            // 
            this.phonenumber_label.AutoSize = true;
            this.phonenumber_label.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phonenumber_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.phonenumber_label.Location = new System.Drawing.Point(30, 33);
            this.phonenumber_label.Name = "phonenumber_label";
            this.phonenumber_label.Size = new System.Drawing.Size(136, 27);
            this.phonenumber_label.TabIndex = 11;
            this.phonenumber_label.Text = "Media Type";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Facebook",
            "Twitter",
            "WhatsApp",
            "Instagram",
            "LinkedIn",
            "TikTok",
            "SnapChat",
            "Other"});
            this.comboBox1.Location = new System.Drawing.Point(30, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // back_link
            // 
            this.back_link.AutoSize = true;
            this.back_link.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_link.LinkColor = System.Drawing.Color.Blue;
            this.back_link.Location = new System.Drawing.Point(30, 323);
            this.back_link.Name = "back_link";
            this.back_link.Size = new System.Drawing.Size(82, 21);
            this.back_link.TabIndex = 27;
            this.back_link.TabStop = true;
            this.back_link.Text = "Go back";
            this.back_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.delete_btn.Location = new System.Drawing.Point(341, 220);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(99, 72);
            this.delete_btn.TabIndex = 26;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.update_btn.Location = new System.Drawing.Point(187, 220);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(99, 72);
            this.update_btn.TabIndex = 25;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.add_btn.Location = new System.Drawing.Point(30, 220);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(99, 72);
            this.add_btn.TabIndex = 24;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // handle_txtbox
            // 
            this.handle_txtbox.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.handle_txtbox.Location = new System.Drawing.Point(30, 140);
            this.handle_txtbox.Name = "handle_txtbox";
            this.handle_txtbox.PlaceholderText = "@ikemcarter";
            this.handle_txtbox.Size = new System.Drawing.Size(410, 28);
            this.handle_txtbox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(30, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 27);
            this.label1.TabIndex = 22;
            this.label1.Text = "Social Media Handle";
            // 
            // UpdateMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(497, 372);
            this.Controls.Add(this.back_link);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.handle_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.phonenumber_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateMedia";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label phonenumber_label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel back_link;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox handle_txtbox;
        private System.Windows.Forms.Label label1;
    }
}