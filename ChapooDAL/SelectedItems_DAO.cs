using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapooModel;

namespace ChapooDAL
{
    public class SelectedItems_DAO : Base
    {
        //Insert
        public void InsertNewSelectedItem(int tableid, string item, int prijs)
        {
            string query = $"Insert into[selecteditems] (tableId, menuItem, Prijs, status) Values('{tableid}', '{item}', '{prijs}', 1)";
            ExecuteEditQuery(query);
        }
        //Select for bar& kitchen
        public List<SelectedItem> GetSelectedItems()
        {
            string query = "select tableId, menuItem, Prijs, status from [SelectedItems] where status = 1";
            return GetItems(ExecuteSelectQuery(query));
        }
        //Select order
        public List<SelectedItem> GetSelectedOrder(int tableid)
        {
            string query = $"select tableId, menuItem, Prijs, status from [SelectedItems] where tableId = '{tableid}'";
            return GetItems(ExecuteSelectQuery(query));
        }
        //Return
        private List<SelectedItem> GetItems(DataTable dataTable)
        {
            int tableId = 0;
            string menuItem = "";
            int Prijs = 0;
            int status = 0;

            List<SelectedItem> selectedItems = new List<SelectedItem>();

            foreach (DataRow item in dataTable.Rows)
            {
                SelectedItem selectedItem = new SelectedItem(tableId, menuItem, Prijs, status);
                {
                    tableId = (int)item["tableId"];
                    menuItem = (string)item["menuItem"].ToString();
                    Prijs = (int)item["Prijs"];
                    status = (int)item["status"];
                }
                if (selectedItem.tableid != 0)
                {
                    selectedItems.Add(selectedItem);
                }
                
            }
            return selectedItems;
        }
        //Update
        public void UpdateStatus(string menuItem, int tableId)
        {
            string query = $"update SelectedItems set status = 2 where MenuItem = '{menuItem}' and tableId = '{tableId}'";
            ExecuteEditQuery(query);
        }

    }
}
