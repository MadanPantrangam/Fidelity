using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day05
{

     class Account
    {
        public long AccountNo { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        public void Credit(double amount)
        {
            Balance = +amount;
        }

        public void Debit(double amount)
        {
            if(Balance < amount)
            {
                Console.WriteLine("Insufficint Balance!");
            }
            else
            {
                Balance -= amount;
            }
        }
    }

    class SBAccount : Account
    {

    }

    class FDAccount : Account
    {

    }

    class RDAccount : Account 
    {

    }

    static class AccountManager
    {
        public static Account CreateAccount(string AccType)
        {
            Account acc = null;
            switch (AccType)
            {
                case "SBA":
                    acc = new SBAccount();
                    break;
                case "FDA":
                    acc = new FDAccount();
                    break;
                case "RDA":
                    acc = new RDAccount();
                    break;
                default:
                    Console.WriteLine("Not a valid Account Type!");
                    return acc;
            }
            return acc;
        }
    }


    class AssignmentOnMethodOverriding
    {
        static void Main(string[] args)
        {
            
            Account[] account = new Account[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Tell me Which Type of Account You Want : SBAccount or FDAccount or RDAccount ");
                string accountType = Console.ReadLine();

                Account obj = AccountManager.CreateAccount(accountType);
                Account account1 = Helper();
                account[i] = account1;
            }


            foreach (var item in account)
            {
                Console.WriteLine($" Account No : {item.AccountNo}  Name : {item.Name}  Balance : {item.Balance}");
                Console.WriteLine("============================");
            }

            Console.ReadLine();
            
        }

        public static Account Helper()
        {
            Account account = new Account();
            Console.WriteLine("Enter Account No : ");
            account.AccountNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name : ");
            account.Name = Console.ReadLine();
            Console.WriteLine("Enter Minimum balance : ");
            account.Balance = double.Parse(Console.ReadLine());
            return account;
        }
    }
}
