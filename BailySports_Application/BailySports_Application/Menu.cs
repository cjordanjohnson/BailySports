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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEvaluations_Click(object sender, EventArgs e)
        {
            Evaluation evaluation = new Evaluation();
            evaluation.Show();
        }

        private void btnPlayerMaint_Click(object sender, EventArgs e)
        {
            PlayerMaintenance playerMaintenance = new PlayerMaintenance();
            playerMaintenance.Show();
        }
    }
}
