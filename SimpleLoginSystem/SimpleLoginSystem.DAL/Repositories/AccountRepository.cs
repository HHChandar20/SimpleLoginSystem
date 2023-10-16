using SimpleLoginSystem.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoginSystem.DAL.Repositories
{
    public class AccountRepository
    {
        private static AccountRepository instance = null;

        private List<Account> accountsList = GetAccountsFromFile();

        public static AccountRepository GetInstance()
        {
            if(instance == null)
            {
                instance = new AccountRepository();
            }

            return instance;
        }

        private AccountRepository()
        {

        }

        private static string filePath = @"..\..\..\..\SimpleLoginSystem.DAL\Data\MOCK_DATA.csv";

        private static List<Account> GetAccountsFromFile()
        {
            StreamReader reader = new StreamReader(File.OpenRead(filePath));

            List<Account> accounts = new List<Account>();

            while (!reader.EndOfStream)
            {
                Account account = new Account();

                string line = reader.ReadLine();

                string[] lineArray = line.Split(",");

                account.Id = int.Parse(lineArray[0]);
                account.Name = lineArray[1].ToString();
                account.Username = lineArray[2].ToString();
                account.Password = lineArray[3].ToString();
                account.Email = lineArray[4].ToString();

                accounts.Add(account);
            }

            reader.Close();

            return accounts;
        }

        // Read multiple
        public List<Account> GetAccounts()
        {
            return accountsList;
        }

        // Read single
        public Account GetAccountById(int id)
        {
            return accountsList.Find(account => account.Id == id);
        }

        // Create
        public void AddAccount(Account newAccount)
        {
            accountsList.Add(newAccount);

            File.AppendAllText(filePath, '\n' + newAccount.ToString());
        }

        // Update
        public void UpdateAccount(int id, string name, string username, string password, string email)
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith(id + ","))
                {
                    lines[i] = id.ToString() + ',' + name + ',' + username + ',' + password + ',' + email;
                }
            }

            File.WriteAllLines(filePath, lines);
        }

        // Delete
        public void DeleteAccount(string id)
        {
            string[] lines = File.ReadAllLines(filePath);

            lines = lines.Where(line => !line.StartsWith(id + ",")).ToArray();

            File.WriteAllLines(filePath, lines);
        }

        public string[] ReadCsvFile()
        {
            string[] lines = File.ReadAllLines(filePath);

            return lines;
        }
    }
}
