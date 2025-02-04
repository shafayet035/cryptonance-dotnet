﻿using System;
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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.loadSettings();
        }

        private void loadSettings()
        {
            txtUserName.Text = AppState.CurrentUser.username;
            txtPassword.Text = AppState.CurrentUser.password;
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
            Exchange exchange = new Exchange();
            exchange.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text == "" || txtUserName.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }

            Profile profile = new Profile();
            profile.UpdateProfile(txtUserName.Text, txtPassword.Text);
            MessageBox.Show("Profile updated successfully");
        }
    }
}
