using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapooModel;


namespace ChapooUI
{
    public partial class Payment : Form
    {
        private int TotalAmount;
        private int TableId;
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        Dashboard dashboard;
        Table_Service table_Service = new Table_Service();


        public Payment(int totalAmount,int tableId)
        {
            this.TotalAmount = totalAmount;
            this.TableId = tableId;
            InitializeComponent();

            txt_Amount.Text = TotalAmount.ToString();

            string tip = txt_TipAmount.Text.ToString();
            string totalToPay = totalAmount.ToString() + tip;
            txt_TotalAmount.Text = totalToPay.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }

        private void btn_PayIdeal_Click(object sender, EventArgs e)
        {
            table_Service.SetTableFree(TableId);
            FinishPayment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table_Service.SetTableFree(TableId);
            FinishPayment();
        }
        private void FinishPayment()
        {
            //table_Service.SetTableFree(TableId);

            MessageBox.Show("Payment was successfully!");
            this.Hide();
            dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
