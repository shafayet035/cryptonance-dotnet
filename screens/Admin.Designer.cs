namespace cryptonance.screens
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            buyToolStripMenuItem = new ToolStripMenuItem();
            sellToolStripMenuItem = new ToolStripMenuItem();
            sendToolStripMenuItem = new ToolStripMenuItem();
            exchangeToolStripMenuItem = new ToolStripMenuItem();
            viewTransactionsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            txtBuyingRate = new TextBox();
            label3 = new Label();
            txtSellingRate = new TextBox();
            button1 = new Button();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            txtUsername = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, buyToolStripMenuItem, sellToolStripMenuItem, sendToolStripMenuItem, exchangeToolStripMenuItem, viewTransactionsToolStripMenuItem, logoutToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(-1, -1);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1073, 36);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(76, 32);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // buyToolStripMenuItem
            // 
            buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            buyToolStripMenuItem.Size = new Size(39, 32);
            buyToolStripMenuItem.Text = "Buy";
            buyToolStripMenuItem.Click += buyToolStripMenuItem_Click;
            // 
            // sellToolStripMenuItem
            // 
            sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            sellToolStripMenuItem.Size = new Size(37, 32);
            sellToolStripMenuItem.Text = "Sell";
            sellToolStripMenuItem.Click += sellToolStripMenuItem_Click;
            // 
            // sendToolStripMenuItem
            // 
            sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            sendToolStripMenuItem.Size = new Size(45, 32);
            sendToolStripMenuItem.Text = "Send";
            sendToolStripMenuItem.Click += sendToolStripMenuItem_Click;
            // 
            // exchangeToolStripMenuItem
            // 
            exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            exchangeToolStripMenuItem.Size = new Size(70, 32);
            exchangeToolStripMenuItem.Text = "Exchange";
            exchangeToolStripMenuItem.Click += exchangeToolStripMenuItem_Click;
            // 
            // viewTransactionsToolStripMenuItem
            // 
            viewTransactionsToolStripMenuItem.Name = "viewTransactionsToolStripMenuItem";
            viewTransactionsToolStripMenuItem.Size = new Size(112, 32);
            viewTransactionsToolStripMenuItem.Text = "View Transactions";
            viewTransactionsToolStripMenuItem.Click += viewTransactionsToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, logoutToolStripMenuItem1 });
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(64, 32);
            logoutToolStripMenuItem.Text = "Account";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(180, 22);
            logoutToolStripMenuItem1.Text = "Logout";
            logoutToolStripMenuItem1.Click += logoutToolStripMenuItem1_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 32);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 97);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 8;
            label1.Text = "Update Crypto Price";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 164);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 320);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 10;
            label2.Text = "Buying Rate";
            // 
            // txtBuyingRate
            // 
            txtBuyingRate.Location = new Point(44, 341);
            txtBuyingRate.Name = "txtBuyingRate";
            txtBuyingRate.Size = new Size(229, 23);
            txtBuyingRate.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 377);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 12;
            label3.Text = "Selling Rate";
            // 
            // txtSellingRate
            // 
            txtSellingRate.Location = new Point(44, 395);
            txtSellingRate.Name = "txtSellingRate";
            txtSellingRate.Size = new Size(229, 23);
            txtSellingRate.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(44, 436);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 97);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 15;
            label4.Text = "Update user info";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(549, 130);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(398, 164);
            dataGridView2.TabIndex = 16;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(549, 320);
            label5.Name = "label5";
            label5.Size = new Size(100, 15);
            label5.TabIndex = 17;
            label5.Text = "Update username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(549, 341);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(229, 23);
            txtUsername.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(549, 377);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 19;
            label6.Text = "Update password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(549, 395);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 23);
            txtPassword.TabIndex = 20;
            // 
            // button2
            // 
            button2.Location = new Point(549, 436);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(button2);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtSellingRate);
            Controls.Add(label3);
            Controls.Add(txtBuyingRate);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Admin";
            Text = "Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem buyToolStripMenuItem;
        private ToolStripMenuItem sellToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem viewTransactionsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox txtBuyingRate;
        private Label label3;
        private TextBox txtSellingRate;
        private Button button1;
        private Label label4;
        private DataGridView dataGridView2;
        private Label label5;
        private TextBox txtUsername;
        private Label label6;
        private TextBox txtPassword;
        private Button button2;
    }
}