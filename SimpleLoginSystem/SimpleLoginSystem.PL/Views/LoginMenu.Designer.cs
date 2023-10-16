namespace SimpleLoginSystem.PL.Views
{
    partial class LoginMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginMenu));
            logo = new PictureBox();
            username = new TextBox();
            password = new TextBox();
            inputGroup = new GroupBox();
            passwordIcon = new PictureBox();
            usernameIcon = new PictureBox();
            loginButton = new Button();
            newAccountLabel = new Label();
            registerLinkLabel = new LinkLabel();
            incorrectCredentials = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            inputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(166, 26);
            logo.Name = "logo";
            logo.Size = new Size(90, 90);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // username
            // 
            username.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(38, 37);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(164, 27);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(38, 78);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(164, 27);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // inputGroup
            // 
            inputGroup.Controls.Add(passwordIcon);
            inputGroup.Controls.Add(usernameIcon);
            inputGroup.Controls.Add(password);
            inputGroup.Controls.Add(username);
            inputGroup.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputGroup.ForeColor = Color.RoyalBlue;
            inputGroup.Location = new Point(87, 161);
            inputGroup.Name = "inputGroup";
            inputGroup.Size = new Size(226, 126);
            inputGroup.TabIndex = 0;
            inputGroup.TabStop = false;
            inputGroup.Text = "Login";
            // 
            // passwordIcon
            // 
            passwordIcon.Image = (Image)resources.GetObject("passwordIcon.Image");
            passwordIcon.Location = new Point(17, 82);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(16, 16);
            passwordIcon.SizeMode = PictureBoxSizeMode.Zoom;
            passwordIcon.TabIndex = 4;
            passwordIcon.TabStop = false;
            // 
            // usernameIcon
            // 
            usernameIcon.BackColor = Color.Transparent;
            usernameIcon.Image = (Image)resources.GetObject("usernameIcon.Image");
            usernameIcon.Location = new Point(17, 41);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(18, 18);
            usernameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            usernameIcon.TabIndex = 3;
            usernameIcon.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.RoyalBlue;
            loginButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            loginButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(137, 367);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(140, 32);
            loginButton.TabIndex = 3;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // newAccountLabel
            // 
            newAccountLabel.AutoSize = true;
            newAccountLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newAccountLabel.Location = new Point(141, 414);
            newAccountLabel.Name = "newAccountLabel";
            newAccountLabel.Size = new Size(133, 19);
            newAccountLabel.TabIndex = 7;
            newAccountLabel.Text = "Don't have an account?";
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.BackColor = Color.Transparent;
            registerLinkLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            registerLinkLabel.LinkColor = Color.RoyalBlue;
            registerLinkLabel.Location = new Point(167, 434);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(77, 19);
            registerLinkLabel.TabIndex = 4;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Register now";
            registerLinkLabel.LinkClicked += registerLinkLabel_LinkClicked;
            // 
            // incorrectCredentials
            // 
            incorrectCredentials.AutoSize = true;
            incorrectCredentials.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            incorrectCredentials.ForeColor = Color.DarkRed;
            incorrectCredentials.Location = new Point(150, 315);
            incorrectCredentials.Name = "incorrectCredentials";
            incorrectCredentials.Size = new Size(117, 18);
            incorrectCredentials.TabIndex = 9;
            incorrectCredentials.Text = "Incorrect credentials!";
            incorrectCredentials.Visible = false;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            exitButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(391, 4);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(25, 25);
            exitButton.TabIndex = 10;
            exitButton.Text = "x";
            exitButton.UseCompatibleTextRendering = true;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // LoginMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(422, 567);
            Controls.Add(exitButton);
            Controls.Add(incorrectCredentials);
            Controls.Add(registerLinkLabel);
            Controls.Add(newAccountLabel);
            Controls.Add(loginButton);
            Controls.Add(inputGroup);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            inputGroup.ResumeLayout(false);
            inputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private TextBox username;
        private TextBox password;
        private GroupBox inputGroup;
        private PictureBox passwordIcon;
        private PictureBox usernameIcon;
        private Button loginButton;
        private Label newAccountLabel;
        private LinkLabel registerLinkLabel;
        private Label incorrectCredentials;
        private Button exitButton;
    }
}