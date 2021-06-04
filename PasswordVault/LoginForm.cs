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
    public partial class LoginForm : Form
    {
        private string userFilePath = @"D:\Documents\Development\PassworkVault\PasswordVault\PasswordVault\Data\userDetails.txt";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usernameTBox.Clear();
            passwordTBox.Clear();
            errorLabel.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userDetails = System.IO.File.ReadAllText(userFilePath);
            if (userDetails.Contains(usernameTBox.Text))
            {
                if (userDetails.Contains(passwordTBox.Text)){
                    Console.WriteLine("Foudn user- ", usernameTBox.Text + " " + passwordTBox.Text);
                }
                
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }
    }
}
