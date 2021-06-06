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

using System.Data.SqlClient;
using System.Configuration;

namespace ChapooUI
{
    public partial class AdminAllUsers : Form
    {
        User_Service user_Service = new User_Service();
        List<User> userLists = new List<User>();

        
        public AdminAllUsers()
        {
            InitializeComponent();
        }
        private void AdminAllUsers_Load(object sender, EventArgs e)
        {
            GetAllData();
        }
        //Get all data -> fill in lists
        public void GetAllData()
        {
            //Create object list of userlist
            userLists = user_Service.getAllUsers();
            //Show data of all users
            dataGridView1.DataSource = userLists;
        }
        //Button create user
        private void Btn_CreateUser_Click(object sender, EventArgs e)
        {
            AdminCreateUser adminCreateUser = new AdminCreateUser();
            adminCreateUser.ShowDialog();
        }
        //Button change password
        private void Btn_ChangePassword_Click(object sender, EventArgs e)
        {
            AdminChangePassword adminChangePassword = new AdminChangePassword();
            adminChangePassword.ShowDialog();
        }

        private void btn_BackAdminDasboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.ShowDialog();
            this.Close();
        }
    }
}
