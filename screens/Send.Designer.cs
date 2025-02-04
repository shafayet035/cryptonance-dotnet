namespace cryptonance.screens
{
    partial class Send
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
            logoutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            panel1 = new Panel();
            btnSend = new Button();
            txtAmount = new TextBox();
            label3 = new Label();
            txtRcvr = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, buyToolStripMenuItem, sellToolStripMenuItem, sendToolStripMenuItem, exchangeToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, -1);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1072, 36);
            menuStrip1.TabIndex = 7;
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
            // 
            // sellToolStripMenuItem
            // 
            sellToolStripMenuItem.Name = "sellToolStripMenuItem";
            sellToolStripMenuItem.Size = new Size(37, 32);
            sellToolStripMenuItem.Text = "Sell";
            // 
            // sendToolStripMenuItem
            // 
            sendToolStripMenuItem.Name = "sendToolStripMenuItem";
            sendToolStripMenuItem.Size = new Size(45, 32);
            sendToolStripMenuItem.Text = "Send";
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
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRcvr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(193, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 376);
            panel1.TabIndex = 8;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(20, 253);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 6;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(20, 200);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(348, 23);
            txtAmount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 174);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // txtRcvr
            // 
            txtRcvr.Location = new Point(20, 129);
            txtRcvr.Name = "txtRcvr";
            txtRcvr.Size = new Size(348, 23);
            txtRcvr.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 104);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Receiver Email";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BTC", "LTC", "ETH" });
            comboBox1.Location = new Point(20, 54);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(348, 23);
            comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Select Wallet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 28);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 9;
            label4.Text = "Current Balance";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 63);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 10;
            label5.Text = "BTC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 103);
            label6.Name = "label6";
            label6.Size = new Size(25, 15);
            label6.TabIndex = 11;
            label6.Text = "LTC";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 144);
            label7.Name = "label7";
            label7.Size = new Size(28, 15);
            label7.TabIndex = 12;
            label7.Text = "ETH";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(64, 63);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 13;
            label8.Text = "0.00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(64, 103);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 14;
            label9.Text = "0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(64, 144);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 15;
            label10.Text = "0.00";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(629, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 198);
            panel2.TabIndex = 16;
            // 
            // Send
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Send";
            Text = "Send";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem buyToolStripMenuItem;
        private ToolStripMenuItem sellToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private Panel panel1;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnSend;
        private TextBox txtAmount;
        private Label label3;
        private TextBox txtRcvr;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel2;
    }
}