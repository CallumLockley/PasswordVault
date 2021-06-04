using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            errorLabel.Visible = false;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(usernameRegTBox.Text.Length != 0 && passwordRegTBox.Text.Length != 0)
            {
                this.Hide();
                LoginForm login = new();
                login.Show();
            }
            else
            {
                usernameRegTBox.Clear();
                passwordRegTBox.Clear();
                errorLabel.Visible = true;
            }
        }

        private void usernameRegTBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
        private void passwordRegTBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
