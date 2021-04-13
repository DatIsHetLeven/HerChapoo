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

        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Close();
        }
    }
}
