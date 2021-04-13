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
        //Table 1
        private void btn_Tafel_1_Click(object sender, EventArgs e)
        {
            goToTableChoiche(1);
        }
        //Table 2
        private void btn_Tafel_2_Click(object sender, EventArgs e)
        {
            goToTableChoiche(2);
        }
        //Go to TableChoice.cs, method for table buttons
        private void goToTableChoiche(int tableId)
        {
            this.Hide();
            TableChoice tableChoice = new TableChoice(tableId);
            tableChoice.ShowDialog();
            this.Close();
        }
    }
}
