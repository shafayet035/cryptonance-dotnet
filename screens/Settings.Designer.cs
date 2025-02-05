namespace cryptonance.screens
{
    partial class Settings
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
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            txtPassword = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
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
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(460, 126);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 29;
            label1.Text = "Update Profile Information";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserName);
            panel1.Location = new Point(367, 167);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 246);
            panel1.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(29, 174);
            button1.Name = "button1";
            button1.Size = new Size(94, 31);
            button1.TabIndex = 34;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(29, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(269, 23);
            txtPassword.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 108);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 32;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 35);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 31;
            label2.Text = "Username";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(29, 59);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(269, 23);
            txtUserName.TabIndex = 0;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, viewTransactionToolStripMenuItem, toolStripMenuItem6, adminToolStripMenuItem });
            menuStrip2.Location = new Point(0, -1);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1072, 36);
            menuStrip2.TabIndex = 31;
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
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 610);
            Controls.Add(menuStrip2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Settings";
            Text = "Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Button button1;
        private TextBox txtPassword;
        private Label label3;
        private Label label2;
        private TextBox txtUserName;
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