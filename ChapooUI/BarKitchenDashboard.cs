﻿using System;
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
    public partial class BarKitchenDashboard : Form
    {
        SelectedItems_Service selectedItems_Service = new SelectedItems_Service();
        public BarKitchenDashboard()
        {
            InitializeComponent();
           

            List<SelectedItem> selectedItems = new List<SelectedItem>();
            selectedItems = selectedItems_Service.GetSelectedItems();
            datgrid_OpenOrder.DataSource = selectedItems;
        }

        private void btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            int item = datgrid_OpenOrder.CurrentCell.RowIndex;

            string menuitem = datgrid_OpenOrder.Rows[item].Cells["menuItem"].FormattedValue.ToString();
            string tableId = datgrid_OpenOrder.Rows[item].Cells["tableid"].FormattedValue.ToString();
            selectedItems_Service.updateStatus(menuitem, int.Parse(tableId));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
            this.Close();
        }
    }
}
