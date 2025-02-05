namespace cryptonance.screens
{
    partial class Buy
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
            viewTransactionToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblTotalAmount = new Label();
            label19 = new Label();
            button1 = new Button();
            txtCC = new TextBox();
            label4 = new Label();
            txtAmount = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label10 = new Label();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, buyToolStripMenuItem, sellToolStripMenuItem, sendToolStripMenuItem, exchangeToolStripMenuItem, viewTransactionToolStripMenuItem, logoutToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1072, 36);
            menuStrip1.TabIndex = 8;
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
            // viewTransactionToolStripMenuItem
            // 
            viewTransactionToolStripMenuItem.Name = "viewTransactionToolStripMenuItem";
            viewTransactionToolStripMenuItem.Size = new Size(107, 32);
            viewTransactionToolStripMenuItem.Text = "View Transaction";
            viewTransactionToolStripMenuItem.Click += viewTransactionsToolStripMenuItem_Click;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblTotalAmount);
            panel1.Controls.Add(label19);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtCC);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(178, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 314);
            panel1.TabIndex = 9;
            panel1.Paint += panel1_Paint;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Location = new Point(81, 212);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(19, 15);
            lblTotalAmount.TabIndex = 17;
            lblTotalAmount.Text = "00";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(18, 212);
            label19.Name = "label19";
            label19.Size = new Size(67, 15);
            label19.TabIndex = 16;
            label19.Text = "Total Price: ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(18, 243);
            button1.Name = "button1";
            button1.Size = new Size(114, 28);
            button1.TabIndex = 10;
            button1.Text = "Buy";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCC
            // 
            txtCC.Location = new Point(18, 172);
            txtCC.Name = "txtCC";
            txtCC.Size = new Size(304, 23);
            txtCC.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 154);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 14;
            label4.Text = "Credit Card Number";
            label4.Click += label4_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(18, 106);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(304, 23);
            txtAmount.TabIndex = 13;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 88);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 12;
            label3.Text = "Enter Amount";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BTC", "LTC", "ETH" });
            comboBox1.Location = new Point(18, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(304, 23);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 23);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 10;
            label2.Text = "Select Crypto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 104);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Buy Crypto";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(534, 287);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 170);
            panel2.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(60, 60);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 13;
            label8.Text = "0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 120);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 15;
            label10.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 23);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 9;
            label6.Text = "Your'e Current Balance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(60, 90);
            label9.Name = "label9";
            label9.Size = new Size(28, 15);
            label9.TabIndex = 14;
            label9.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 60);
            label7.Name = "label7";
            label7.Size = new Size(26, 15);
            label7.TabIndex = 10;
            label7.Text = "BTC";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(26, 90);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 11;
            label11.Text = "LTC";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(26, 120);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 12;
            label12.Text = "ETH";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(534, 143);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(405, 130);
            dataGridView1.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(534, 104);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 20;
            label5.Text = "Currency USD Price";
            // 
            // Buy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Name = "Buy";
            Text = "Buy";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private TextBox txtCC;
        private Label label4;
        private TextBox txtAmount;
        private Button button1;
        private Panel panel2;
        private Label label8;
        private Label label10;
        private Label label6;
        private Label label9;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label lblTotalAmount;
        private Label label19;
        private DataGridView dataGridView1;
        private Label label5;
        private ToolStripMenuItem sellToolStripMenuItem;
        private ToolStripMenuItem viewTransactionToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
    }
}