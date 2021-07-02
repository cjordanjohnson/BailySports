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
    public partial class PlayerMaintenance : Form
    {
        public PlayerMaintenance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataConnector dc = new DataConnector();

            dc.connection();

        }
    }
}
