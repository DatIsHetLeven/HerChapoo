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
    public partial class OrderDashboard : Form
    {
        private int TableId;
        private int TotalPrice;
        Order_Service order_Service = new Order_Service();

        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        public OrderDashboard(int tableId)
        {
            InitializeComponent();
            this.TableId = tableId;
            int totalAmount = 0;
            

            List<SelectedItem> selectedItems = new List<SelectedItem>();
            selectedItems = selectedItems_Service.GetCurrentItems(tableId);
            datagrid_CurrentOrder.DataSource = selectedItems;

            
            for (int i = 0; i < datagrid_CurrentOrder.Rows.Count; i++)
            {
                totalAmount += Convert.ToInt32(datagrid_CurrentOrder.Rows[i].Cells[2].Value);
            }
            this.TotalPrice = totalAmount;

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard menuView = new Dashboard();
            menuView.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //List of all items
            List<SelectedItem> selectedItems = new List<SelectedItem>();
            selectedItems = selectedItems_Service.GetCurrentItems(TableId);
            //Max id value
            List<int> listMaxId = order_Service.GetMaxId();
            int number = listMaxId[0];
            int newOrderId = (number + 1);

            //Insert to db
            foreach (var item in selectedItems)
            {
                int ii = 0;
                foreach (DataGridViewRow i in datagrid_CurrentOrder.Rows)
                {
                    string menuitem = datagrid_CurrentOrder.Rows[ii].Cells["menuItem"].FormattedValue.ToString();
                    string prijs = datagrid_CurrentOrder.Rows[ii].Cells["prijs"].FormattedValue.ToString();
                    int prijsToPay = int.Parse(prijs);
                    order_Service.createOrder(newOrderId, TableId, menuitem, prijsToPay);

                    ii++;
                }
                break;
            }

            selectedItems_Service.removeItems(TableId);
            this.Hide();
            Payment payment = new Payment(TotalPrice, TableId);
            payment.ShowDialog();
            this.Close();
        }
    }
}
