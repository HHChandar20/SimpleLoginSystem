using SimpleLoginSystem.PL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleLoginSystem.PL.Views
{
    public partial class RegisterMenu : Form
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

        private static RegisterMenu instance;

        public RegisterMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            logo.Location = new Point((this.Width / 2) - (logo.Width / 2), (this.Height / 8) - (logo.Height / 2));
            inputGroup.Location = new Point((this.Width / 2) - (inputGroup.Width / 2), (this.Height / 3) - (inputGroup.Height / 5));
            registerButton.Location = new Point((this.Width / 2) - (registerButton.Width / 2), 3 * this.Height / 4);
            haveAnAccountLabel.Location = new Point((this.Width / 2) - (haveAnAccountLabel.Width / 2), this.Height - 3 * haveAnAccountLabel.Height);
            loginLinkLabel.Location = new Point((this.Width / 2) - (loginLinkLabel.Width / 2), this.Height - 2 * loginLinkLabel.Height);
            exitButton.Location = new Point(9 * this.Width / 10, exitButton.Height / 2);
        }
        public static RegisterMenu GetInstance()
        {
            if (instance == null)
            {
                instance = new RegisterMenu();
            }
            return instance;
        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetLogin();
        }

        private void GetLogin()
        {
            LoginMenu loginMenu = LoginMenu.GetInstance();
            loginMenu.Show();
            this.Hide();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (id.Text != "" && username.Text != "" && name.Text != "" && password.Text != "" && email.Text != "")
            {
                AccountController controllerInstance = AccountController.GetInstance();

                controllerInstance.CreateNewAccount(int.Parse(id.Text), name.Text, username.Text, password.Text, email.Text);

                id.Text = "";
                username.Text = "";
                name.Text = "";
                password.Text = "";
                email.Text = "";

                GetLogin();

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
