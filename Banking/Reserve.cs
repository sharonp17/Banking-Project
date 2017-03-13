using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Banking
{
    class Reserve: Account
    {
      
//Fields------------------------------------------
        static List<string> reserveTransactions = new List<string>();
        public static decimal overdraftFee = 20.00m;
        public static string accountType = "Reserve";
        public static int accountNumber = 100000003;

//Constructors ---------------------------------------

        public Reserve() : base()
        {
           
        }

        public Reserve(decimal Balance, string UserName) : base(Balance, UserName)
        {

        }

        public Reserve(int savingsTransactionNumber)
        {

        }

// Properties --------------------------------------------
        public decimal OverdraftFee { get; set; }


        public int ReserveAccountType { get; set; }
// METhods------------------------------------------------
     static public void ReserveStream()
        {
            StreamWriter reserve = new StreamWriter("ReserveStreamTrans.txt", true);
            using (reserve)
            {
                foreach (string line in reserveTransactions)
                {
                    reserve.WriteLine(line);
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
            reserveTransactions.Add("Client Name: " + userName + "" + accountType + "deposit" + "Account Number:" + accountNumber + "+" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
            ReserveStream();
            return amount;

        }

        public override decimal Withdraw(decimal amount)
        {
            if (amount >= 1000m)
            {
                Balance -= (amount - overdraftFee);
                Console.WriteLine("Your Reserve Account has been updated");
                Console.WriteLine("Account Type:" + accountType);
                Console.WriteLine("Account Number:" + accountNumber);
                Console.WriteLine("You have been charged a withdrawal fee of $20.00");
                DateTime transactionTime = DateTime.Now;
                reserveTransactions.Add("Client Name: " + userName + "" + accountType + "withdrawal " + "Account Number:" + accountNumber + "-" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
                ReserveStream();
                return amount;
            }
            else
            {
                Balance -= amount;
                Console.WriteLine("Your Reserve Account has been updated");
                Console.WriteLine("Account Type:" + accountType);
                Console.WriteLine("Account Number:" + accountNumber);
                DateTime transactionTime = DateTime.Now;
                reserveTransactions.Add("Client Name: " + userName + "" + accountType + "withdrawal " + "Account Number:" + accountNumber + "-" + amount + " Current Balance: $" + Balance + "Time" + transactionTime);
                ReserveStream();
                return amount;

            }
        }


    }
}

    

