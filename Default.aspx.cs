﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SQLite;

using System.Text;
using System.Threading.Tasks;
namespace TestingSQLite
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  SQLiteConnection sqlite_conn;
          //  sqlite_conn = CreateConnection();
          //  CreateTable(sqlite_conn);
          //  InsertData(sqlite_conn);
        //    ReadData(sqlite_conn);
        }
        public SQLiteConnection CreateConnection()
      {
 
         SQLiteConnection sqlite_conn;
         // Create a new database connection:
         sqlite_conn = new SQLiteConnection("Data Source=D:\\music.db;Version=3;");
         // Open the connection:
            sqlite_conn.Open();
         
         
         return sqlite_conn;
      }
 
      public void CreateTable(SQLiteConnection conn)
      {
 
         SQLiteCommand sqlite_cmd;
         
         //conn.Open();
         string Createsql = "CREATE TABLE IF NOT EXISTS SampleTable (Col1 VARCHAR(20), Col2 INT)";
         string Createsql1 = "CREATE TABLE IF NOT EXISTS SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
         sqlite_cmd = conn.CreateCommand();
         sqlite_cmd.CommandText = Createsql;
        

         sqlite_cmd.ExecuteNonQuery();
         sqlite_cmd.CommandText = Createsql1;
         sqlite_cmd.ExecuteNonQuery();
 
      }
 
      public void InsertData(SQLiteConnection conn)
      {
         SQLiteCommand sqlite_cmd;
         sqlite_cmd = conn.CreateCommand();
         sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test Text ', 1);";
         sqlite_cmd.ExecuteNonQuery();
         sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test1 Text1 ', 2);";
         sqlite_cmd.ExecuteNonQuery();
         sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES ('Test2 Text2 ', 3);";
         sqlite_cmd.ExecuteNonQuery();
 
 
         sqlite_cmd.CommandText = "INSERT INTO SampleTable1 (Col1, Col2) VALUES ('Test3 Text3 ', 3);";
         sqlite_cmd.ExecuteNonQuery();
 
      }
 
      public void ReadData(SQLiteConnection conn)
      {
         SQLiteDataReader sqlite_datareader;
         SQLiteCommand sqlite_cmd;
         sqlite_cmd = conn.CreateCommand();
         sqlite_cmd.CommandText = "SELECT * FROM SampleTable";
 
         sqlite_datareader = sqlite_cmd.ExecuteReader();
         while (sqlite_datareader.Read())
         {
             string myreader = sqlite_datareader.GetString(0) + sqlite_datareader.GetInt32(1);
            System.Diagnostics.Debug.WriteLine(myreader);
         }
         conn.Close();
      }
    }
}