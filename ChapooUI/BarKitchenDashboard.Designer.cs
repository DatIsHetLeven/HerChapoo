namespace ChapooUI
{
    partial class BarKitchenDashboard
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
            this.datgrid_OpenOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_UpdateStatus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_OpenOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // datgrid_OpenOrder
            // 
            this.datgrid_OpenOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datgrid_OpenOrder.Location = new System.Drawing.Point(12, 84);
            this.datgrid_OpenOrder.Name = "datgrid_OpenOrder";
            this.datgrid_OpenOrder.Size = new System.Drawing.Size(231, 238);
            this.datgrid_OpenOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // btn_UpdateStatus
            // 
            this.btn_UpdateStatus.Location = new System.Drawing.Point(12, 358);
            this.btn_UpdateStatus.Name = "btn_UpdateStatus";
            this.btn_UpdateStatus.Size = new System.Drawing.Size(127, 33);
            this.btn_UpdateStatus.TabIndex = 2;
            this.btn_UpdateStatus.Text = "Ready";
            this.btn_UpdateStatus.UseVisualStyleBackColor = true;
            this.btn_UpdateStatus.Click += new System.EventHandler(this.btn_UpdateStatus_Click);
            // 
            // BarKitchenDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 463);
            this.Controls.Add(this.btn_UpdateStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datgrid_OpenOrder);
            this.Name = "BarKitchenDashboard";
            this.Text = "BarKitchenDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.datgrid_OpenOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datgrid_OpenOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_UpdateStatus;
    }
}