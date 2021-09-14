using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01.Day06
{
    abstract class Account
    {
        public override string ToString()
        {
            return $"Account No {AccountNo} ,Name = {Name} , Balanace = {Balance}";
        }
        public double Balance { get; set; } = 5000;
        public string Name { get; set; }
        public int AccountNo { get; set; }

        public void Credit(double amount)
        {
            Balance += amount;
        }

        public void Debit(double amount)
        {
            if(Balance < amount)
            {
                Console.WriteLine("InSufficient Balance!");
            }
            else
            {
                Balance -= amount;
            }
        }

        public abstract void CalculateInterest();  
        
       
    }

    class SBAccount : Account
    {
        public override void CalculateInterest()
        {
            double principal = Balance;
            double rate = 7 / 100;
            double term = 0.25;
            double interest = principal * rate * term;
            Credit(interest);
        }
    }

    class FDAccount : Account
    {
        public override void CalculateInterest()
        {
            int term = 5 * 12;
            double rate = 7.5 / 100;
            double MonthlyPayment = 5000;
            double interest = term * rate * MonthlyPayment;
            Credit(interest);
        }
    }

    class RDAccount : Account
    {
        public override void CalculateInterest()
        {
            int term = 5;
            double rate = 8.5 / 100;
            double fixedAmount = Balance;
            double interest = term * rate * fixedAmount;
            Credit(interest);
        }
    }

    enum AccountType
    {
        SBA,FDA,RDA
    }
    static class AccountManager
    {
        public static Account CreateAccount(AccountType type)
        {
            Account acc = null;
            switch (type)
            {
                case AccountType.SBA:
                    acc = new SBAccount();
                    break;
                case AccountType.FDA:
                    acc = new FDAccount();
                    break;
                case AccountType.RDA:
                    acc = new RDAccount();
                    break;
                default:
                    Console.WriteLine("Not a valid Account Type!");
                    return acc;
            }
            return acc;
        }
    }
    class AssignmentOnAbstract
    {
        Account[] accounts = new Account[10];

        public virtual void AddNewAccount(Account acc)
        {
            //Using for loop, find the first occurance of null in the array and set the value in that location.
            //Immediately exit the function after the setting is done. Else U can continue the loop.

            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = acc;
                    return;
                }
                else continue;
                //Account acc = Helper();
                //accounts[i] = acc;
            }
        }

        public virtual void DeleteAccount(int id)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if((accounts[i] != null) && (accounts[i].AccountNo==id))
                {
                    accounts[i] = null;
                    return;
                }
            }
        }

        public virtual void UpdateAccount(Account acc)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if ((accounts[i] != null) && (accounts[i].AccountNo == acc.AccountNo))
                {
                    accounts[i] = acc;
                    return;
                }
               
            }
        }

        public virtual Account[] GetAllAccounts()
        {
            return accounts;
        }
       
        
    }

    class UIApp
    {
        const string menu = "----------BANKING APP--------------------\nTO ADD ACCOUNT--------->PRESS 1\nTO DELETE ACCOUNT------------->PRESS 2\nTO UPDATE ACCOUNT-------->PRESS 3\nTO FIND ACCOUNT DETAILS---->PRESS 4\n";

        static AssignmentOnAbstract app = new AssignmentOnAbstract();
        static void Main(string[] args)
        {
            bool processing = true;
            do
            {
                intialize();
                var choice = HelperClass.GetNumber(menu);
                processing = ProcessMenu(choice);
            } while (processing);
            Console.ReadLine();
        }

        private static void intialize()
        {
            app.AddNewAccount(new SBAccount { AccountNo = 123, Name = "Madan" });
            app.AddNewAccount(new SBAccount { AccountNo = 345, Name = "Suresh" });
            app.AddNewAccount(new SBAccount { AccountNo = 768, Name = "Raj" });
            app.AddNewAccount(new SBAccount { AccountNo = 856, Name = "Sam" });
            app.AddNewAccount(new SBAccount { AccountNo = 987, Name = "Suri" });
        }

        private static bool ProcessMenu(uint choice)
        {
            switch (choice)
            {
                case 1:
                    addAccountDetails();
                    return true;
                case 2:
                    deletingFunc();
                    return true;
                case 3:
                    updateAccountDetails();
                    return true;
                case 4:
                    findingAccount();
                    return true;
               
            }
            return false;
        }

        private static void findingAccount()
        {
            var records = app.GetAllAccounts();
            var name = HelperClass.GetString("Enter The Name or partial name to find in our Accounts!!");
            foreach (var record in records)
            {
                if(record !=null && record.Name.Contains(name))
                {
                    Console.WriteLine(record.ToString());
                }
            }
        }

        private static void updateAccountDetails()
        {
            int id = (int)HelperClass.GetNumber("Enter Id Of Account No For Update Account");
            //app.UpdateAccount(id);
        }

        private static void deletingFunc()
        {
            int id = (int)HelperClass.GetNumber("Enter Id Of Account No For Remove");
            app.DeleteAccount(id);
            Console.WriteLine("The Account With Id {0} is deleted from the database",id);
        }

        static void addAccountDetails()
        {
            Console.WriteLine("Enter the Type Of Account You Want to Create SBA , FDA and RDA");
            var type = (AccountType)Enum.Parse(typeof(AccountType), Console.ReadLine());
            var acc = AccountManager.CreateAccount(type);
            acc.AccountNo = (int)HelperClass.GetNumber("Enter Account No For This Customer");
            acc.Name = HelperClass.GetString("Enter Name");
            double amount = HelperClass.GetNumber("Enter Initial Amount for deposit: ");
            acc.Credit(amount);
            app.AddNewAccount(acc);
            Console.WriteLine("The Account of the type {0} is added to the Database",type);
        }
    }
}

