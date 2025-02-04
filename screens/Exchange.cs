using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cryptonance.models;
using cryptonance.services;
using cryptonance.state;

namespace cryptonance.screens
{
    public partial class Exchange : Form
    {

        private float btcToEth = 2.36f;
        private float btcToLtc = 5.78f;
        private float ethToBtc = 0.47f;
        private float ethToLtc = 2.46f;
        private float ltcToBtc = 0.14f;
        private float ltcToEth = 0.45f;

        public Exchange()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.loadBalance();
        }

        private void loadBalance()
        {
            label8.Text = AppState.Wallet.btc.ToString();
            label9.Text = AppState.Wallet.ltc.ToString();
            label10.Text = AppState.Wallet.eth.ToString();
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

        private void Exchange_Load(object sender, EventArgs e)
        {

        }

        private void from_Click(object sender, EventArgs e)
        {

        }

        private float ConvertCurrency(Crypto fromCrypto, Crypto toCrypto, float amount)
        {
            float convertedAmount = 0;

            if (fromCrypto.tag == "BTC" && toCrypto.tag == "ETH")
            {
                convertedAmount = amount * btcToEth;
            }
            else if (fromCrypto.tag == "BTC" && toCrypto.tag == "LTC")
            {
                convertedAmount = amount * btcToLtc;
            }
            else if (fromCrypto.tag == "ETH" && toCrypto.tag == "BTC")
            {
                convertedAmount = amount * ethToBtc;
            }
            else if (fromCrypto.tag == "ETH" && toCrypto.tag == "LTC")
            {
                convertedAmount = amount * ethToLtc;
            }
            else if (fromCrypto.tag == "LTC" && toCrypto.tag == "BTC")
            {
                convertedAmount = amount * ltcToBtc;
            }
            else if (fromCrypto.tag == "LTC" && toCrypto.tag == "ETH")
            {
                convertedAmount = amount * ltcToEth;
            }

            return convertedAmount;
        }

        private void exchangeb_Click(object sender, EventArgs e)
        {
            if (frombox.SelectedIndex < 0 || tobox.SelectedIndex < 0 || amountbox.Text == "")
            {
                MessageBox.Show("Please fill field");
                return;
            }

            Crypto from = AppState.Cryptos.Find(cryp => cryp.tag == frombox.SelectedItem.ToString());
            Crypto to = AppState.Cryptos.Find(cryp => cryp.tag == tobox.SelectedItem.ToString());

            float balance = AppState.Wallet.GetCryptoBalance(from.tag);

            if (balance < Convert.ToSingle(amountbox.Text))
            {
                MessageBox.Show("Insufficient balance");
                return;
            }

            if (from == null || to == null)
            {
                MessageBox.Show("Invalid cryptocurrency selected");
                return;
            }

            Trade trade = new Trade();

            float convertedAmount = this.ConvertCurrency(from, to, Convert.ToSingle(amountbox.Text));

            trade.ExchangeCrypto(from, to, Convert.ToSingle(amountbox.Text), convertedAmount);

            MessageBox.Show("Exchange successful");

            this.loadBalance();

            frombox.SelectedIndex = -1;
            tobox.SelectedIndex = -1;
            amountbox.Text = "";
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings stg = new Settings();
            stg.Show();
            this.Hide();
        }

        private void UpdateExchangeText()
        {
            if (this.frombox.SelectedIndex >= 0 && this.tobox.SelectedIndex >= 0 && amountbox.Text != "")
            {
                Crypto from = AppState.Cryptos.Find(cryp => cryp.tag == frombox.SelectedItem.ToString());
                Crypto to = AppState.Cryptos.Find(cryp => cryp.tag == tobox.SelectedItem.ToString());

                if (from.tag == to.tag)
                {
                    MessageBox.Show("You cannot exchange the same cryptocurrency");
                    tobox.SelectedIndex = -1;
                    return;
                }

                float convertedAmount = this.ConvertCurrency(from, to, Convert.ToSingle(amountbox.Text));

                lblExchange.Text = $"You will get {convertedAmount} {to.tag}";
            }
        }
        private void tobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateExchangeText();
        }

        private void amountbox_TextChanged(object sender, EventArgs e)
        {
            this.UpdateExchangeText();
        }

        private void frombox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.UpdateExchangeText();
        }
    }
}
