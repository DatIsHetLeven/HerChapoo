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


namespace ChapooUI
{
    public partial class TableChoice : Form
    {
        public int TableId;
        public TableChoice()
        {
            InitializeComponent();
        }
        //Constructor -> Tablenumbers from the button
        public TableChoice(int tableId)
        {
            InitializeComponent();
            this.TableId = tableId;
            lbl_Show_Table_Number.Text = ("Tablenumber : "+ TableId.ToString());
        }
        //Go back to Dashboard.cs
        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardView = new Dashboard();
            dashboardView.ShowDialog();
            this.Close();
        }
        //Go to Menus.cs
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuView = new Menu();
            menuView.ShowDialog();
            this.Close();
        }
        //Reservate Table
        private void btn_Reservate_Click(object sender, EventArgs e)
        {
            Table_Service table_Service = new Table_Service();
            table_Service.SetTableReservate(1);
           
        }
    }
}
