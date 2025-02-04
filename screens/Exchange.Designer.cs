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
            logoutToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, buyToolStripMenuItem, sellToolStripMenuItem, sendToolStripMenuItem, exchangeToolStripMenuItem, logoutToolStripMenuItem });
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
            // 
            // exchangeToolStripMenuItem
            // 
            exchangeToolStripMenuItem.Name = "exchangeToolStripMenuItem";
            exchangeToolStripMenuItem.Size = new Size(70, 32);
            exchangeToolStripMenuItem.Text = "Exchange";
            exchangeToolStripMenuItem.Click += exchangeToolStripMenuItem_Click;
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
            // Exchange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(menuStrip1);
            Name = "Exchange";
            Text = "Exchange";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}