using SimpleLoginSystem.BLL.Services;
using System.Windows.Forms.VisualStyles;

namespace SimpleLoginSystem.PL.Controllers
{
    public class AccountController
    {
        private static AccountController instance;
        private static AccountService serviceInstance = AccountService.GetInstance();

        public static AccountController GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountController();
            }

            return instance;
        }

        private AccountController()
        {

        }

        public bool GetUserCredentials(string username, string password)
        {
            if (serviceInstance.VerifyAccount(username, password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateNewAccount(int id, string name, string username, string password, string email)
        {
            serviceInstance.CreateNewAccount(id, name, username, password, email);
        }

        public void UpdateAccount(int id, string name, string username, string password, string email)
        {
            serviceInstance.UpdateAccount(id, name, username, password, email);
        }

        public void DeleteAccount(string id)
        {
            serviceInstance.DeleteAccount(id);
        }
        public string[] ReadFromCsvFile()
        {
            return serviceInstance.ReadCsvFile();
        }

    }
}
