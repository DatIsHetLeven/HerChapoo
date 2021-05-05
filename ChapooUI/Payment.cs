using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapooUI
{
    public partial class Payment : Form
    {
        private int TotalAmount;
        Dashboard dashboard = new Dashboard();
        public Payment(int totalAmount)
        {
            this.TotalAmount = totalAmount;
            InitializeComponent();

            txt_Amount.Text = TotalAmount.ToString();

            string tip = txt_TipAmount.Text.ToString();
            string totalToPay = totalAmount.ToString() + tip;
            txt_TotalAmount.Text = totalToPay.ToString();
            calculate();
        }
        private void calculate()
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void btn_PayIdeal_Click(object sender, EventArgs e)
        {
            FinishPayment();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinishPayment();
        }
        private void FinishPayment()
        {
            MessageBox.Show("Payment was successfully!");
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
