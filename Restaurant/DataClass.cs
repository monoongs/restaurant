using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Data.OleDb;

public class ConnectDB2
{

    private string strConnection()
    {
        return "Data Source=CASPER_PC\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True";
            //"Data Source=BOY\\SQLEXPRESS;Initial Catalog=BookStroe;Integrated Security=True";
            //"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bookProDB.mdf;Integrated Security=True";
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True
    }

    public SqlConnection connection()
    {
        SqlConnection conn = new SqlConnection(strConnection());
        return conn;
    }
}

public class DbClass
{
   // public static OleDbConnection connection;
   // public static OleDbCommand command;
    public DataTable GetData(string sql, string tblName)
    {
        SqlConnection conn = new ConnectDB2().connection();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, tblName);
        return ds.Tables[0];
    }

    public DataTable GetData(string sql, string tblName, SqlParameterCollection parameters)
    {
        SqlConnection conn = new ConnectDB2().connection();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        foreach (SqlParameter param in parameters)
        {
            da.SelectCommand.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
        }

        da.Fill(ds, tblName);
        return ds.Tables[0];
    }


    public int ExecuteData(string sql)
    {
        int i;
        SqlConnection conn = new ConnectDB2().connection();
        SqlCommand cmd = new SqlCommand(sql, conn);
        conn.Open();
        i = cmd.ExecuteNonQuery();
        conn.Close();
        return i;
    }

    public int ExecuteData(string sql, SqlParameterCollection parameters)
    {
        int i;
        SqlConnection conn = new ConnectDB2().connection();
        SqlCommand cmd = new SqlCommand(sql, conn);

        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
        }

        conn.Open();
        i = cmd.ExecuteNonQuery();
        conn.Close();
        return i;
    }



}
    

