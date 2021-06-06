using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooLogic;
using ChapooModel;

namespace ChapooUI
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btn_all_users_Click(object sender, EventArgs e)
        {
            AdminAllUsers adminAllUsers = new AdminAllUsers();
            this.Hide();
            adminAllUsers.ShowDialog();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
