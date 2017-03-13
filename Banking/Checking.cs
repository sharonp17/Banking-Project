using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    class Checking : Account
    {
 //each class contains a List. This collects the information that is to be written through the StreamWriter which is in each method. 
   static List<string> checkingTransactions = new List<string>();
//Fileds ------------------------------------------
      private decimal checkingFee;
      public static string accountType = "Checking";
      public static int accountNumber = 100000001;


// ConsTructors ------------------------------------------
        public Checking() : base()
        {
            
        }

        public Checking(decimal Balance, string UserName) : base(Balance, UserName)
        {
            
        }
//Properties--------------------------------------------

        public decimal CheckingFee
        {
            get { return this.checkingFee; }
            set { this.checkingFee = value; }
        }

        public string AccountType { get; set; }

// Methods-----------------------------------------------
//Each class contains 3 methods a Deposit, Withdraw and StreamWriter method. 

        static public void CheckingStream()
        {
            StreamWriter checking = new StreamWriter("CheckingTrans.txt", true);
            using (checking)
            {
                foreach (string line in checkingTransactions)
                {
                    checking.WriteLine(line);
                }
            }
        }
//Depending on the amount added or withdrawn to/from the account different actions will occur. 
//Each transaction is returned to update the previous balance and is stamped with a date/time note. 

        public override decimal Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine();
            Console.WriteLine("Your Checking account has been updated");
            Console.WriteLine("Account Type:" + accountType);
            Console.WriteLine("Account Number:" + accountNumber);
            DateTime transactionTime = DateTime.Now;
            Console.WriteLine(transactionTime);
            checkingTransactions.Add("Client Name: " + userName + "" + accountType + "deposit " + "Account Number:" + accountNumber + "+" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
            CheckingStream();
            return amount;     
        }
        public override decimal Withdraw(decimal amount)
        {
            if (amount >= 200m)
            {
                Balance -= (amount - 5.50m);
                Console.WriteLine("Account Type:" + accountType);
                Console.WriteLine("Account Number:" + accountNumber);
                Console.WriteLine("You have been charged a withdrawal fee of $5.50");
                DateTime transactionTime = DateTime.Now;
                checkingTransactions.Add("Client Name: " + userName + "" + accountType + " withdrawal " + "Account Number:" + accountNumber + "-" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
                CheckingStream();
                return amount;
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Your Checking account has been updated");
                Console.WriteLine("Account Type:" + accountType);
                Console.WriteLine("Account Number:" + accountNumber);
                DateTime transactionTime = DateTime.Now;
                checkingTransactions.Add("Client Name: " + userName + "" + accountType + " withdrawal " + "Account Number:" + accountNumber + "-" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
                CheckingStream();
                return amount;
                             
            }
            
           }
        }
    }

