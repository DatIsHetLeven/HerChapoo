﻿namespace ChapooUI
{
    partial class BestellenDranken
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
            this.btn_Go_Lunch = new System.Windows.Forms.Button();
            this.btn_bestellen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrid_Lunch = new System.Windows.Forms.DataGridView();
            this.btn_Go_Drinks = new System.Windows.Forms.Button();
            this.Btn_GoDiner = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Refresh = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.datagrid_Making = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back_To_Dashboard = new System.Windows.Forms.Button();
            this.drop_InvoerAantal = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Go_Lunch
            // 
            this.btn_Go_Lunch.Location = new System.Drawing.Point(694, 38);
            this.btn_Go_Lunch.Name = "btn_Go_Lunch";
            this.btn_Go_Lunch.Size = new System.Drawing.Size(135, 49);
            this.btn_Go_Lunch.TabIndex = 29;
            this.btn_Go_Lunch.Text = "Lunch";
            this.btn_Go_Lunch.UseVisualStyleBackColor = true;
            this.btn_Go_Lunch.Click += new System.EventHandler(this.btn_Go_Lunch_Click);
            // 
            // btn_bestellen
            // 
            this.btn_bestellen.Location = new System.Drawing.Point(939, 494);
            this.btn_bestellen.Name = "btn_bestellen";
            this.btn_bestellen.Size = new System.Drawing.Size(170, 54);
            this.btn_bestellen.TabIndex = 27;
            this.btn_bestellen.Text = "Bestellen";
            this.btn_bestellen.UseVisualStyleBackColor = true;
            this.btn_bestellen.Click += new System.EventHandler(this.btn_bestellen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1155, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Aantal:";
            // 
            // datagrid_Lunch
            // 
            this.datagrid_Lunch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Lunch.Location = new System.Drawing.Point(694, 130);
            this.datagrid_Lunch.Name = "datagrid_Lunch";
            this.datagrid_Lunch.ReadOnly = true;
            this.datagrid_Lunch.Size = new System.Drawing.Size(415, 338);
            this.datagrid_Lunch.TabIndex = 24;
            // 
            // btn_Go_Drinks
            // 
            this.btn_Go_Drinks.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Go_Drinks.Location = new System.Drawing.Point(1060, 38);
            this.btn_Go_Drinks.Name = "btn_Go_Drinks";
            this.btn_Go_Drinks.Size = new System.Drawing.Size(135, 49);
            this.btn_Go_Drinks.TabIndex = 23;
            this.btn_Go_Drinks.Text = "Dranken";
            this.btn_Go_Drinks.UseVisualStyleBackColor = false;
            // 
            // Btn_GoDiner
            // 
            this.Btn_GoDiner.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_GoDiner.Location = new System.Drawing.Point(882, 38);
            this.Btn_GoDiner.Name = "Btn_GoDiner";
            this.Btn_GoDiner.Size = new System.Drawing.Size(135, 49);
            this.Btn_GoDiner.TabIndex = 22;
            this.Btn_GoDiner.Text = "Diner";
            this.Btn_GoDiner.UseVisualStyleBackColor = false;
            this.Btn_GoDiner.Click += new System.EventHandler(this.Btn_GoDiner_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Location = new System.Drawing.Point(678, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 681);
            this.panel4.TabIndex = 30;
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.BackColor = System.Drawing.Color.Lime;
            this.Btn_Refresh.Image = global::ChapooUI.Properties.Resources.qw;
            this.Btn_Refresh.Location = new System.Drawing.Point(581, 25);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(82, 66);
            this.Btn_Refresh.TabIndex = 38;
            this.Btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Red;
            this.Btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn_Delete.Location = new System.Drawing.Point(546, 134);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(91, 26);
            this.Btn_Delete.TabIndex = 37;
            this.Btn_Delete.Text = "Verwijderen X";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click_1);
            // 
            // datagrid_Making
            // 
            this.datagrid_Making.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Making.Location = new System.Drawing.Point(71, 134);
            this.datagrid_Making.Name = "datagrid_Making";
            this.datagrid_Making.ReadOnly = true;
            this.datagrid_Making.Size = new System.Drawing.Size(456, 120);
            this.datagrid_Making.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Bestelling";
            // 
            // btn_Back_To_Dashboard
            // 
            this.btn_Back_To_Dashboard.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Back_To_Dashboard.Location = new System.Drawing.Point(51, 25);
            this.btn_Back_To_Dashboard.Name = "btn_Back_To_Dashboard";
            this.btn_Back_To_Dashboard.Size = new System.Drawing.Size(87, 34);
            this.btn_Back_To_Dashboard.TabIndex = 34;
            this.btn_Back_To_Dashboard.Text = "Back";
            this.btn_Back_To_Dashboard.UseVisualStyleBackColor = false;
            this.btn_Back_To_Dashboard.Click += new System.EventHandler(this.btn_Back_To_Dashboard_Click_1);
            // 
            // drop_InvoerAantal
            // 
            this.drop_InvoerAantal.FormattingEnabled = true;
            this.drop_InvoerAantal.Location = new System.Drawing.Point(1152, 146);
            this.drop_InvoerAantal.Name = "drop_InvoerAantal";
            this.drop_InvoerAantal.Size = new System.Drawing.Size(100, 21);
            this.drop_InvoerAantal.TabIndex = 39;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 513);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(415, 35);
            this.button2.TabIndex = 49;
            this.button2.Text = "Bestellen";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BestellenDranken
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.drop_InvoerAantal);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.datagrid_Making);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Back_To_Dashboard);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_Go_Lunch);
            this.Controls.Add(this.btn_bestellen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datagrid_Lunch);
            this.Controls.Add(this.btn_Go_Drinks);
            this.Controls.Add(this.Btn_GoDiner);
            this.Name = "BestellenDranken";
            this.Text = "BestellenDranken";
            this.Load += new System.EventHandler(this.BestellenDranken_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Lunch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Making)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Go_Lunch;
        private System.Windows.Forms.Button btn_bestellen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datagrid_Lunch;
        private System.Windows.Forms.Button btn_Go_Drinks;
        private System.Windows.Forms.Button Btn_GoDiner;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Btn_Refresh;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView datagrid_Making;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back_To_Dashboard;
        private System.Windows.Forms.ComboBox drop_InvoerAantal;
        private System.Windows.Forms.Button button2;
    }
}