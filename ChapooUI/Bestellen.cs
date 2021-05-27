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
    public partial class Bestellen : Form
    {
        
        int TableId;
        Table_Service table_Service = new Table_Service();
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        public Bestellen(int tableid)
        {
            this.TableId = tableid;
            MenuItem_Service menuItem_Service = new MenuItem_Service();

            InitializeComponent();
            List<int> invoerAantal = new List<int>();
            invoerAantal.Add(1);
            invoerAantal.Add(2);
            invoerAantal.Add(3);
            invoerAantal.Add(4);
            invoerAantal.Add(5);
            invoerAantal.Add(6);
            invoerAantal.Add(7);
            invoerAantal.Add(8);
            invoerAantal.Add(9);
            invoerAantal.Add(10);

            drop_InvoerAantal.DataSource = invoerAantal;
            List<ChapooModel.MenuItem> menuItemList = new List<ChapooModel.MenuItem>();
            menuItemList = menuItem_Service.GetMenuItems();
            datagrid_Lunch.DataSource = menuItemList;
        }

        private void btn_Back_To_Dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboardView = new Dashboard();
            dashboardView.ShowDialog();
            this.Close();
        }

        private void btn_bestellen_Click(object sender, EventArgs e)
        {


            int item = datagrid_Lunch.CurrentCell.RowIndex;
            string prijs = datagrid_Lunch.Rows[item].Cells[0].FormattedValue.ToString();
            string aantal = txt_aantal.Text.ToString();
            int aantalInvoer = int.Parse(aantal);
            int prijs1 = int.Parse(prijs);

            if (aantal != "" && aantalInvoer > 0)
            {
                int prijs2 = int.Parse(aantal);
                int verm = prijs1 * prijs2;
                MessageBox.Show("Gerecht : " + datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString() + ", Aantal " + txt_aantal.Text.ToString() + " , Prijs : " + verm.ToString());
                selectedItems_Service.selectedItem(TableId, datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString(), verm);
                table_Service.SetTableInUse(TableId);
            }
            else
                MessageBox.Show("Please put in valid number");
            txt_aantal.Clear();
        }

        private void Btn_Go_Diner_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDiner bestellenDiner = new BestellenDiner(TableId);
            bestellenDiner.ShowDialog();
            this.Close();
        }

        private void Btn_Go_Drinks_Click(object sender, EventArgs e)
        {
            this.Hide();
            BestellenDranken bestellenDiner = new BestellenDranken(TableId);
            bestellenDiner.ShowDialog();
            this.Close();
        }
    }
}
