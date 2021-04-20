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

using System.Data.SqlClient;
using System.Configuration;

namespace ChapooUI
{
    public partial class AdminAllUsers : Form
    {
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
            List<string> drop = new List<string>();
            drop.Add("test");
            drop.Add("test2");
            drop.Add("test3");

            char[,] arrayUserRol = new char[10,10];
            //Dropdown useriD
            DataTable dtt = new DataTable();

            SqlConnection con = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=chapoo1920f05;user=chapoo1920f05;password=Xm8ws!25HZ4~;");
            con.Open();
            SqlCommand cmd = new SqlCommand("select userId from[user]", con);
            SqlDataAdapter sdaa = new SqlDataAdapter(cmd);
            sdaa.Fill(dtt);
            foreach (var i in drop)
            {
                //comboBox1.Items.Add(i);
                drop_UserId.ValueMember = "userId";
                drop_UserId.DataSource = dtt;
            }
            con.Close();

            //Dropdown userRol -> create user
            //DataTable dttt = new DataTable();

            //SqlConnection connn = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=chapoo1920f05;user=chapoo1920f05;password=Xm8ws!25HZ4~;");
            //connn.Open();
            //SqlCommand cmdd = new SqlCommand("select rol_id,Title from[UserRol]", con);
            //SqlDataAdapter sdaaa = new SqlDataAdapter(cmdd);
            //sdaaa.Fill(dttt);
            //foreach (var i in drop)
            //{
            //    drop_UserRol.ValueMember = "Title";
            //    drop_UserRol.DataSource = dttt;
            //}
            //con.Close();

            drop_UserRol.ValueMember = "Title";
            //drop_UserRol.DataSource = user_Service.UserId();

            DataTable dt = new DataTable();

            SqlConnection conn = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=chapoo1920f05;user=chapoo1920f05;password=Xm8ws!25HZ4~;");
            conn.Open();
            SqlCommand cmsd = new SqlCommand("select userId, userName as Name, title, userKey as PrivateKey from[user], [UserRol] where userCode = Rol_Id", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmsd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

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
                if (rol == "Baman")
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
