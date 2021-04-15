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
    public partial class Dashboard : Form
    {



        
        public Dashboard()
        {
            InitializeComponent();
            Table_Service table_Service = new Table_Service();
            DataTable dataTable = new DataTable();
            List<Button> TableButtonList = new List<Button>();
            TableButtonList.Add(btn_Tafel_1);
            TableButtonList.Add(btn_Tafel_2);

            int tableCount = 1;
            foreach (Button item in TableButtonList)
            {
                dataTable = table_Service.GetTableStatus(tableCount, 2);

                if (dataTable.Rows.Count == 1)
                {
                    item.BackColor = Color.Red;
                }
                else
                {
                    item.BackColor = Color.Lime;
                }
                tableCount++;
            }

        }
        //Table 1
        private void btn_Tafel_1_Click(object sender, EventArgs e)
        {
            goToTableChoiche(1);
        }
        //Table 2
        private void btn_Tafel_2_Click(object sender, EventArgs e)
        {
            goToTableChoiche(2);
        }
        //Go to TableChoice.cs, method for table buttons
        private void goToTableChoiche(int tableId)
        {
            this.Hide();
            TableChoice tableChoice = new TableChoice(tableId);
            tableChoice.ShowDialog();
            this.Close();
        }        
    }
}
