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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(560, 476);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 3;
            // 
            // TableChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 628);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}