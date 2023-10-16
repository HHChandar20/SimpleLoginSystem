using SimpleLoginSystem.PL.Controllers;
using SimpleLoginSystem.BLL.Services;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SimpleLoginSystem.PL.Views
{
    public partial class MainMenu : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int leftRect,      // x-coordinate of upper-left corner
            int topRect,       // y-coordinate of upper-left corner
            int rightRect,     // x-coordinate of lower-right corner  
            int bottomRect,    // y-coordinate of lower-right corner
            int widthEclipse,  // width of eclipse
            int heightEclipse  // height of eclipse

        );

        private static MainMenu instance;
        private static AccountController controllerInstance = AccountController.GetInstance();
        private static LoginMenu loginMenu = LoginMenu.GetInstance();
        public MainMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            logo.Location = new Point((this.Width / 2) - (logo.Width / 2), (this.Height / 8) - (logo.Height / 2));
            selectOptionGroup.Location = new Point((this.Width / 2) - (selectOptionGroup.Width / 2), (this.Height / 3) - (selectOptionGroup.Height / 2));
            inputPanel.Location = new Point((this.Width / 2) - (inputPanel.Width / 2), this.Height / 2 - id.Height);
            workInProgress.Location = new Point((this.Width / 2) - (workInProgress.Width / 2), this.Height - 2 * workInProgress.Height);

            logOutButton.Location = new Point((this.Width / 2) - (logOutButton.Width / 2), 5 * this.Height / 6);
            deleteButton.Location = new Point((this.Width / 2) - (deleteButton.Width / 2), 5 * this.Height / 6);
            updateButton.Location = new Point((this.Width / 2) - (updateButton.Width / 2), 5 * this.Height / 6);
            exitButton.Location = new Point(9 * this.Width / 10, exitButton.Height / 2);

            accountDataGridView.Location = new Point((this.Width / 2) - (accountDataGridView.Width / 2), (this.Height / 2) - (accountDataGridView.Height / 10));

        }
        public static MainMenu GetInstance()
        {
            if (instance == null)
            {
                instance = new MainMenu();
            }
            return instance;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            accountDataGridView.Visible = false;
            workInProgress.Visible = false;

            logOutButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;

            idIcon.Visible = false;
            nameIcon.Visible = false;
            usernameIcon.Visible = false;
            passwordIcon.Visible = false;
            emailIcon.Visible = false;

            id.Visible = false;
            name.Visible = false;
            username.Visible = false;
            password.Visible = false;
            email.Visible = false;

            switch (selectOption.SelectedIndex)
            {
                case 0:
                    {
                        updateButton.Visible = true;

                        idIcon.Visible = true;
                        nameIcon.Visible = true;
                        usernameIcon.Visible = true;
                        passwordIcon.Visible = true;
                        emailIcon.Visible = true;

                        id.Visible = true;
                        name.Visible = true;
                        username.Visible = true;
                        password.Visible = true;
                        email.Visible = true;

                        break;
                    }
                case 1:
                    {
                        deleteButton.Visible = true;
                        idIcon.Visible = true;
                        id.Visible = true;

                        break;
                    }
                case 2:
                    {
                        LoadCsvIntoDataGridView();
                        accountDataGridView.Visible = true;
                        break;
                    }
                case 3:
                    {
                        logOutButton.Visible = true;
                        break;
                    }
            }
        }
        private void GetLogin()
        {
            loginMenu.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            selectOption.SelectedIndex = -1;
            GetLogin();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                controllerInstance.DeleteAccount(id.Text);

                workInProgress.Text = $"Account {id.Text} deleted!";
                workInProgress.ForeColor = Color.DarkRed;
                workInProgress.Visible = true;
            }
            ClearTextboxes();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && username.Text != "" && name.Text != "" && password.Text != "" && email.Text != "")
            {
                controllerInstance.UpdateAccount(int.Parse(id.Text), name.Text, username.Text, password.Text, email.Text);

                workInProgress.Text = $"Account {id.Text} updated!";
                workInProgress.ForeColor = Color.RoyalBlue;
            }
            else
            {
                workInProgress.Text = "Invalid credentials!";
                workInProgress.ForeColor = Color.DarkRed;
            }

            workInProgress.Visible = true;
            ClearTextboxes();

        }

        private void ClearTextboxes()
        {
            id.Text = "";
            name.Text = "";
            username.Text = "";
            password.Text = "";
            email.Text = "";
        }
        private void LoadCsvIntoDataGridView()
        {
            accountDataGridView.Rows.Clear();

            string[] lines = controllerInstance.ReadFromCsvFile();

            foreach (string line in lines)
            {
                accountDataGridView.Rows.Add(line.Split(','));
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
