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
    public partial class Admin : Form
    {
        int selectedCryptoId = -1;
        int selectedUserId = -1;

        services.Admin admin = new services.Admin();
        public Admin()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            admin.GetAllUsers();

            this.LoadCurrency();
            this.LoadUsers();
        }

        private void LoadUsers()
        {
            dataGridView2.Rows.Clear();

            dataGridView2.Columns.Add("id", "ID");
            dataGridView2.Columns.Add("username", "Username");
            dataGridView2.Columns.Add("email", "Email");
            dataGridView2.Columns.Add("password", "Password");
            dataGridView2.Columns.Add("role", "Role");

            foreach (var user in AppState.Users)
            {
                dataGridView2.Rows.Add(user.id, user.username, user.email, user.password, user.role);
            }
        }

        private void LoadCurrency()
        {
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns.Add("selling_rate", "Selling Rate");


            foreach (var crypto in AppState.Cryptos)
            {
                dataGridView1.Rows.Add(crypto.id, crypto.name, $"${crypto.price} per {crypto.tag.ToUpper()}", $"${crypto.sellingRate} per {crypto.tag.ToUpper()}");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            selectedCryptoId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var selectedCrypto = AppState.Cryptos.Find(crypto => Convert.ToInt32(crypto.id) == selectedCryptoId);

            if (selectedCrypto != null)
            {
                txtBuyingRate.Text = selectedCrypto.price.ToString();
                txtSellingRate.Text = selectedCrypto.sellingRate.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedCryptoId < 0 || txtBuyingRate.Text == "" || txtSellingRate.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            admin.UpdateCryptoPrices(selectedCryptoId, Convert.ToSingle(txtBuyingRate.Text), Convert.ToSingle(txtSellingRate.Text));
            MessageBox.Show("Crypto updated successfully");

        }

      

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            selectedUserId = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value);
            var selectedUser = AppState.Users.Find(user => Convert.ToInt32(user.id) == selectedUserId);
            if (selectedUser != null)
            {
                txtUsername.Text = selectedUser.username;
                txtPassword.Text = selectedUser.password;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedUserId < 0 || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            admin.UpdateUser(selectedUserId, txtUsername.Text, txtPassword.Text);
            this.LoadUsers();
            MessageBox.Show("User updated successfully");
        }

        private void button3_Click(object sender, EventArgs e)
        {
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
