using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BailySports_Application
{
    public partial class Evaluation : Form
    {
        DataConnector dc = new DataConnector();
        public Evaluation()
        {
            InitializeComponent();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bailySportsData.FunctionalMovementsQuery' table. You can move, or remove it, as needed.
            this.functionalMovementsQueryTableAdapter.Fill(this.bailySportsData.FunctionalMovementsQuery);
            // TODO: This line of code loads data into the 'bailySportsData1.FunctionalMovementScores' table. You can move, or remove it, as needed.
            // this.functionalMovementScoresTableAdapter.Fill(this.bailySportsData1.FunctionalMovementScores);
            // TODO: This line of code loads data into the 'bailySportsData.Players' table. You can move, or remove it, as needed.
            this.playersTableAdapter.Fill(this.bailySportsData.Players);
            // TODO: This line of code loads data into the 'bailySportsData.EvaluationTypes' table. You can move, or remove it, as needed.
            this.evaluationTypesTableAdapter.Fill(this.bailySportsData.EvaluationTypes);
            loadFuctionalMovementScores();

        }

        private void loadFuctionalMovementScores()
        {
            DataTable fm = dc.getDataTable("Select * FROM FunctionalMovementsQuery WHERE EvaluationID = " + tbEvaluationID.Text + ";");
            dgvFunctionalMovementScores.DataSource = fm;

            foreach (DataGridViewRow r in dgvFunctionalMovementScores.Rows)
            {
                if (r.Cells["SingleScore"].Value != null)
                {
                    bool singleScore = (bool)r.Cells["SingleScore"].Value;

                    cellFormat(r.Cells["RawScoreLeft"], singleScore);
                    cellFormat(r.Cells["RawScoreRight"], singleScore);
                    cellFormat(r.Cells["RawScoreSingle"], !singleScore);

                }
            }
        }

        private void cellFormat(DataGridViewCell cell, bool readOnly)
        {
            cell.ReadOnly = readOnly;
            
            
            if (readOnly)
            {
                cell.Style.BackColor = Color.Black;
                cell.Value = DBNull.Value;
            }
            else
            {
                cell.Style.BackColor = Color.LightSeaGreen;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadFuctionalMovementScores();
        }


        private void dgvFunctionalMovementScores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {


                DataGridViewRow dgvr = dgvFunctionalMovementScores.CurrentRow;

                int colIndex = e.ColumnIndex;
                if (dgvr.Cells["Update"].ColumnIndex == colIndex)
                {
                    int FMScoreID = (int)dgvr.Cells["FMScoreID"].Value;
                    //string updFieldName = dgvr.Cells[colIndex].OwningColumn.Name.Replace("sub", "");

                    if (dgvr.Cells[colIndex].OwningColumn.ReadOnly == false)
                    {
                        fmCalculate();
                        DataGridViewCell rcell = dgvr.Cells["RawScoreRight"];
                        DataGridViewCell lcell = dgvr.Cells["RawScoreLeft"];
                        DataGridViewCell scell = dgvr.Cells["RawScoreSingle"];
                        DataGridViewCell fcell = dgvr.Cells["FinalScore"];

                        //dc.gridCellUpdate("FunctionalMovementScores", dgvr.Cells[colIndex], FMScoreID, "FMScoreID", updFieldName, "username");
                        //dc.gridCellUpdate("FunctionalMovementScores", dgvr.Cells["FinalScore"], FMScoreID, "FMScoreID", "FinalScore", "username");
                        string sqlStatement = "UPDATE FunctionalMovementScores SET RawScoreSingle = " + cellValue(scell) +
                            ", RawScoreRight = " + cellValue(rcell) + 
                            ", RawScoreLeft = " + cellValue(lcell) +
                            ", FinalScore = " + cellValue(fcell) +
                            " WHERE FMScoreID = " + FMScoreID + ";";

                        dc.runSQL(sqlStatement);
                        //TODO - update evaluation with total functional movement user query if needed.
                       // sqlStatement = "UPDATE Evaluations SET FunctionalMovementTotal = 
                        loadFuctionalMovementScores();
                    }
                }


            }
        }

        private string cellValue (DataGridViewCell cell)
        {
            string retval = "NULL";

            int cellVal = 0;

            if (cell != null && cell.Value != null && !string.IsNullOrEmpty(cell.Value.ToString()))
            {
                int.TryParse(cell.Value.ToString(), out cellVal);
                retval = cellVal.ToString();
            }

            return retval;
        }


        private void fmCalculate()
        {
            DataGridViewRow dgvr = dgvFunctionalMovementScores.CurrentRow;

            if (dgvr.Cells["SingleScore"].Value != null)
            {
                bool singleScore = (bool)dgvr.Cells["SingleScore"].Value;
                DataGridViewCell rcell = dgvr.Cells["RawScoreRight"];
                DataGridViewCell lcell = dgvr.Cells["RawScoreLeft"];
                DataGridViewCell scell = dgvr.Cells["RawScoreSingle"];

                if (singleScore)
                {
                    int s = 0;
                    if (scell != null && scell.Value != null)
                    {
                        int.TryParse(scell.Value.ToString(), out s);
                    }
                    dgvr.Cells["FinalScore"].Value = s;
                }
                else
                {
                    int r = 0;
                    if (rcell != null && rcell.Value != null)
                    {
                        int.TryParse(rcell.Value.ToString(), out r);
                    }

                    int l = 0;
                    if (lcell != null && lcell.Value != null)
                    {
                        int.TryParse(lcell.Value.ToString(), out l);
                    }

                    if (r < l)
                    {
                        dgvr.Cells["FinalScore"].Value = r;
                    }
                    else
                    {
                        dgvr.Cells["FinalScore"].Value = l;
                    }
                }

            }
        }

        private void dgvFunctionalMovementScores_CellContentClick1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = dgvFunctionalMovementScores.CurrentRow;
            DataGridViewCell cell = dgvFunctionalMovementScores.CurrentCell;
            if (cell.ReadOnly)
            {
               //dgvFunctionalMovementScores.
            }
        }


        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            skipReadOnlyCells();
        }

        private void skipReadOnlyCells()
        {
            DataGridViewCell currentCell = dgvFunctionalMovementScores.CurrentCell;
            if (currentCell != null && currentCell.ReadOnly)
            {
                int nextRow = currentCell.RowIndex;
                int nextCol = currentCell.ColumnIndex + 1;
                if (nextCol == dgvFunctionalMovementScores.ColumnCount)
                {
                    nextCol = 0;
                    nextRow++;
                }
                if (nextRow == dgvFunctionalMovementScores.RowCount)
                {
                    nextRow = 0;
                }
                DataGridViewCell nextCell = dgvFunctionalMovementScores.Rows[nextRow].Cells[nextCol];
                if (nextCell != null)
                {
                   
                    //dgvFunctionalMovementScores.CurrentCell = nextCell;
                    //dgvFunctionalMovementScores.CurrentCell.Selected = true;
                    //skipReadOnlyCells();
                }
            }
        }
    }
}
