using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PasswordVault.Models;

namespace PasswordVault
{
    public partial class LoginForm : Form
    {
        private readonly string userFilePath = @"D:\Documents\Development\PassworkVault\PasswordVault\PasswordVault\Data\userDetails.txt";
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
            string username = usernameTBox.Text;
            string password = passwordTBox.Text;

            if (SearchFile(userFilePath, username, password))
            {
                this.Hide();
            }
            else
            {
                errorLabel.Visible = true;
            }

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm register = new RegisterForm();
            register.Show();
        }


        private bool SearchFile(string userFile,string username,string password)
        {
            string ePassword = Encryption.ComputeSha256Hash(password);

            foreach( string line in File.ReadAllLines(userFile)){
                if(line.Contains(username) && line.Contains(ePassword))
                {
                    return true;
                }
            };
            return false;
        }



        private void usernameTBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
        private void passwordTBox_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
