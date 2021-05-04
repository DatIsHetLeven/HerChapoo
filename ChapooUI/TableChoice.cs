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


namespace ChapooUI
{
    public partial class TableChoice : Form
    {
        Table_Service table_Service = new Table_Service();
        private int TableId;
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
            Menu menuView = new Menu(TableId);
            menuView.ShowDialog();
            this.Close();
        }
        //Reservate Table
        private void btn_Reservate_Click(object sender, EventArgs e)
        {
            //Table reserveren -> if not working show error message
            try
            {
                table_Service.SetTableReservate(TableId);
                MessageBox.Show("Table has been reservated");
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured : Table could not be reservated");
            }
        }
        //Make table Free
        private void Btn_FreeTable_Click(object sender, EventArgs e)
        {
            table_Service.SetTableFree(TableId);
            MessageBox.Show("Table has been cleared");
        }

        private void TableChoice_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Show_Table_Number_Click(object sender, EventArgs e)
        {

        }

        private void btn_Bon_Click(object sender, EventArgs e)
        {

        }
    }
}
