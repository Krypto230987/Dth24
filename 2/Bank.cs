using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm24._2
{
    internal class Bank<T> where T : Account
    {
        private List<T> accounts;

        public Bank()
        {
            accounts = new List<T>();
        }

        public void AddAccount(T account)
        {
            accounts.Add(account);
        }

        public void DisplayAccountInformation()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account type: {account.GetType().Name}, Balance: {account.Balance}");
            }
        }

        public decimal TotalBalance()
        {
            decimal total = 0;
            foreach (var account in accounts)
            {
                total += account.Balance;
            }
            return total;
        }


    }
}
