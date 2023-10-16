namespace SimpleLoginSystem.PL.Views
{
    partial class RegisterMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterMenu));
            name = new TextBox();
            logo = new PictureBox();
            username = new TextBox();
            inputGroup = new GroupBox();
            emailIcon = new PictureBox();
            email = new TextBox();
            passwordIcon = new PictureBox();
            password = new TextBox();
            idIcon = new PictureBox();
            id = new TextBox();
            usernameIcon = new PictureBox();
            nameIcon = new PictureBox();
            loginLinkLabel = new LinkLabel();
            haveAnAccountLabel = new Label();
            registerButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            inputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emailIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)idIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nameIcon).BeginInit();
            SuspendLayout();
            // 
            // name
            // 
            name.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(38, 71);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(164, 27);
            name.TabIndex = 2;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(169, 30);
            logo.Name = "logo";
            logo.Size = new Size(90, 90);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 10;
            logo.TabStop = false;
            // 
            // username
            // 
            username.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(38, 107);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(164, 27);
            username.TabIndex = 3;
            // 
            // inputGroup
            // 
            inputGroup.Controls.Add(emailIcon);
            inputGroup.Controls.Add(email);
            inputGroup.Controls.Add(passwordIcon);
            inputGroup.Controls.Add(password);
            inputGroup.Controls.Add(idIcon);
            inputGroup.Controls.Add(id);
            inputGroup.Controls.Add(usernameIcon);
            inputGroup.Controls.Add(nameIcon);
            inputGroup.Controls.Add(username);
            inputGroup.Controls.Add(name);
            inputGroup.Font = new Font("Sigmar One", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            inputGroup.ForeColor = Color.RoyalBlue;
            inputGroup.Location = new Point(96, 135);
            inputGroup.Name = "inputGroup";
            inputGroup.Size = new Size(226, 219);
            inputGroup.TabIndex = 0;
            inputGroup.TabStop = false;
            inputGroup.Text = "Register";
            // 
            // emailIcon
            // 
            emailIcon.Image = (Image)resources.GetObject("emailIcon.Image");
            emailIcon.Location = new Point(13, 183);
            emailIcon.Name = "emailIcon";
            emailIcon.Size = new Size(25, 22);
            emailIcon.SizeMode = PictureBoxSizeMode.Zoom;
            emailIcon.TabIndex = 10;
            emailIcon.TabStop = false;
            // 
            // email
            // 
            email.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(38, 181);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(164, 27);
            email.TabIndex = 5;
            // 
            // passwordIcon
            // 
            passwordIcon.Image = (Image)resources.GetObject("passwordIcon.Image");
            passwordIcon.Location = new Point(17, 149);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(16, 16);
            passwordIcon.SizeMode = PictureBoxSizeMode.Zoom;
            passwordIcon.TabIndex = 8;
            passwordIcon.TabStop = false;
            // 
            // password
            // 
            password.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(38, 144);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(164, 27);
            password.TabIndex = 4;
            password.UseSystemPasswordChar = true;
            // 
            // idIcon
            // 
            idIcon.BackColor = Color.Transparent;
            idIcon.Image = (Image)resources.GetObject("idIcon.Image");
            idIcon.Location = new Point(17, 38);
            idIcon.Name = "idIcon";
            idIcon.Size = new Size(18, 18);
            idIcon.SizeMode = PictureBoxSizeMode.Zoom;
            idIcon.TabIndex = 6;
            idIcon.TabStop = false;
            // 
            // id
            // 
            id.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(38, 34);
            id.Name = "id";
            id.PlaceholderText = "Id";
            id.Size = new Size(164, 27);
            id.TabIndex = 0;
            // 
            // usernameIcon
            // 
            usernameIcon.Image = (Image)resources.GetObject("usernameIcon.Image");
            usernameIcon.Location = new Point(17, 113);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(16, 16);
            usernameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            usernameIcon.TabIndex = 4;
            usernameIcon.TabStop = false;
            // 
            // nameIcon
            // 
            nameIcon.BackColor = Color.Transparent;
            nameIcon.Image = (Image)resources.GetObject("nameIcon.Image");
            nameIcon.Location = new Point(17, 75);
            nameIcon.Name = "nameIcon";
            nameIcon.Size = new Size(18, 18);
            nameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            nameIcon.TabIndex = 3;
            nameIcon.TabStop = false;
            // 
            // loginLinkLabel
            // 
            loginLinkLabel.ActiveLinkColor = Color.DarkSlateBlue;
            loginLinkLabel.AutoSize = true;
            loginLinkLabel.BackColor = Color.Transparent;
            loginLinkLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginLinkLabel.LinkColor = Color.RoyalBlue;
            loginLinkLabel.Location = new Point(187, 491);
            loginLinkLabel.Name = "loginLinkLabel";
            loginLinkLabel.Size = new Size(37, 19);
            loginLinkLabel.TabIndex = 7;
            loginLinkLabel.TabStop = true;
            loginLinkLabel.Text = "Login";
            loginLinkLabel.LinkClicked += loginLinkLabel_LinkClicked;
            // 
            // haveAnAccountLabel
            // 
            haveAnAccountLabel.AutoSize = true;
            haveAnAccountLabel.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            haveAnAccountLabel.Location = new Point(126, 472);
            haveAnAccountLabel.Name = "haveAnAccountLabel";
            haveAnAccountLabel.Size = new Size(148, 19);
            haveAnAccountLabel.TabIndex = 13;
            haveAnAccountLabel.Text = "Already have an account?";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.RoyalBlue;
            registerButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            registerButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Font = new Font("Sigmar One", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(134, 408);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(140, 32);
            registerButton.TabIndex = 6;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            exitButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(385, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(25, 25);
            exitButton.TabIndex = 14;
            exitButton.Text = "x";
            exitButton.UseCompatibleTextRendering = true;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // RegisterMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(422, 567);
            Controls.Add(exitButton);
            Controls.Add(logo);
            Controls.Add(inputGroup);
            Controls.Add(loginLinkLabel);
            Controls.Add(haveAnAccountLabel);
            Controls.Add(registerButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            inputGroup.ResumeLayout(false);
            inputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emailIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)idIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nameIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private PictureBox logo;
        private TextBox username;
        private GroupBox inputGroup;
        private PictureBox usernameIcon;
        private PictureBox nameIcon;
        private LinkLabel loginLinkLabel;
        private Label haveAnAccountLabel;
        private Button registerButton;
        private PictureBox idIcon;
        private TextBox id;
        private PictureBox emailIcon;
        private TextBox email;
        private PictureBox passwordIcon;
        private TextBox password;
        private Button exitButton;
    }
}