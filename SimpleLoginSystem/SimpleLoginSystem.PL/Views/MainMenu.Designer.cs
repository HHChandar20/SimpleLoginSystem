namespace SimpleLoginSystem.PL.Views
{
    partial class MainMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            logo = new PictureBox();
            selectOption = new ComboBox();
            selectOptionGroup = new GroupBox();
            logOutButton = new Button();
            idIcon = new PictureBox();
            id = new TextBox();
            deleteButton = new Button();
            updateButton = new Button();
            workInProgress = new Label();
            inputPanel = new Panel();
            email = new TextBox();
            password = new TextBox();
            username = new TextBox();
            name = new TextBox();
            emailIcon = new PictureBox();
            passwordIcon = new PictureBox();
            usernameIcon = new PictureBox();
            nameIcon = new PictureBox();
            accountServiceBindingSource = new BindingSource(components);
            accountDataGridView = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            selectOptionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)idIcon).BeginInit();
            inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)emailIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nameIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountDataGridView).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(160, 24);
            logo.Name = "logo";
            logo.Size = new Size(90, 90);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // selectOption
            // 
            selectOption.BackColor = Color.White;
            selectOption.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            selectOption.ForeColor = SystemColors.ControlText;
            selectOption.FormattingEnabled = true;
            selectOption.Items.AddRange(new object[] { "Update Account", "Delete Account", "Show Accounts", "Logout" });
            selectOption.Location = new Point(51, 41);
            selectOption.Name = "selectOption";
            selectOption.Size = new Size(121, 31);
            selectOption.TabIndex = 0;
            selectOption.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // selectOptionGroup
            // 
            selectOptionGroup.Controls.Add(selectOption);
            selectOptionGroup.Font = new Font("Sigmar One", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            selectOptionGroup.ForeColor = Color.RoyalBlue;
            selectOptionGroup.Location = new Point(91, 155);
            selectOptionGroup.Name = "selectOptionGroup";
            selectOptionGroup.Size = new Size(226, 80);
            selectOptionGroup.TabIndex = 3;
            selectOptionGroup.TabStop = false;
            selectOptionGroup.Text = "Select Option";
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.RoyalBlue;
            logOutButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            logOutButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            logOutButton.FlatStyle = FlatStyle.Popup;
            logOutButton.Font = new Font("Sigmar One", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.ForeColor = Color.White;
            logOutButton.Location = new Point(133, 455);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(140, 32);
            logOutButton.TabIndex = 6;
            logOutButton.Text = "LOG OUT";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Visible = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // idIcon
            // 
            idIcon.BackColor = Color.Transparent;
            idIcon.Image = (Image)resources.GetObject("idIcon.Image");
            idIcon.Location = new Point(34, 33);
            idIcon.Name = "idIcon";
            idIcon.Size = new Size(18, 18);
            idIcon.SizeMode = PictureBoxSizeMode.Zoom;
            idIcon.TabIndex = 8;
            idIcon.TabStop = false;
            idIcon.Visible = false;
            // 
            // id
            // 
            id.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id.Location = new Point(55, 28);
            id.Name = "id";
            id.PlaceholderText = "Id";
            id.Size = new Size(121, 27);
            id.TabIndex = 1;
            id.Visible = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.RoyalBlue;
            deleteButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            deleteButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Sigmar One", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(133, 455);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 32);
            deleteButton.TabIndex = 6;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.RoyalBlue;
            updateButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            updateButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Sigmar One", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(133, 455);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(140, 32);
            updateButton.TabIndex = 25;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Visible = false;
            updateButton.Click += updateButton_Click;
            // 
            // workInProgress
            // 
            workInProgress.AutoSize = true;
            workInProgress.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            workInProgress.ForeColor = Color.DarkRed;
            workInProgress.Location = new Point(152, 507);
            workInProgress.Name = "workInProgress";
            workInProgress.Size = new Size(94, 18);
            workInProgress.TabIndex = 11;
            workInProgress.Text = "Work in progress!";
            workInProgress.Visible = false;
            // 
            // inputPanel
            // 
            inputPanel.BackColor = Color.Transparent;
            inputPanel.Controls.Add(email);
            inputPanel.Controls.Add(password);
            inputPanel.Controls.Add(username);
            inputPanel.Controls.Add(name);
            inputPanel.Controls.Add(emailIcon);
            inputPanel.Controls.Add(passwordIcon);
            inputPanel.Controls.Add(usernameIcon);
            inputPanel.Controls.Add(nameIcon);
            inputPanel.Controls.Add(idIcon);
            inputPanel.Controls.Add(id);
            inputPanel.Location = new Point(350, 374);
            inputPanel.Name = "inputPanel";
            inputPanel.Size = new Size(226, 192);
            inputPanel.TabIndex = 13;
            // 
            // email
            // 
            email.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(55, 148);
            email.Name = "email";
            email.PlaceholderText = "New Email";
            email.Size = new Size(121, 27);
            email.TabIndex = 5;
            email.Visible = false;
            // 
            // password
            // 
            password.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(55, 118);
            password.Name = "password";
            password.PlaceholderText = "New Password";
            password.Size = new Size(121, 27);
            password.TabIndex = 4;
            password.Visible = false;
            // 
            // username
            // 
            username.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.Location = new Point(55, 88);
            username.Name = "username";
            username.PlaceholderText = "New Username";
            username.Size = new Size(121, 27);
            username.TabIndex = 3;
            username.Visible = false;
            // 
            // name
            // 
            name.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(55, 58);
            name.Name = "name";
            name.PlaceholderText = "New Name";
            name.Size = new Size(121, 27);
            name.TabIndex = 2;
            name.Visible = false;
            // 
            // emailIcon
            // 
            emailIcon.Image = (Image)resources.GetObject("emailIcon.Image");
            emailIcon.Location = new Point(30, 150);
            emailIcon.Name = "emailIcon";
            emailIcon.Size = new Size(25, 22);
            emailIcon.SizeMode = PictureBoxSizeMode.Zoom;
            emailIcon.TabIndex = 20;
            emailIcon.TabStop = false;
            emailIcon.Visible = false;
            // 
            // passwordIcon
            // 
            passwordIcon.Image = (Image)resources.GetObject("passwordIcon.Image");
            passwordIcon.Location = new Point(35, 123);
            passwordIcon.Name = "passwordIcon";
            passwordIcon.Size = new Size(16, 16);
            passwordIcon.SizeMode = PictureBoxSizeMode.Zoom;
            passwordIcon.TabIndex = 19;
            passwordIcon.TabStop = false;
            passwordIcon.Visible = false;
            // 
            // usernameIcon
            // 
            usernameIcon.Image = (Image)resources.GetObject("usernameIcon.Image");
            usernameIcon.Location = new Point(35, 94);
            usernameIcon.Name = "usernameIcon";
            usernameIcon.Size = new Size(16, 16);
            usernameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            usernameIcon.TabIndex = 16;
            usernameIcon.TabStop = false;
            usernameIcon.Visible = false;
            // 
            // nameIcon
            // 
            nameIcon.BackColor = Color.Transparent;
            nameIcon.Image = (Image)resources.GetObject("nameIcon.Image");
            nameIcon.Location = new Point(34, 63);
            nameIcon.Name = "nameIcon";
            nameIcon.Size = new Size(18, 18);
            nameIcon.SizeMode = PictureBoxSizeMode.Zoom;
            nameIcon.TabIndex = 13;
            nameIcon.TabStop = false;
            nameIcon.Visible = false;
            // 
            // accountServiceBindingSource
            // 
            accountServiceBindingSource.DataSource = typeof(BLL.Services.AccountService);
            // 
            // accountDataGridView
            // 
            accountDataGridView.AllowUserToAddRows = false;
            accountDataGridView.AllowUserToDeleteRows = false;
            accountDataGridView.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            accountDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            accountDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            accountDataGridView.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGray;
            dataGridViewCellStyle2.Font = new Font("Bahnschrift Condensed", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            accountDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            accountDataGridView.GridColor = Color.Gray;
            accountDataGridView.Location = new Point(301, 12);
            accountDataGridView.Name = "accountDataGridView";
            accountDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            accountDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            accountDataGridView.RowHeadersWidth = 10;
            accountDataGridView.RowTemplate.Height = 25;
            accountDataGridView.Size = new Size(389, 285);
            accountDataGridView.TabIndex = 14;
            accountDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Name";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Username";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Password";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Email";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.FlatAppearance.BorderColor = Color.LightSteelBlue;
            exitButton.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = Color.White;
            exitButton.Location = new Point(385, 9);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(25, 25);
            exitButton.TabIndex = 26;
            exitButton.Text = "x";
            exitButton.UseCompatibleTextRendering = true;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(422, 567);
            Controls.Add(exitButton);
            Controls.Add(accountDataGridView);
            Controls.Add(inputPanel);
            Controls.Add(workInProgress);
            Controls.Add(updateButton);
            Controls.Add(deleteButton);
            Controls.Add(logOutButton);
            Controls.Add(selectOptionGroup);
            Controls.Add(logo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            selectOptionGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)idIcon).EndInit();
            inputPanel.ResumeLayout(false);
            inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)emailIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)usernameIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nameIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox logo;
        private ComboBox selectOption;
        private GroupBox selectOptionGroup;
        private Button logOutButton;
        private PictureBox idIcon;
        private TextBox id;
        private Button deleteButton;
        private Button updateButton;
        private Label workInProgress;
        private Panel inputPanel;
        private TextBox email;
        private TextBox password;
        private TextBox username;
        private TextBox name;
        private PictureBox emailIcon;
        private PictureBox passwordIcon;
        private PictureBox usernameIcon;
        private PictureBox nameIcon;
        private BindingSource accountServiceBindingSource;
        private DataGridView accountDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Button exitButton;
    }
}