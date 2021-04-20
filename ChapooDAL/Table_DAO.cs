using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using ChapooModel;


namespace ChapooDAL
{
    public class Table_DAO : Base
    {
        DataTable dataTable = new DataTable();

        //Get all table status
        public DataTable GetTableStatus(int TableId, int TableStatus)
        {
            string query = "select * from [Table] where TableId = '" + TableId + "' and   TableStatus =  '" + TableStatus + "' ";
            DataTable dt = ExecuteSelectQuery(query);

            return dt;

        }
        //Set table to status : reservated
        public void SetTableReservated(int table)
        {
            string query = "Update [table] set TableStatus=2 where TableId=@tafelid";
            query = query.Replace("@tafelid", table.ToString());
            ExecuteEditQuery(query);
        }

        //Set table to status : Free
        public void SetTableFree(int table)
        {
            string query = "Update [table] set TableStatus=1 where TableId=@tafelid";
            query = query.Replace("@tafelid", table.ToString());
            ExecuteEditQuery(query);
        }
    }
}
