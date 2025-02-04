using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cryptonance.services;
using cryptonance.state;

namespace cryptonance.screens
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Wallet wallet = new Wallet();

            wallet.GetWalletBalance();
            wallet.GetCryptos();

            lblBtcBalance.Text = AppState.Wallet.btc.ToString();
            lvlLtcBalance.Text = AppState.Wallet.ltc.ToString();
            lvlEthBalance.Text = AppState.Wallet.eth.ToString();

            lvlBtcUsd.Text = $"${AppState.Wallet.btc * AppState.Cryptos[0].price}";
            lvlLtcUsd.Text = $"${AppState.Wallet.ltc * AppState.Cryptos[1].price}";
            lvlEthUsd.Text = $"${AppState.Wallet.eth * AppState.Cryptos[2].price}";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Send send = new Send();
            send.Show();
            this.Hide();
        }

        private void buyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy by = new Buy();
            by.Show();
            this.Hide();
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sell sl = new Sell();
            sl.Show();
            this.Hide();
        }
    }
}
