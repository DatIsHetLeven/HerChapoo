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

        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        public OrderDashboard(int tableId)
        {
            InitializeComponent();
            this.TableId = tableId;

            List<SelectedItem> selectedItems = new List<SelectedItem>();
            selectedItems = selectedItems_Service.GetCurrentItems(tableId);
            datagrid_CurrentOrder.DataSource = selectedItems;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard menuView = new Dashboard();
            menuView.ShowDialog();
            this.Close();
        }
    }
}
