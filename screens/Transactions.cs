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
    }
}
