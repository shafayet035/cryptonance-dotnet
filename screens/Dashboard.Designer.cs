namespace cryptonance.screens
{
    partial class Dashboard
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
            sendToolStripMenuItem = new ToolStripMenuItem();
            exchangeToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            lblBtcBalance = new Label();
            lvlBtcUsd = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            lvlLtcBalance = new Label();
            lvlLtcUsd = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            lvlEthBalance = new Label();
            lvlEthUsd = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            sellToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, buyToolStripMenuItem, sellToolStripMenuItem, sendToolStripMenuItem, exchangeToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(1, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1071, 36);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(76, 32);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // buyToolStripMenuItem
            // 
            buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            buyToolStripMenuItem.Size = new Size(39, 32);
            buyToolStripMenuItem.Text = "Buy";
            buyToolStripMenuItem.Click += buyToolStripMenuItem_Click;
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
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(116, 22);
            logoutToolStripMenuItem1.Text = "Logout";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblBtcBalance);
            panel1.Controls.Add(lvlBtcUsd);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(239, 148);
            panel1.TabIndex = 7;
            // 
            // lblBtcBalance
            // 
            lblBtcBalance.AutoSize = true;
            lblBtcBalance.Location = new Point(23, 113);
            lblBtcBalance.Name = "lblBtcBalance";
            lblBtcBalance.Size = new Size(28, 15);
            lblBtcBalance.TabIndex = 4;
            lblBtcBalance.Text = "00.0";
            // 
            // lvlBtcUsd
            // 
            lvlBtcUsd.AutoSize = true;
            lvlBtcUsd.Location = new Point(39, 83);
            lvlBtcUsd.Name = "lvlBtcUsd";
            lvlBtcUsd.Size = new Size(28, 15);
            lvlBtcUsd.TabIndex = 3;
            lvlBtcUsd.Text = "00.0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 83);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 2;
            label4.Text = "$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 53);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "BTC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Bitcoin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 8;
            label3.Text = "Your Wallet Balance";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lvlLtcBalance);
            panel2.Controls.Add(lvlLtcUsd);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(298, 129);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 148);
            panel2.TabIndex = 8;
            // 
            // lvlLtcBalance
            // 
            lvlLtcBalance.AutoSize = true;
            lvlLtcBalance.Location = new Point(23, 113);
            lvlLtcBalance.Name = "lvlLtcBalance";
            lvlLtcBalance.Size = new Size(28, 15);
            lvlLtcBalance.TabIndex = 4;
            lvlLtcBalance.Text = "00.0";
            // 
            // lvlLtcUsd
            // 
            lvlLtcUsd.AutoSize = true;
            lvlLtcUsd.Location = new Point(38, 83);
            lvlLtcUsd.Name = "lvlLtcUsd";
            lvlLtcUsd.Size = new Size(28, 15);
            lvlLtcUsd.TabIndex = 3;
            lvlLtcUsd.Text = "00.0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 83);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 2;
            label7.Text = "$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 53);
            label8.Name = "label8";
            label8.Size = new Size(25, 15);
            label8.TabIndex = 1;
            label8.Text = "LTC";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(23, 26);
            label9.Name = "label9";
            label9.Size = new Size(49, 15);
            label9.TabIndex = 0;
            label9.Text = "Litecoin";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lvlEthBalance);
            panel3.Controls.Add(lvlEthUsd);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(593, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 148);
            panel3.TabIndex = 8;
            // 
            // lvlEthBalance
            // 
            lvlEthBalance.AutoSize = true;
            lvlEthBalance.Location = new Point(23, 113);
            lvlEthBalance.Name = "lvlEthBalance";
            lvlEthBalance.Size = new Size(28, 15);
            lvlEthBalance.TabIndex = 4;
            lvlEthBalance.Text = "00.0";
            // 
            // lvlEthUsd
            // 
            lvlEthUsd.AutoSize = true;
            lvlEthUsd.Location = new Point(39, 83);
            lvlEthUsd.Name = "lvlEthUsd";
            lvlEthUsd.Size = new Size(28, 15);
            lvlEthUsd.TabIndex = 3;
            lvlEthUsd.Text = "00.0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(23, 83);
            label12.Name = "label12";
            label12.Size = new Size(13, 15);
            label12.TabIndex = 2;
            label12.Text = "$";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 53);
            label13.Name = "label13";
            label13.Size = new Size(28, 15);
            label13.TabIndex = 1;
            label13.Text = "ETH";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 26);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 0;
            label14.Text = "Etherium";
            // 
            // sellToolStripMenuItem
            // 
            sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            sellToolStripMenuItem.Size = new Size(37, 32);
            sellToolStripMenuItem.Text = "Sell";
            sellToolStripMenuItem.Click += sellToolStripMenuItem_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem buyToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private Panel panel1;
        private Label lblBtcBalance;
        private Label lvlBtcUsd;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Label lvlLtcBalance;
        private Label lvlLtcUsd;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private Label lvlEthBalance;
        private Label lvlEthUsd;
        private Label label12;
        private Label label13;
        private Label label14;
        private ToolStripMenuItem sellToolStripMenuItem;
    }
}