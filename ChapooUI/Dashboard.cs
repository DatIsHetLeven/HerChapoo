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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_Tafel_1_Click(object sender, EventArgs e)
        {
            goToTableChoiche(1);
        }

        private void btn_Tafel_2_Click(object sender, EventArgs e)
        {
            goToTableChoiche(2);
        }

        private void goToTableChoiche(int tableId)
        {
            string tableNumber = tableId.ToString();
            this.Hide();
            TableChoice tableChoice = new TableChoice();
            tableChoice.ShowDialog(tableId);
            
            this.Close();
        }
    }
}
