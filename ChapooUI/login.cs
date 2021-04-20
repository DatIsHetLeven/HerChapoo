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
    public partial class login : Form
    {
        User_Service user_Service = new User_Service();
        public login()
        {
            InitializeComponent();
        }

        //Button to login
        private void btn_Inloggen_Click(object sender, EventArgs e)
        {

            AdminDashboard adminDashboard = new AdminDashboard();

            //Check if username and password are not empty.
            if (txt_LoginUsername.Text != "" && txt_LoginPassword.Text != "")
            {
                string userName = txt_LoginUsername.Text;
                string password = txt_LoginPassword.Text;
                User user = user_Service.GetUser(userName, password);
                //If user exist
                if (user.userName != "")
                {
                    //If user is Admin
                    if (user.userCode == 3)
                    {
                        this.Hide();
                        adminDashboard.ShowDialog();
                        this.Close();
                    }
                    //If user is not an Admin
                    else
                    {
                        this.Hide();
                        Dashboard dashboardView = new Dashboard();
                        dashboardView.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("error occured : User does not exist");
                }
            }
            //If at least on field is empty -> show error.
            else
            {
                MessageBox.Show("Error occured : Username and/ or Password is empty!");
            }
            //Clear both fields after not succeeded.
            txt_LoginPassword.Clear();
            txt_LoginUsername.Clear();

        }
    }
}
