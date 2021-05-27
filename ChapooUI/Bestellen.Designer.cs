namespace ChapooUI
{
    partial class Bestellen
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
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Go_Diner = new System.Windows.Forms.Button();
            this.Btn_Go_Drinks = new System.Windows.Forms.Button();
            this.datagrid_Lunch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_aantal = new System.Windows.Forms.TextBox();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.drop_InvoerAantal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(141, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Lunch";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Btn_Go_Diner
            // 
            this.Btn_Go_Diner.Location = new System.Drawing.Point(329, 31);
            this.Btn_Go_Diner.Name = "Btn_Go_Diner";
            this.Btn_Go_Diner.Size = new System.Drawing.Size(135, 49);
            this.Btn_Go_Diner.TabIndex = 1;
            this.Btn_Go_Diner.Text = "Diner";
            this.Btn_Go_Diner.UseVisualStyleBackColor = true;
            this.Btn_Go_Diner.Click += new System.EventHandler(this.Btn_Go_Diner_Click);
            // 
            // Btn_Go_Drinks
            // 
            this.Btn_Go_Drinks.Location = new System.Drawing.Point(507, 31);
            this.Btn_Go_Drinks.Name = "Btn_Go_Drinks";
            this.Btn_Go_Drinks.Size = new System.Drawing.Size(135, 49);
            this.Btn_Go_Drinks.TabIndex = 2;
            this.Btn_Go_Drinks.Text = "Dranken";
            this.Btn_Go_Drinks.UseVisualStyleBackColor = true;
            this.Btn_Go_Drinks.Click += new System.EventHandler(this.Btn_Go_Drinks_Click);
            // 
            // datagrid_Lunch
            // 
            this.datagrid_Lunch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid_Lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Lunch.Location = new System.Drawing.Point(141, 123);
            this.datagrid_Lunch.Name = "datagrid_Lunch";
            this.datagrid_Lunch.Size = new System.Drawing.Size(415, 338);
            this.datagrid_Lunch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aantal:";
            // 
            // txt_aantal
            // 
            this.txt_aantal.Location = new System.Drawing.Point(605, 139);
            this.txt_aantal.Name = "txt_aantal";
            this.txt_aantal.Size = new System.Drawing.Size(100, 20);
            this.txt_aantal.TabIndex = 4;
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.Location = new System.Drawing.Point(386, 487);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(170, 54);
            this.btn_bestellen.TabIndex = 11;
            this.btn_bestellen.Text = "Bestellen";
            this.btn_bestellen.UseVisualStyleBackColor = true;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(12, 12);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(87, 34);
            this.btn_Back_To_Dashboard.TabIndex = 12;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = true;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // drop_InvoerAantal
            // 
            this.drop_InvoerAantal.FormattingEnabled = true;
            this.drop_InvoerAantal.Location = new System.Drawing.Point(605, 182);
            this.drop_InvoerAantal.Name = "drop_InvoerAantal";
            this.drop_InvoerAantal.Size = new System.Drawing.Size(100, 21);
            this.drop_InvoerAantal.TabIndex = 26;
            // 
            // Bestellen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 549);
            this.Controls.Add(this.drop_InvoerAantal);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_aantal);
            this.Controls.Add(this.datagrid_Lunch);
            this.Controls.Add(this.Btn_Go_Drinks);
            this.Controls.Add(this.Btn_Go_Diner);
            this.Controls.Add(this.button1);
            this.Name = "Bestellen";
            this.Text = "Bestellen";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Go_Diner;
        private System.Windows.Forms.Button Btn_Go_Drinks;
        private System.Windows.Forms.DataGridView datagrid_Lunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_aantal;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.ComboBox drop_InvoerAantal;
    }
}