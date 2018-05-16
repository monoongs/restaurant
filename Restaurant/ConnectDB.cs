﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


public class ConnectDB
{

    public SqlConnection SqlStrCon()
    {
        return new SqlConnection("Data Source=CASPER_PC\\SQLEXPRESS;Initial Catalog=Restaurant;Integrated Security=True");

    }
}

public class DBClass
{
    //SQL Server Class
    #region
    public DataSet SqlGet(string sql, string tblName)
    {
        SqlConnection conn = new ConnectDB().SqlStrCon();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        da.Fill(ds, tblName);
        return ds;
    }
    public DataSet SqlGet(string sql, string tblName, SqlParameterCollection parameters)
    {
        SqlConnection conn = new ConnectDB().SqlStrCon();
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataSet ds = new DataSet();
        foreach (SqlParameter param in parameters)
        {
            da.SelectCommand.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
        }
        da.Fill(ds, tblName);
        return ds;
    }
    public int SqlExecute(string sql)
    {
        int i;
        SqlConnection conn = new ConnectDB().SqlStrCon();
        SqlCommand cmd = new SqlCommand(sql, conn);
        conn.Open();
        i = cmd.ExecuteNonQuery();
        conn.Close();
        return i;
    }
    public int SqlExecute(string sql, SqlParameterCollection parameters)
    {
        int i;
        SqlConnection conn = new ConnectDB().SqlStrCon();
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
    public DataSet SqlExcSto(string stpName, string tblName, SqlParameterCollection parameters)
    {
        SqlConnection conn = new ConnectDB().SqlStrCon();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = stpName;
        foreach (SqlParameter param in parameters)
        {
            cmd.Parameters.AddWithValue(param.ParameterName, param.SqlDbType).Value = param.Value;
        }
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds, tblName);
        return ds;
    }

    
    #endregion
}


