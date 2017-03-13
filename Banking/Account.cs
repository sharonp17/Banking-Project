using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    public class Account
    {
//FIELDS-----------------------------------------------------------
        private bool userChoice;
        private decimal balance;
        private decimal amount;
        public string userName;
        

// CONSTRUCTORS---------------------------------------------------------

        public Account()
        {
        }

        public Account(decimal Balance, string UserName)
        {
            balance = Balance;
            userName = UserName;
        }

// PROPERTIES-------------------------------------------------------- 

        public bool UserChoice
        {
            get { return this.userChoice; }
            set { this.userChoice = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public decimal Amount
        {
            get { return this.amount; }
            set { this.amount = value; }
        }
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value;}
        }
        
// METHODS----------------------------------------------

        public virtual decimal Deposit(decimal amount)
        {
            balance = balance += amount;
            Console.WriteLine();
            DateTime transactionTime = DateTime.Now;
            Console.Clear();
            return amount;
        }

        public virtual decimal Withdraw(decimal amount)
        {
            balance = balance -= amount;
            Console.WriteLine();                              
            DateTime transactionTime = DateTime.Now;
            Console.Clear();
            return amount;  
        }

    }
}

   