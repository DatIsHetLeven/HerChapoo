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
    public partial class Menu : Form
    {
        int TableId;
        public Menu()
        {
            InitializeComponent();
        }
        public Menu(int tableId)
        {
            this.TableId = tableId;
            InitializeComponent();
        }
        //Back to TableChoice
        private void btn_Back_To_TableChoice_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardView = new Dashboard();
            dashboardView.ShowDialog();
            this.Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lunch lunchView = new Lunch(TableId);
            lunchView.ShowDialog();
            this.Close();
        }

        private void Btn_Order_Overview_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderDashboard orderDashboard = new OrderDashboard(TableId);
            orderDashboard.ShowDialog();
            this.Close();
        }
    }
}
