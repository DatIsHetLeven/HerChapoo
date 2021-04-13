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
        public Menu()
        {
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
    }
}
