using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PasswordVault.Models;
using System.Security.Cryptography;
using System.Text;

namespace PasswordVault
{
    public partial class RegisterForm : Form
    {
        private readonly string userFilePath = @"D:\Documents\Development\PassworkVault\PasswordVault\PasswordVault\Data";
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
            string passwordEncrypt = Encryption.ComputeSha256Hash(passwordRegTBox.Text);

            if (usernameRegTBox.Text.Length != 0 && passwordRegTBox.Text.Length != 0)
            {

                User user = new()
                {
                    username = usernameRegTBox.Text,
                    password = passwordEncrypt
                };

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(userFilePath, "userDetails.txt"), true))
                {
                    outputFile.WriteLine(user.ToString());
                }
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
