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
                    Color cellColor = Color.Black;
                    if (singleScore)
                    {
                        cellColor = Color.LightBlue;
                    }

                    r.Cells["RawScoreLeft"].ReadOnly = singleScore;
                    r.Cells["RawScoreRight"].ReadOnly = singleScore;
                    r.Cells["RawScoreSingle"].ReadOnly = !singleScore;
                    r.Cells["RawScoreSingle"].Style.BackColor = cellColor;
                   



                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadFuctionalMovementScores();
        }
    }
}
