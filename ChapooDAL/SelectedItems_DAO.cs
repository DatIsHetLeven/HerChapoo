﻿using System;
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

        //Insert
        public void InsertNewSelectedItemToKitchen(int tableid, string item, int prijs)
        {
            string query = $"Insert into[selecteditems] (tableId, menuItem, Prijs, status) Values('{tableid}', '{item}', '{prijs}', 5)";
            ExecuteEditQuery(query);
        }
        //Select for bar& kitchen
        public List<SelectedItem> GetSelectedItems()
        {
            string query = "select tableId, menuItem, Prijs, status from [SelectedItems] where status = 2";
            return GetItems(ExecuteSelectQuery(query));
        }
        //Select order
        public List<SelectedItem> GetSelectedOrder(int tableid)
        {
            string query = $"select tableId, menuItem, Prijs, status from [SelectedItems] where tableId = '{tableid}' and status =3";
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

                tableId = (int)item["tableId"];
                menuItem = (string)item["menuItem"].ToString();
                Prijs = (int)item["Prijs"];
                status = (int)item["status"];
                SelectedItem selectedItem = new SelectedItem(tableId, menuItem, Prijs, status);
                {
                    selectedItems.Add(selectedItem);
                }
            }
            return selectedItems;
        }
        //Update
        public void UpdateStatus(string menuItem, int tableId, int status)
        {
            string query = $"update SelectedItems set status = '{status}' where MenuItem = '{menuItem}' and tableId = '{tableId}'";
            ExecuteEditQuery(query);
        }
        //delete
        public void ClearItems(int tableid)
        {
            string query = $"delete from [SelectedItems] where tableId = '{tableid}'";
            ExecuteEditQuery(query);
        }
        //Select order
        public List<SelectedItem> GetMakingOrder(int tableid, int status)
        {
            string query = $"select tableId, menuItem, Prijs, status from [SelectedItems] where tableId = '{tableid}' and status ='{status}'";
            return GetItems(ExecuteSelectQuery(query));
        }

    }
}