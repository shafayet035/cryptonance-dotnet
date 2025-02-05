using cryptonance.screens;
using cryptonance.services;
using cryptonance.state;

namespace cryptonance
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("All fields are required");
                return;
            }

            Auth auth = new Auth();

            bool userExist = auth.Login(txtEmail.Text, txtPassword.Text);

            if (userExist)
            {
                MessageBox.Show("User logged in successfully");
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            register reg = new register();
            reg.Show();
            this.Hide();
            this.ResumeLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
