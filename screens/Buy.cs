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
    public partial class Buy : Form
    {
        string selectedCrypto;
        float writtenAmount;
        public Buy()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.UpdateBalance();

            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("price", "Price");
            dataGridView1.Columns.Add("selling_rate", "Selling Rate");

            // load AppState.Cryptos to dataGridView
            foreach (var crypto in AppState.Cryptos)
            {
                dataGridView1.Rows.Add(crypto.id, crypto.name, $"${crypto.price} per {crypto.tag.ToUpper()}", $"${crypto.sellingRate} per {crypto.tag.ToUpper()}");
            }
        }

        private void UpdateBalance()
        {
            label8.Text = AppState.Wallet.btc.ToString();
            label9.Text = AppState.Wallet.ltc.ToString();
            label10.Text = AppState.Wallet.eth.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTotalAmount()
        {
            foreach (var crypto in AppState.Cryptos)
            {
                if (crypto.tag.ToUpper() == selectedCrypto)
                {
                    if (txtAmount.Text != "")
                    {
                        lblTotalAmount.Text = $"${(crypto.price * writtenAmount).ToString()}";
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                this.selectedCrypto = comboBox1.SelectedItem.ToString();
                this.UpdateTotalAmount();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                return;
            }
            // check if it is number only
            if (!float.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Please enter a valid number");
                txtAmount.Text = "";
                writtenAmount = 0;
                return;
            }
            writtenAmount = Convert.ToSingle(txtAmount.Text);
            this.UpdateTotalAmount();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedCrypto == null || writtenAmount == 0 || txtCC.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }
            Purchase purchase = new Purchase();

            foreach (var crypto in AppState.Cryptos)
            {
                if (crypto.tag.ToUpper() == selectedCrypto)
                {
                    float totalAmount = crypto.price * writtenAmount;
                    purchase.AddToWalletAndBuyCrypto(crypto, writtenAmount, totalAmount);
                    MessageBox.Show("Purchase successful");
                    this.UpdateBalance();

                    // reset fields
                    txtAmount.Text = "";
                    txtCC.Text = "";
                    lblTotalAmount.Text = "$0";
                    comboBox1.SelectedIndex = -1;

                    return;
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dsh = new Dashboard();
            dsh.Show();
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
