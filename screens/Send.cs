using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cryptonance.state;

namespace cryptonance.screens
{
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            label8.Text = AppState.Wallet.btc.ToString();
            label9.Text = AppState.Wallet.ltc.ToString();
            label10.Text = AppState.Wallet.eth.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
