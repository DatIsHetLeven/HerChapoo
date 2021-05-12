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
        ListViewItem ListViewItem;
        User_Service user_Service = new User_Service();
        public AdminAllUsers()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            //List for user -> referesh
        }

        private void AdminAllUsers_Load(object sender, EventArgs e)
        {
            //Create object list of userlist
            List<UserList> userLists = new List<UserList>();
            userLists = user_Service.GetAllUserList();
            //List of items you want
            List<string> userTitle = new List<string>();
            List<int> userID = new List<int>();
            //Adding specifiek data form object to list
            foreach (var item in userLists)
            {
                userTitle.Add(item.title);
                userID.Add(item.userId);
            }
            drop_UserRol.DataSource = userTitle;
            drop_UserId.DataSource = userID;
            dataGridView1.DataSource = userLists;
        }

        //Button create user 
        private void btn_CreateNewUser_Click(object sender, EventArgs e)
        {
            string userName = txt_NewUserName.Text;
            string password = txt_UserPassword.Text;
            string rol = drop_UserRol.Text;
            int userRol = 1;

            if (userName !="" && password !="")
            {
                if (rol == "Barman")
                {
                    userRol = 2;
                }
                else if (rol == "Admin")
                {
                    userRol = 3;
                }
                user_Service.createUser(userName, password, userRol);
                MessageBox.Show("User has been created");
                txt_NewUserName.Clear();
                txt_UserPassword.Clear();
            }
            else
            {
                MessageBox.Show("please fill all the fields in.");
            }
        }
        //Button Go back to AdminDashboard
        private void btn_BackAdminDasboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            this.Hide();
            adminDashboard.ShowDialog();
            this.Close();
        }
        //Create Private key -> to reset password
        private void btn_AddPrivateKey_Click(object sender, EventArgs e)
        {
            int userId = (drop_UserId.SelectedIndex +1);
            string privateKey = txt_PrivateKey.Text;
            user_Service.createPrivateKey(privateKey, userId);
        }

    }
}
