﻿namespace ChapooUI
{
    partial class BestellenDiner
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
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_Lunch = new System.Windows.Forms.DataGridView();
            this.btn_Go_Drinks = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Go_Lunch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.drop_InvoerAantal = new System.Windows.Forms.ComboBox();
            this.datagrid_Making = new System.Windows.Forms.DataGridView();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(12, 12);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(87, 34);
            this.btn_Back_To_Dashboard.TabIndex = 20;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click);
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.Location = new System.Drawing.Point(939, 484);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(170, 54);
            this.btn_bestellen.TabIndex = 19;
            this.btn_bestellen.Text = "Bestellen";
            this.btn_bestellen.UseVisualStyleBackColor = true;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1155, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Aantal:";
            // 
            // datagrid_Lunch
            // 
            this.datagrid_Lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Lunch.Location = new System.Drawing.Point(694, 120);
            this.datagrid_Lunch.Name = "datagrid_Lunch";
            this.datagrid_Lunch.ReadOnly = true;
            this.datagrid_Lunch.Size = new System.Drawing.Size(415, 338);
            this.datagrid_Lunch.TabIndex = 16;
            // 
            // btn_Go_Drinks
            // 
            this.btn_Go_Drinks.Location = new System.Drawing.Point(1060, 28);
            this.btn_Go_Drinks.Name = "btn_Go_Drinks";
            this.btn_Go_Drinks.Size = new System.Drawing.Size(135, 49);
            this.btn_Go_Drinks.TabIndex = 15;
            this.btn_Go_Drinks.Text = "Dranken";
            this.btn_Go_Drinks.UseVisualStyleBackColor = true;
            this.btn_Go_Drinks.Click += new System.EventHandler(this.btn_Go_Drinks_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(882, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 49);
            this.button2.TabIndex = 14;
            this.button2.Text = "Diner";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_Go_Lunch
            // 
            this.btn_Go_Lunch.Location = new System.Drawing.Point(694, 28);
            this.btn_Go_Lunch.Name = "btn_Go_Lunch";
            this.btn_Go_Lunch.Size = new System.Drawing.Size(135, 49);
            this.btn_Go_Lunch.TabIndex = 21;
            this.btn_Go_Lunch.Text = "Lunch";
            this.btn_Go_Lunch.UseVisualStyleBackColor = true;
            this.btn_Go_Lunch.Click += new System.EventHandler(this.btn_Go_Lunch_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(678, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 681);
            this.panel4.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Bestelling";
            // 
            // drop_InvoerAantal
            // 
            this.drop_InvoerAantal.FormattingEnabled = true;
            this.drop_InvoerAantal.Location = new System.Drawing.Point(1152, 136);
            this.drop_InvoerAantal.Name = "drop_InvoerAantal";
            this.drop_InvoerAantal.Size = new System.Drawing.Size(100, 21);
            this.drop_InvoerAantal.TabIndex = 30;
            // 
            // datagrid_Making
            // 
            this.datagrid_Making.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Making.Location = new System.Drawing.Point(31, 120);
            this.datagrid_Making.Name = "datagrid_Making";
            this.datagrid_Making.ReadOnly = true;
            this.datagrid_Making.Size = new System.Drawing.Size(456, 120);
            this.datagrid_Making.TabIndex = 32;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Lime;
            this.Btn_Refresh.Image = global::ChapooUI.Properties.Resources.qw;
            this.Btn_Refresh.Location = new System.Drawing.Point(557, 11);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(82, 66);
            this.Btn_Refresh.TabIndex = 34;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            this.Btn_Refresh.Click += new System.EventHandler(this.Btn_Refresh_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Delete.Location = new System.Drawing.Point(512, 120);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(91, 26);
            this.Btn_Delete.TabIndex = 35;
            this.Btn_Delete.Text = "Verwijderen X";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(415, 35);
            this.button1.TabIndex = 49;
            this.button1.Text = "Bestellen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BestellenDiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.datagrid_Making);
            this.Controls.Add(this.drop_InvoerAantal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Go_Lunch);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_Lunch);
            this.Controls.Add(this.btn_Go_Drinks);
            this.Controls.Add(this.button2);
            this.Name = "BestellenDiner";
            this.Text = "BestellenDiner";
            this.Load += new System.EventHandler(this.BestellenDiner_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_Lunch;
        private System.Windows.Forms.Button btn_Go_Drinks;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Go_Lunch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drop_InvoerAantal;
        private System.Windows.Forms.DataGridView datagrid_Making;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button button1;
    }
}