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

namespace cryptonance
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }

            Auth auth = new Auth();
            bool userRegistered = auth.Register(new models.User(txtUserName.Text, txtEmail.Text, txtPassword.Text));
            if (userRegistered)
            {
                MessageBox.Show("User registered successfully");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
            this.ResumeLayout();
        }
    }
}
