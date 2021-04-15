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

namespace ChapooUI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        //Button to login
        private void btn_Inloggen_Click(object sender, EventArgs e)
        {
            if (txt_LoginUsername.Text != "" && txt_LoginPassword.Text != "")
            {
                this.Hide();
                Dashboard dashboardView = new Dashboard();
                dashboardView.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Error occured : Username or Password is empty!");
            }


        }
    }
}
