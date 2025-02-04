using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptonance.screens
{
    public partial class Exchange : Form
    {
        public Exchange()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.Show();
            this.Hide();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell();
            sell.Show();
            this.Hide();
        }

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
