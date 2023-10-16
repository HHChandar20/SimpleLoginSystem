using SimpleLoginSystem.DAL.Repositories;
using SimpleLoginSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginSystem.BLL.Services
{
    public class AccountService
    {
        private static AccountService instance = null;
        private static AccountRepository repositoryInstance = AccountRepository.GetInstance();

        public static AccountService GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountService();
            }

            return instance;
        }

        private AccountService()
        {

        }

        public List<Account> GetAccounts()
        {
            return repositoryInstance.GetAccounts();
        }

        public Account GetAccount(int id)
        {
            return repositoryInstance.GetAccountById(id);
        }

        public void CreateAccount(Account newAccount)
        {
            repositoryInstance.AddAccount(newAccount);
        }

        public void UpdateAccount(int id, string name, string username, string password, string email)
        {
            repositoryInstance.UpdateAccount(id, name, username, password, email);
        }

        public void DeleteAccount(string id)
        {
            repositoryInstance.DeleteAccount(id);
        }

        public bool VerifyAccount(string username, string password)
        {
            List<Account> accounts = GetAccounts();

            foreach (Account account in accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public void CreateNewAccount(int id, string name, string username, string password, string email)
        {
            CreateAccount(ConvertAccount(id, name, username, password, email));
        }

        public static Account ConvertAccount(int id, string name, string username, string password, string email)
        {
            Account account = new Account();

            account.Id = id;
            account.Name = name;
            account.Username = username;
            account.Password = password;
            account.Email = email;

            return account;
        }

        public string[] ReadCsvFile()
        {
            return repositoryInstance.ReadCsvFile();
        }
    }
}
