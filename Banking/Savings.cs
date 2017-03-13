using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    class Savings : Account
    {
        static List<string> savingsTransactions = new List<string>();//Fields------------------------------------------
        public static decimal savingsWithdrawalFee = 20.00m;
        public static string accountType = "Savings";
        public static int accountNumber = 100000002;

//Constructors ---------------------------------------

        public Savings() : base()
        {
        }

        public Savings(decimal Balance, string UserName) : base(Balance, UserName)
        {

        }

        public Savings(int savingsTransactionNumber)
        {

        }

// Properties --------------------------------------------
        public decimal SavingsWithdrawalFee { get; set; }
       

        public int SavingsAccountType { get; set; }
// METhods------------------------------------------------

        static public void SavingsStream()
        {
            StreamWriter savings = new StreamWriter("SavingsTrans.txt", true);
            using (savings)
            {
                foreach (string line in savingsTransactions)
                {
                    savings.WriteLine(line);
                }
            }
        }

        public override decimal Deposit(decimal amount)
        {
           
            Balance += amount;
            Console.WriteLine("Account Type:" + accountType);
            Console.WriteLine("Account Number:" + accountNumber);
            Console.WriteLine("Your account has been updated");
            DateTime transactionTime = DateTime.Now;
            savingsTransactions.Add("Client Name: " + userName + "" + accountType + " deposit " + "Account Number:" + accountNumber + "+" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
            SavingsStream();
            return amount; 
        }

        public override decimal Withdraw(decimal amount)
        {
            if (amount >= 1000m)
            {
                Balance -= (amount - savingsWithdrawalFee);
                Console.WriteLine("Your Savings Account has been updated");
                Console.WriteLine("Account Type:" + accountType);
                Console.WriteLine("Account Number:" + accountNumber);
                Console.WriteLine("You have been charged a withdrawal fee of $20.00");
                DateTime transactionTime = DateTime.Now;
                savingsTransactions.Add("Client Name: " + userName + "" + accountType + "withdrawal " + "Account Number:" + accountNumber + "-" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
                SavingsStream();
                return amount;
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Your Savings Account has been updated");
                Console.WriteLine("Account Type:" + accountType);
                Console.WriteLine("Account Number:" + accountNumber);
                DateTime transactionTime = DateTime.Now;
                savingsTransactions.Add("Client Name: " + userName + "" + accountType + "withdrawal " + "Account Number:" + accountNumber + "-" + amount + " Current Balance: $" + Balance + "Time" + transactionTime + accountType + "deposit ");
                SavingsStream();             
                return amount;

            }
        }
    
      
    }
}
