namespace ChapooUI
{
    partial class OrderDashboard
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
            this.datagrid_CurrentOrder = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CurrentOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_CurrentOrder
            // 
            this.datagrid_CurrentOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_CurrentOrder.Location = new System.Drawing.Point(200, 65);
            this.datagrid_CurrentOrder.Name = "datagrid_CurrentOrder";
            this.datagrid_CurrentOrder.Size = new System.Drawing.Size(381, 280);
            this.datagrid_CurrentOrder.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 27);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(118, 40);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // OrderDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.datagrid_CurrentOrder);
            this.Name = "OrderDashboard";
            this.Text = "OrderDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_CurrentOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_CurrentOrder;
        private System.Windows.Forms.Button btn_back;
    }
}