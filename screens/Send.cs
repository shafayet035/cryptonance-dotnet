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
    public partial class Send : Form
    {
        public Send()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.LoadBalance();
        }

        private void LoadBalance()
        {
            label8.Text = AppState.Wallet.btc.ToString();
            label9.Text = AppState.Wallet.ltc.ToString();
            label10.Text = AppState.Wallet.eth.ToString();
        }

        private void ClearFields()
        {
            comboBox1.SelectedIndex = -1;
            txtRcvr.Text = "";
            txtAmount.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0 || txtRcvr.Text == "" || txtAmount.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            Transfer transfer = new Transfer();

            foreach (var crypto in AppState.Cryptos)
            {
                if (crypto.tag.ToUpper() == comboBox1.SelectedItem.ToString())
                {
                    transfer.SendCrypto(crypto, Convert.ToSingle(txtAmount.Text), txtRcvr.Text);
                    MessageBox.Show("Transfer successful");
                    this.LoadBalance();
                    this.ClearFields();
                    return;
                }
            }
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

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange();
            exchange.Show();
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings stg = new Settings();
            stg.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login lgn = new login();
            lgn.Show();
            this.Hide();
        }
    }
}
