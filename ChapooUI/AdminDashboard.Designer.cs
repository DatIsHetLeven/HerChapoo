namespace ChapooUI
{
    partial class AdminDashboard
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
            this.btn_all_users = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_show_orders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_all_users
            // 
            this.btn_all_users.Location = new System.Drawing.Point(263, 58);
            this.btn_all_users.Name = "btn_all_users";
            this.btn_all_users.Size = new System.Drawing.Size(212, 65);
            this.btn_all_users.TabIndex = 0;
            this.btn_all_users.Text = "Show all users";
            this.btn_all_users.UseVisualStyleBackColor = true;
            this.btn_all_users.Click += new System.EventHandler(this.btn_all_users_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_LogOut.Location = new System.Drawing.Point(32, 27);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(99, 31);
            this.btn_LogOut.TabIndex = 21;
            this.btn_LogOut.Text = "Log out";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_show_orders
            // 
            this.btn_show_orders.Location = new System.Drawing.Point(263, 149);
            this.btn_show_orders.Name = "btn_show_orders";
            this.btn_show_orders.Size = new System.Drawing.Size(212, 65);
            this.btn_show_orders.TabIndex = 22;
            this.btn_show_orders.Text = "Show Orders";
            this.btn_show_orders.UseVisualStyleBackColor = true;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 385);
            this.Controls.Add(this.btn_show_orders);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_all_users);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_all_users;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_show_orders;
    }
}