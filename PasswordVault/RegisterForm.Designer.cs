
namespace PasswordVault
{
    partial class RegisterForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.passwordRegTBox = new System.Windows.Forms.TextBox();
            this.usernameRegTBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(36, 228);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 14;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(20, 61);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(60, 15);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(117, 228);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 12;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(69, 195);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(92, 15);
            this.errorLabel.TabIndex = 11;
            this.errorLabel.Text = "Please try again.";
            this.errorLabel.Visible = false;
            // 
            // passwordRegTBox
            // 
            this.passwordRegTBox.Location = new System.Drawing.Point(20, 169);
            this.passwordRegTBox.MaxLength = 100;
            this.passwordRegTBox.Name = "passwordRegTBox";
            this.passwordRegTBox.PasswordChar = '*';
            this.passwordRegTBox.Size = new System.Drawing.Size(189, 23);
            this.passwordRegTBox.TabIndex = 10;
            this.passwordRegTBox.TextChanged += new System.EventHandler(this.passwordRegTBox_TextChanged);

            // 
            // usernameRegTBox
            // 
            this.usernameRegTBox.Location = new System.Drawing.Point(20, 89);
            this.usernameRegTBox.MaxLength = 100;
            this.usernameRegTBox.Name = "usernameRegTBox";
            this.usernameRegTBox.Size = new System.Drawing.Size(189, 23);
            this.usernameRegTBox.TabIndex = 9;
            this.usernameRegTBox.TextChanged += new System.EventHandler(this.usernameRegTBox_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(20, 141);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLabel.Location = new System.Drawing.Point(79, 23);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(67, 21);
            this.WelcomeLabel.TabIndex = 15;
            this.WelcomeLabel.Text = "Register";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 273);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordRegTBox);
            this.Controls.Add(this.usernameRegTBox);
            this.Controls.Add(this.passwordLabel);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label errorLabel;        private System.Windows.Forms.TextBox usernameRegTBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordRegTBox;
        private System.Windows.Forms.Label WelcomeLabel;
    }
}