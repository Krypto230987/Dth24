using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homm24._2
{
    class Program
    {
        static void Main()
        {
            Bank<DepositAccount> bank = new Bank<DepositAccount>();
            bank.AddAccount(new DepositAccount { Balance = 1000 });
            bank.AddAccount(new DepositAccount { Balance = 1500 });

            bank.DisplayAccountInformation();
            Console.WriteLine($"Total balance: {bank.TotalBalance()}");
            Console.ReadLine();
        }
    }
    public class DepositAccount : Account
    {

    }
}
