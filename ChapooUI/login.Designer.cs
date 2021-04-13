namespace ChapooUI
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbl_gebruikersnaam = new System.Windows.Forms.Label();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.btn_Inloggen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(181, 313);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lbl_gebruikersnaam
            // 
            this.lbl_gebruikersnaam.AutoSize = true;
            this.lbl_gebruikersnaam.Location = new System.Drawing.Point(178, 230);
            this.lbl_gebruikersnaam.Name = "lbl_gebruikersnaam";
            this.lbl_gebruikersnaam.Size = new System.Drawing.Size(84, 13);
            this.lbl_gebruikersnaam.TabIndex = 10;
            this.lbl_gebruikersnaam.Text = "Gebruikersnaam";
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Location = new System.Drawing.Point(178, 297);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lbl_wachtwoord.TabIndex = 11;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // btn_Inloggen
            // 
            this.btn_Inloggen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Inloggen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Inloggen.Location = new System.Drawing.Point(211, 381);
            this.btn_Inloggen.Name = "btn_Inloggen";
            this.btn_Inloggen.Size = new System.Drawing.Size(182, 63);
            this.btn_Inloggen.TabIndex = 12;
            this.btn_Inloggen.Text = "Inloggen";
            this.btn_Inloggen.UseVisualStyleBackColor = false;
            this.btn_Inloggen.Click += new System.EventHandler(this.btn_Inloggen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Inloggen);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.lbl_gebruikersnaam);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbl_gebruikersnaam;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Button btn_Inloggen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

