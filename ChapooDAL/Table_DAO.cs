using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ChapooDAL
{
    public class Table_DAO : Base
    {
        DataTable dataTable = new DataTable();

        //Set table to reservated
        public void SetTableReservated(int tableId)
        {
            SqlConnection con = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Initial Catalog=chapoo1920f05;user=chapoo1920f05;password=Xm8ws!25HZ4~;");
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("Update  [table] set TableStatus=2 where TableId=@tafelid", con);
            cmd.Parameters.Add("@tafelid", tableId);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
