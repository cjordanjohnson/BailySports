using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace BailySports_Application
{
    class DataConnector
    {
        public OleDbConnection sqlConn;
        public OleDbCommand cmd;


        public DataConnector ()
        {
            Initialize();
        }

        public void Initialize()
        {
            sqlConn = new OleDbConnection();
            sqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["BailySports_Application.Properties.Settings.BaileySports_DataConnectionString"].ConnectionString;
            cmd = new OleDbCommand();
            sqlConn.Open();
        }

        public OleDbConnection getConnection()
        {
            sqlConn = new OleDbConnection();
            sqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["BailySports_Application.Properties.Settings.BaileySports_DataConnectionString"].ConnectionString;
            return sqlConn;
        }
        public int runSQL(string command)
        {
            int retval = -1;
            Initialize();
           

            OleDbCommand cmd = new OleDbCommand(command, sqlConn);

            // int reader = cmd.ExecuteNonQuery();
            sqlConn.Open();
            retval = cmd.ExecuteNonQuery();
            sqlConn.Close();
            return retval;

        }

        public DataTable getDataTable(string command)
        {

            Initialize();

            DataTable dt = new DataTable();

            using (sqlConn)
            {
                using (OleDbCommand cmd = new OleDbCommand(command, sqlConn))
                {
                    using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                    {
                        if (sqlConn.State == ConnectionState.Open)
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }

            sqlConn.Close();

            return dt;
        }

        public void connection()
        {

            OleDbDataReader reader;
            int counter = 0;

            cmd.Connection = sqlConn;
            cmd.CommandText = "SELECT * FROM Players";
            sqlConn.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {//www.csharp-console-example.com
                counter++;
                //Console.WriteLine(reader[0] + "-" + reader[1] + " " + reader[2]);
                string test = reader[0].ToString();
                string test2 = reader[1].ToString();
            }
            sqlConn.Close();
        }
    }
}
