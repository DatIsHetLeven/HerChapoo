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

        //Set table to reservated
        public void SetTableReservated(Table table)
        {
            string query = "Update  [table] set TableStatus=2 where TableId=@tafelid";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("TableId", table.TableId),
                new SqlParameter("TableStatus",table.TableStatus)
            };
            ExecuteEditQuery(query, sqlParameters);


        }
    }
}
