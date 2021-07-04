using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace BailySports_Application
{
    public partial class PlayerMaintenance : Form
    {
        DataConnector dc;

        OleDbCommand command;
        OleDbDataAdapter da;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder oleCommandBuilder = null;
        DataTable dataTable = new DataTable();
        public PlayerMaintenance()
        {
            InitializeComponent();
            dc = new DataConnector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPlayers.EndEdit(); //very important step
            da.Update(dataTable);

            MessageBox.Show("Updated");
            DataBind();

        }

        private void PlayerMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bailySportsData1.Players' table. You can move, or remove it, as needed.
            //this.playersTableAdapter.Fill(this.bailySportsData1.Players);
            DataBind();
        }


        private void DataBind()
        {
            dgvPlayers.DataSource = null;
            dataTable.Clear();

            //String connectionString = MainWindow.GetConnectionString(); //use your connection string please
            String queryString1 = "SELECT * FROM Players;"; // Use your table please

            OleDbConnection connection = dc.getConnection();
            
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = queryString1;
            try
            {
                da = new OleDbDataAdapter(queryString1, connection);
                oleCommandBuilder = new OleDbCommandBuilder(da);
                da.Fill(dataTable);
                dataTable.TableName = "Players";
                bindingSource = new BindingSource { DataSource = dataTable };
                dgvPlayers.DataSource = bindingSource;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        private void dgvPlayers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlayers.CurrentRow.Cells["Update"].ColumnIndex == e.ColumnIndex)
            {
                dgvPlayers.EndEdit(); //very important step
                da.Update(dataTable);
                
                MessageBox.Show("Updated");
                DataBind();
                //updatePlayer();
            }
          //  else if (dgvPlayers.CurrentRow.Cells["Delete"].ColumnIndex == e.ColumnIndex)
            {
                //delete
            }

        }

        private void updatePlayer()
        {
            if (dgvPlayers.IsCurrentRowDirty)
            {
                

                DataGridViewRow dgvr = dgvPlayers.CurrentRow;
                int playerID = (int)dgvr.Cells["PlayerID"].Value;
                string firstName = dgvr.Cells["FirstName"].Value.ToString();
                string lastName = dgvr.Cells["LastName"].Value.ToString();
                string email = dgvr.Cells["EmailAddress"].Value.ToString();
                DateTime clientDate = DateTime.Today;
                string birthDate = dgvr.Cells["BirthDate"].Value.ToString();
                string arm = dgvr.Cells["Arm"].Value.ToString();
                string height = dgvr.Cells["HeightInches"].Value.ToString();
                string weight = dgvr.Cells["Weight"].Value.ToString();

                if (playerID == -1) //insert
                {
                    string sqlCmd = "INSERT INTO Players (PlayerID, FirstName, LastName, EmailAddress, ClientDate, BirthDate, Arm, HeightInches, Weight) " +
                        "VALUES (" + playerID + ", '" + firstName + "' , '" + lastName + "' , '" + email + "', '" + clientDate.ToString() + "', '" +
                        birthDate.ToString() + "' , '" + arm + "', " + height + ", " + weight + ");";

                    dc.runSQL(sqlCmd);
                }
                else
                {
                    string sqlCmd = "UPDATE Players SET FirstName = '" + firstName + "', LastName = '" + lastName + "', email = '" + email + //"', " +
                        //"BirthDate = '" + birthDate.ToString() + 
                        "', Arm = '" + arm + "', Height = " + height + ", Weight = " + weight +
                        " WHERE PlayerID = " + playerID.ToString() + ";";
                    dc.runSQL(sqlCmd);
                }
            }
        }
    }
}
