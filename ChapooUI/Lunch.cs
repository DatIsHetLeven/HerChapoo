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
    public partial class Lunch : Form
    {
        int TableId;
        Table_Service table_Service = new Table_Service();
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        public Lunch(int tableid)
        {
            this.TableId = tableid;
            MenuItem_Service menuItem_Service = new MenuItem_Service();

            InitializeComponent();
            List<ChapooModel.MenuItem> menuItemList = new List<ChapooModel.MenuItem>();
            menuItemList = menuItem_Service.GetMenuItems();
            datagrid_Lunch.DataSource = menuItemList;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menuView = new ChapooUI.Menu();
            menuView.ShowDialog();
            this.Close();
        }

        private void btn_bestellen_Click(object sender, EventArgs e)
        {
            int item = datagrid_Lunch.CurrentCell.RowIndex;
            string prijs = datagrid_Lunch.Rows[item].Cells[0].FormattedValue.ToString();
            string aantal = txt_aantal.Text.ToString();
            int prijs1 = int.Parse(prijs);

            if (aantal != "" && aantal != "0")
            {
                int prijs2 = int.Parse(aantal);
                int verm = prijs1 * prijs2;
                MessageBox.Show("Gerecht : " + datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString() + ", Aantal " + txt_aantal.Text.ToString() + " , Prijs : " + verm.ToString());
                selectedItems_Service.selectedItem(TableId, datagrid_Lunch.Rows[item].Cells["menuItemNaam"].FormattedValue.ToString(), verm);
                table_Service.ChangeTableStatus(TableId,3);
            }
            else
                MessageBox.Show("Please put in valid number");
            txt_aantal.Clear();
        }
    }
}
