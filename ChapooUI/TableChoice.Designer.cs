namespace ChapooUI
{
    partial class TableChoice
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
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Bon = new System.Windows.Forms.Button();
            this.btn_Reservate = new System.Windows.Forms.Button();
            this.lbl_Show_Table_Number = new System.Windows.Forms.Label();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(261, 71);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(246, 97);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            // 
            // btn_Bon
            // 
            this.btn_Bon.Location = new System.Drawing.Point(261, 229);
            this.btn_Bon.Name = "btn_Bon";
            this.btn_Bon.Size = new System.Drawing.Size(246, 97);
            this.btn_Bon.TabIndex = 1;
            this.btn_Bon.Text = "Receipt";
            this.btn_Bon.UseVisualStyleBackColor = true;
            // 
            // btn_Reservate
            // 
            this.btn_Reservate.Location = new System.Drawing.Point(261, 388);
            this.btn_Reservate.Name = "btn_Reservate";
            this.btn_Reservate.Size = new System.Drawing.Size(246, 97);
            this.btn_Reservate.TabIndex = 2;
            this.btn_Reservate.Text = "Reservate";
            this.btn_Reservate.UseVisualStyleBackColor = true;
            // 
            // lbl_Show_Table_Number
            // 
            this.lbl_Show_Table_Number.AutoSize = true;
            this.lbl_Show_Table_Number.Location = new System.Drawing.Point(258, 22);
            this.lbl_Show_Table_Number.Name = "lbl_Show_Table_Number";
            this.lbl_Show_Table_Number.Size = new System.Drawing.Size(35, 13);
            this.lbl_Show_Table_Number.TabIndex = 4;
            this.lbl_Show_Table_Number.Text = "label1";
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(30, 27);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(146, 44);
            this.btn_Back_To_Dashboard.TabIndex = 5;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // TableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 628);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.lbl_Show_Table_Number);
            this.Controls.Add(this.btn_Reservate);
            this.Controls.Add(this.btn_Bon);
            this.Controls.Add(this.btn_Menu);
            this.Name = "TableChoice";
            this.Text = "TableChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Bon;
        private System.Windows.Forms.Button btn_Reservate;
        private System.Windows.Forms.Label lbl_Show_Table_Number;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
    }
}