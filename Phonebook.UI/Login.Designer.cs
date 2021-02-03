
namespace Phonebook.UI
{
    partial class Login
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
            this.view_all_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.view_details_btn = new System.Windows.Forms.Button();
            this.output_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // view_all_btn
            // 
            this.view_all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.view_all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view_all_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_all_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.view_all_btn.Location = new System.Drawing.Point(31, 230);
            this.view_all_btn.Name = "view_all_btn";
            this.view_all_btn.Size = new System.Drawing.Size(355, 50);
            this.view_all_btn.TabIndex = 29;
            this.view_all_btn.Text = "View all details";
            this.view_all_btn.UseVisualStyleBackColor = false;
            this.view_all_btn.Click += new System.EventHandler(this.view_all_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.Edit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Edit_btn.Location = new System.Drawing.Point(31, 136);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(355, 50);
            this.Edit_btn.TabIndex = 28;
            this.Edit_btn.Text = "Edit details";
            this.Edit_btn.UseVisualStyleBackColor = false;
            // 
            // view_details_btn
            // 
            this.view_details_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(85)))));
            this.view_details_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view_details_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.view_details_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.view_details_btn.Location = new System.Drawing.Point(31, 46);
            this.view_details_btn.Name = "view_details_btn";
            this.view_details_btn.Size = new System.Drawing.Size(355, 50);
            this.view_details_btn.TabIndex = 27;
            this.view_details_btn.Text = "View details";
            this.view_details_btn.UseVisualStyleBackColor = false;
            this.view_details_btn.Click += new System.EventHandler(this.view_details_btn_Click);
            // 
            // output_label
            // 
            this.output_label.AutoSize = true;
            this.output_label.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output_label.Location = new System.Drawing.Point(477, 46);
            this.output_label.Name = "output_label";
            this.output_label.Size = new System.Drawing.Size(0, 18);
            this.output_label.TabIndex = 30;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(157)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.output_label);
            this.Controls.Add(this.view_all_btn);
            this.Controls.Add(this.Edit_btn);
            this.Controls.Add(this.view_details_btn);
            this.Name = "Login";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.Button view_details_btn;
        private System.Windows.Forms.Button view_all_btn;
        private System.Windows.Forms.Label output_label;
    }
}