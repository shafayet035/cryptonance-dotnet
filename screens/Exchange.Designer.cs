namespace cryptonance.screens
{
    partial class Exchange
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
            ltcbtc = new Label();
            ltceth = new Label();
            ethltc = new Label();
            ethbtc = new Label();
            btcltc = new Label();
            btceth = new Label();
            exchangerate = new Label();
            exchangeb = new Button();
            lblExchange = new Label();
            amount = new Label();
            to = new Label();
            from = new Label();
            tobox = new ComboBox();
            frombox = new ComboBox();
            amountbox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label10 = new Label();
            label6 = new Label();
            label9 = new Label();
            label7 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel3 = new Panel();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, buyToolStripMenuItem, sellToolStripMenuItem, sendToolStripMenuItem, exchangeToolStripMenuItem, viewTransactionToolStripMenuItem, logoutToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1072, 36);
            menuStrip1.TabIndex = 27;
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
            settingsToolStripMenuItem.Size = new Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem1
            // 
            logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            logoutToolStripMenuItem1.Size = new Size(116, 22);
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
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ltcbtc);
            panel1.Controls.Add(ltceth);
            panel1.Controls.Add(ethltc);
            panel1.Controls.Add(ethbtc);
            panel1.Controls.Add(btcltc);
            panel1.Controls.Add(btceth);
            panel1.Controls.Add(exchangerate);
            panel1.Location = new Point(107, 283);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 205);
            panel1.TabIndex = 41;
            // 
            // ltcbtc
            // 
            ltcbtc.AutoSize = true;
            ltcbtc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ltcbtc.Location = new Point(39, 173);
            ltcbtc.Margin = new Padding(4, 0, 4, 0);
            ltcbtc.Name = "ltcbtc";
            ltcbtc.Size = new Size(134, 20);
            ltcbtc.TabIndex = 23;
            ltcbtc.Text = "1 LTC = 0.14 BTC";
            // 
            // ltceth
            // 
            ltceth.AutoSize = true;
            ltceth.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ltceth.Location = new Point(38, 134);
            ltceth.Margin = new Padding(4, 0, 4, 0);
            ltceth.Name = "ltceth";
            ltceth.Size = new Size(135, 20);
            ltceth.TabIndex = 22;
            ltceth.Text = "1 LTC = 0.45 ETH";
            // 
            // ethltc
            // 
            ethltc.AutoSize = true;
            ethltc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ethltc.Location = new Point(211, 91);
            ethltc.Margin = new Padding(4, 0, 4, 0);
            ethltc.Name = "ethltc";
            ethltc.Size = new Size(135, 20);
            ethltc.TabIndex = 21;
            ethltc.Text = "1 ETH = 2.46 LTC";
            // 
            // ethbtc
            // 
            ethbtc.AutoSize = true;
            ethbtc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ethbtc.Location = new Point(211, 59);
            ethbtc.Margin = new Padding(4, 0, 4, 0);
            ethbtc.Name = "ethbtc";
            ethbtc.Size = new Size(137, 20);
            ethbtc.TabIndex = 17;
            ethbtc.Text = "1 ETH = 0.47 BTC";
            // 
            // btcltc
            // 
            btcltc.AutoSize = true;
            btcltc.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btcltc.Location = new Point(36, 95);
            btcltc.Margin = new Padding(4, 0, 4, 0);
            btcltc.Name = "btcltc";
            btcltc.Size = new Size(134, 20);
            btcltc.TabIndex = 16;
            btcltc.Text = "1 BTC = 5.78 LTC";
            // 
            // btceth
            // 
            btceth.AutoSize = true;
            btceth.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btceth.Location = new Point(36, 61);
            btceth.Margin = new Padding(4, 0, 4, 0);
            btceth.Name = "btceth";
            btceth.Size = new Size(137, 20);
            btceth.TabIndex = 15;
            btceth.Text = "1 BTC = 2.36 ETH";
            // 
            // exchangerate
            // 
            exchangerate.AutoSize = true;
            exchangerate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exchangerate.Location = new Point(36, 21);
            exchangerate.Margin = new Padding(4, 0, 4, 0);
            exchangerate.Name = "exchangerate";
            exchangerate.Size = new Size(120, 16);
            exchangerate.TabIndex = 14;
            exchangerate.Text = "Exchange Rates";
            // 
            // exchangeb
            // 
            exchangeb.BackColor = Color.FromArgb(192, 255, 192);
            exchangeb.Location = new Point(38, 290);
            exchangeb.Margin = new Padding(4, 3, 4, 3);
            exchangeb.Name = "exchangeb";
            exchangeb.Size = new Size(99, 35);
            exchangeb.TabIndex = 36;
            exchangeb.Text = "Exchange";
            exchangeb.UseVisualStyleBackColor = false;
            exchangeb.Click += exchangeb_Click;
            // 
            // lblExchange
            // 
            lblExchange.AutoSize = true;
            lblExchange.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExchange.Location = new Point(38, 255);
            lblExchange.Margin = new Padding(4, 0, 4, 0);
            lblExchange.Name = "lblExchange";
            lblExchange.Size = new Size(113, 16);
            lblExchange.TabIndex = 35;
            lblExchange.Text = "You will recieve: 0";
            // 
            // amount
            // 
            amount.AutoSize = true;
            amount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amount.Location = new Point(38, 115);
            amount.Margin = new Padding(4, 0, 4, 0);
            amount.Name = "amount";
            amount.Size = new Size(65, 20);
            amount.TabIndex = 34;
            amount.Text = "Amount";
            // 
            // to
            // 
            to.AutoSize = true;
            to.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            to.Location = new Point(38, 178);
            to.Margin = new Padding(4, 0, 4, 0);
            to.Name = "to";
            to.Size = new Size(27, 20);
            to.TabIndex = 33;
            to.Text = "To";
            // 
            // from
            // 
            from.AutoSize = true;
            from.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            from.Location = new Point(38, 44);
            from.Margin = new Padding(4, 0, 4, 0);
            from.Name = "from";
            from.Size = new Size(46, 20);
            from.TabIndex = 32;
            from.Text = "From";
            from.Click += from_Click;
            // 
            // tobox
            // 
            tobox.FormattingEnabled = true;
            tobox.Items.AddRange(new object[] { "BTC", "LTC", "ETH" });
            tobox.Location = new Point(38, 201);
            tobox.Margin = new Padding(4, 3, 4, 3);
            tobox.Name = "tobox";
            tobox.Size = new Size(277, 23);
            tobox.TabIndex = 31;
            tobox.SelectedIndexChanged += tobox_SelectedIndexChanged;
            // 
            // frombox
            // 
            frombox.FormattingEnabled = true;
            frombox.Items.AddRange(new object[] { "BTC", "LTC", "ETH" });
            frombox.Location = new Point(38, 67);
            frombox.Margin = new Padding(4, 3, 4, 3);
            frombox.Name = "frombox";
            frombox.Size = new Size(277, 23);
            frombox.TabIndex = 30;
            frombox.SelectedIndexChanged += frombox_SelectedIndexChanged;
            // 
            // amountbox
            // 
            amountbox.Location = new Point(38, 138);
            amountbox.Margin = new Padding(4, 3, 4, 3);
            amountbox.Name = "amountbox";
            amountbox.Size = new Size(277, 23);
            amountbox.TabIndex = 29;
            amountbox.TextChanged += amountbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(403, 147);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Location = new Point(107, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(436, 172);
            panel2.TabIndex = 42;
            panel2.Paint += panel2_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(60, 60);
            label8.Name = "label8";
            label8.Size = new Size(36, 20);
            label8.TabIndex = 13;
            label8.Text = "0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(60, 120);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 15;
            label10.Text = "0.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 19);
            label6.Name = "label6";
            label6.Size = new Size(211, 25);
            label6.TabIndex = 9;
            label6.Text = "Your'e Current Balance";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(60, 90);
            label9.Name = "label9";
            label9.Size = new Size(36, 20);
            label9.TabIndex = 14;
            label9.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(26, 60);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 10;
            label7.Text = "BTC";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(26, 90);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 11;
            label11.Text = "LTC";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(26, 120);
            label12.Name = "label12";
            label12.Size = new Size(36, 20);
            label12.TabIndex = 12;
            label12.Text = "ETH";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Window;
            panel3.Controls.Add(from);
            panel3.Controls.Add(amountbox);
            panel3.Controls.Add(frombox);
            panel3.Controls.Add(exchangeb);
            panel3.Controls.Add(tobox);
            panel3.Controls.Add(lblExchange);
            panel3.Controls.Add(to);
            panel3.Controls.Add(amount);
            panel3.Location = new Point(574, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 383);
            panel3.TabIndex = 43;
            // 
            // Exchange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Name = "Exchange";
            Text = "Exchange";
            Load += Exchange_Load;
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
        private ToolStripMenuItem sellToolStripMenuItem;
        private ToolStripMenuItem sendToolStripMenuItem;
        private ToolStripMenuItem exchangeToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem1;
        private Panel panel1;
        private Label ltcbtc;
        private Label ltceth;
        private Label ethltc;
        private Label ethbtc;
        private Label btcltc;
        private Label btceth;
        private Label exchangerate;
        private Button exchangeb;
        private Label lblExchange;
        private Label amount;
        private Label to;
        private Label from;
        private ComboBox tobox;
        private ComboBox frombox;
        private TextBox amountbox;
        private Label label1;
        private Panel panel2;
        private Label label8;
        private Label label10;
        private Label label6;
        private Label label9;
        private Label label7;
        private Label label11;
        private Label label12;
        private ToolStripMenuItem viewTransactionToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private Panel panel3;
    }
}