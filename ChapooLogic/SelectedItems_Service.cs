using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class SelectedItems_Service
    {
        SelectedItems_DAO selectedItems_DAO = new SelectedItems_DAO();
        //Create new user -> insert db
        public void selectedItem(int tableId, string item, int prijs)
        {
            selectedItems_DAO.InsertNewSelectedItem(tableId, item, prijs);
        }

        //Get
        public List<SelectedItem> GetSelectedItems()
        {
            List<SelectedItem> selectedItemsList;
            selectedItemsList = selectedItems_DAO.GetSelectedItems();
            return selectedItemsList;
        }
        //Update
        public void updateStatus(string menuItem, int tableId)
        {
            selectedItems_DAO.UpdateStatus(menuItem, tableId);
        }
        //
        public List<SelectedItem> GetCurrentItems(int tableid)
        {
            List<SelectedItem> selectedItemsList;
            selectedItemsList = selectedItems_DAO.GetSelectedOrder(tableid);
            return selectedItemsList;
        }
    }
}
