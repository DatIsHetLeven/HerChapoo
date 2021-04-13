using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ChapooDAL;

namespace ChapooLogic
{
    public class Table_Service
    {
        public void SetTableReservate(int tableId)
        {
            Table_DAO table_DAO = new Table_DAO();
            try
            {
                
                table_DAO.SetTableReservated(tableId);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
