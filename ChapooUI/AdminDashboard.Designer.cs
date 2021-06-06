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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.btn_all_users = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_all_users
            // 
            this.btn_all_users.Location = new System.Drawing.Point(533, 138);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1007, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_all_users);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_all_users;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}