using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace ChapooDAL
{
    public class Table_DAO : Base
    {
        DataTable dataTable = new DataTable();

        //Set table to reservated
        public void SetTableReservated(int table)
        {
            string query = "Update [table] set TableStatus=2 where TableId=@tafelid";
            query = query.Replace("@tafelid", table.ToString());
            ExecuteEditQuery(query);
        }
    }
}
