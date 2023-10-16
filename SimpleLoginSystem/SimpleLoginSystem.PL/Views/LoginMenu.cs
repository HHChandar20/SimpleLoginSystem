using SimpleLoginSystem.PL.Controllers;
using SimpleLoginSystem.BLL.Services;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace SimpleLoginSystem.PL.Views
{
    public partial class LoginMenu : Form
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

        private static LoginMenu instance;

        public LoginMenu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            logo.Location = new Point((this.Width / 2) - (logo.Width / 2), (this.Height / 8) - (logo.Height / 2));
            inputGroup.Location = new Point((this.Width / 2) - (inputGroup.Width / 2), (this.Height / 3) - (inputGroup.Height / 5));
            loginButton.Location = new Point((this.Width / 2) - (loginButton.Width / 2), 2 * this.Height / 3);
            newAccountLabel.Location = new Point((this.Width / 2) - (newAccountLabel.Width / 2), this.Height - 6 * newAccountLabel.Height);
            registerLinkLabel.Location = new Point((this.Width / 2) - (registerLinkLabel.Width / 2), this.Height - 5 * registerLinkLabel.Height);
            exitButton.Location = new Point(9 * this.Width / 10, exitButton.Height / 2);
        }



        public static LoginMenu GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginMenu();
            }
            return instance;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (username.Text != "" && password.Text != "")
            {
                AccountController controllerInstance = AccountController.GetInstance();

                if (controllerInstance.GetUserCredentials(username.Text, password.Text))
                {
                    MainMenu mainMenu = MainMenu.GetInstance();
                    mainMenu.Show();
                    incorrectCredentials.Visible = false;
                    this.Hide();
                }
                else
                {
                    incorrectCredentials.Visible = true;
                }

                username.Text = "";
                password.Text = "";
            }
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterMenu registerMenu = RegisterMenu.GetInstance();
            registerMenu.Show();
            incorrectCredentials.Visible = false;
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}