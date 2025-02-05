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
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            viewTransactionToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(txtAmount);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtRcvr);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(193, 127);
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
            btnSend.Click += btnSend_Click;
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
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 63);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 10;
            label5.Text = "BTC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 104);
            label6.Name = "label6";
            label6.Size = new Size(26, 15);
            label6.TabIndex = 11;
            label6.Text = "LTC";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 144);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
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
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(629, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 198);
            panel2.TabIndex = 16;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, viewTransactionToolStripMenuItem, toolStripMenuItem6, adminToolStripMenuItem });
            menuStrip2.Location = new Point(0, -2);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1072, 36);
            menuStrip2.TabIndex = 29;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(76, 32);
            toolStripMenuItem1.Text = "Dashboard";
            toolStripMenuItem1.Click += dashboardToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(39, 32);
            toolStripMenuItem2.Text = "Buy";
            toolStripMenuItem2.Click += buyToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(37, 32);
            toolStripMenuItem3.Text = "Sell";
            toolStripMenuItem3.Click += sellToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(45, 32);
            toolStripMenuItem4.Text = "Send";
            toolStripMenuItem4.Click += sendToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(70, 32);
            toolStripMenuItem5.Text = "Exchange";
            toolStripMenuItem5.Click += exchangeToolStripMenuItem_Click;
            // 
            // viewTransactionToolStripMenuItem
            // 
            viewTransactionToolStripMenuItem.Name = "viewTransactionToolStripMenuItem";
            viewTransactionToolStripMenuItem.Size = new Size(107, 32);
            viewTransactionToolStripMenuItem.Text = "View Transaction";
            viewTransactionToolStripMenuItem.Click += viewTransactionsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem7, toolStripMenuItem8 });
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(64, 32);
            toolStripMenuItem6.Text = "Account";
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(116, 22);
            toolStripMenuItem7.Text = "Settings";
            toolStripMenuItem7.Click += settingsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(116, 22);
            toolStripMenuItem8.Text = "Logout";
            toolStripMenuItem8.Click += logoutToolStripMenuItem1_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 32);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // Send
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(menuStrip2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Send";
            Text = "Send";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
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
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem viewTransactionToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem6;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem adminToolStripMenuItem;
    }
}