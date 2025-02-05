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
    public partial class Transactions : Form
    {
        public Transactions()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.LoadData();
        }

        private void LoadData()
        {
            services.Transactions transactions = new services.Transactions();
            transactions.GetAllTransaction();

            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("type", "Type");
            dataGridView1.Columns.Add("crypto", "Crypto");
            dataGridView1.Columns.Add("amount", "Amount");
            dataGridView1.Columns.Add("receiver", "Receiver");

            foreach (var transaction in AppState.Transactions)
            {
                dataGridView1.Rows.Add(transaction.id, transaction.type, transaction.cryptoName, transaction.totalPrice, transaction.receiverEmail);
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
            Send send = new Send();
            send.Show();
            this.Hide();
        }

        private void exchangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exchange exchange = new Exchange();
            exchange.Show();
            this.Hide();
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transactions transactions = new Transactions();
            transactions.Show();
            this.Hide();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }
    }
}
