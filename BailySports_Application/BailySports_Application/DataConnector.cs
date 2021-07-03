using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace BailySports_Application
{
    class DataConnector
    {
        public OleDbConnection con;
        public OleDbCommand cmd;


        public DataConnector ()
        {
            con = new OleDbConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["BailySports_Application.Properties.Settings.BaileySports_DataConnectionString"].ConnectionString;
            cmd = new OleDbCommand();
        }

        public void connection()
        {

            OleDbDataReader reader;
            int counter = 0;

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Players";
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {//www.csharp-console-example.com
                counter++;
                //Console.WriteLine(reader[0] + "-" + reader[1] + " " + reader[2]);
                string test = reader[0].ToString();
                string test2 = reader[1].ToString();
            }
            con.Close();
        }
    }
}
