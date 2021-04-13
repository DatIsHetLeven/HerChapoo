namespace ChapooUI
{
    partial class Menu
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
            this.btn_Lunch = new System.Windows.Forms.Button();
            this.btn_Diner = new System.Windows.Forms.Button();
            this.btn_Drank = new System.Windows.Forms.Button();
            this.Btn_Order_Overview = new System.Windows.Forms.Button();
            this.btn_Back_To_TableChoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Lunch
            // 
            this.btn_Lunch.Location = new System.Drawing.Point(254, 66);
            this.btn_Lunch.Name = "btn_Lunch";
            this.btn_Lunch.Size = new System.Drawing.Size(181, 64);
            this.btn_Lunch.TabIndex = 0;
            this.btn_Lunch.Text = "Lunch";
            this.btn_Lunch.UseVisualStyleBackColor = true;
            // 
            // btn_Diner
            // 
            this.btn_Diner.Location = new System.Drawing.Point(254, 163);
            this.btn_Diner.Name = "btn_Diner";
            this.btn_Diner.Size = new System.Drawing.Size(181, 64);
            this.btn_Diner.TabIndex = 1;
            this.btn_Diner.Text = "Diner";
            this.btn_Diner.UseVisualStyleBackColor = true;
            // 
            // btn_Drank
            // 
            this.btn_Drank.Location = new System.Drawing.Point(254, 256);
            this.btn_Drank.Name = "btn_Drank";
            this.btn_Drank.Size = new System.Drawing.Size(181, 64);
            this.btn_Drank.TabIndex = 2;
            this.btn_Drank.Text = "Drank";
            this.btn_Drank.UseVisualStyleBackColor = true;
            // 
            // Btn_Order_Overview
            // 
            this.Btn_Order_Overview.Location = new System.Drawing.Point(254, 350);
            this.Btn_Order_Overview.Name = "Btn_Order_Overview";
            this.Btn_Order_Overview.Size = new System.Drawing.Size(181, 64);
            this.Btn_Order_Overview.TabIndex = 3;
            this.Btn_Order_Overview.Text = "Bestelling Overzicht";
            this.Btn_Order_Overview.UseVisualStyleBackColor = true;
            // 
            // btn_Back_To_TableChoice
            // 
            this.btn_Back_To_TableChoice.Location = new System.Drawing.Point(38, 34);
            this.btn_Back_To_TableChoice.Name = "btn_Back_To_TableChoice";
            this.btn_Back_To_TableChoice.Size = new System.Drawing.Size(146, 44);
            this.btn_Back_To_TableChoice.TabIndex = 6;
            this.btn_Back_To_TableChoice.Text = "Back";
            this.btn_Back_To_TableChoice.UseVisualStyleBackColor = true;
            this.btn_Back_To_TableChoice.Click += new System.EventHandler(this.btn_Back_To_TableChoice_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 562);
            this.Controls.Add(this.btn_Back_To_TableChoice);
            this.Controls.Add(this.Btn_Order_Overview);
            this.Controls.Add(this.btn_Drank);
            this.Controls.Add(this.btn_Diner);
            this.Controls.Add(this.btn_Lunch);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Lunch;
        private System.Windows.Forms.Button btn_Diner;
        private System.Windows.Forms.Button btn_Drank;
        private System.Windows.Forms.Button Btn_Order_Overview;
        private System.Windows.Forms.Button btn_Back_To_TableChoice;
    }
}