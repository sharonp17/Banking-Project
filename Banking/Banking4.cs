using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {   
            string userChoice;
            decimal amount;
            string userName = "";
            
            Checking checkingAccount = new Checking(800.00m, userName);
            Savings savingsAccount = new Savings(60000.00m, userName);
            Reserve reserveAccount = new Reserve(80000.00m, userName);
            //This Project is a virtual Bank called Uenhang Bank. The user has access to three types of banking accounts Checking, Savings and Reserve.           

            Console.WriteLine("\t ~ Welcome to Unhaeng Bank ~");
            Console.WriteLine();
            Console.WriteLine("Please enter your name to continue:");
            Console.WriteLine();
            userName = Console.ReadLine();
            checkingAccount.UserName = userName;
            savingsAccount.UserName = userName;
            reserveAccount.UserName = userName;
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("\t ~Unhaeng Bank ~");
            Console.WriteLine("Welcome back " + userName);
            Console.WriteLine();

            // The user chooses actions from a list with 5 options. They can view client informaiton , view their updated account balances or complete a Deposit or Withdraw action from any of 3 accounts.
            //The menu consists of 5 main options set as if/else statements and each of those 5 options has nested if/else statments that correspond with the action
            //the user would like to take (either deposit or withdraw). The entire program is wrapped in a do/while loop. While the menue is set in an array.
            do
            {
                Console.WriteLine();
                Console.WriteLine("Please select an option to continue");
                Console.WriteLine("\n Option Menu:\nPress 1 : to View Client Information\nPress 2 : for Account Balances \nPress 3 : for Checking Account \nPress 4 : for Savings Account");
                Console.WriteLine("Press 5 : for Reserve Account\n Press 6 to exit");
                userChoice = Console.ReadLine();
                Console.WriteLine();
                {
                    string[] menuOption = new string[5];

                    menuOption[0] = "1";
                    menuOption[1] = "2";
                    menuOption[2] = "3";
                    menuOption[3] = "4";
                    menuOption[4] = "5";
//Client Information
                    if (userChoice == "1")
                    {
                        Console.WriteLine("Patron Information:");
                        Console.WriteLine("Account Number: 555555");
                        Console.WriteLine(userName);
                        Console.WriteLine("Address:\n900 Cleveland Rd.\nSeoul, SK 10004");
                        Console.WriteLine();
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
//Account Balances
                    }
                    else if (userChoice == "2")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your Current Balances:");
                        Console.WriteLine();
                        Console.WriteLine("Checking Balance: {0:C}", checkingAccount.Balance);
                        Console.WriteLine("Savings Balance : {0:C}", savingsAccount.Balance);
                        Console.WriteLine("Reserve Balance : {0:C}", reserveAccount.Balance);
                        System.Threading.Thread.Sleep(3000);
                        Console.Clear();
                    }
//Checking Account
                    else if (userChoice == "3")
                    {
                        Console.WriteLine();
                        Console.WriteLine("CHECKING ACCOUNT:");
                        Console.WriteLine("Press 1: to DEPOSIT\nPress 2: to WITHDRAW");
                        userChoice = Console.ReadLine();
                        Console.Clear();

                        if (userChoice == "1")
                        {
                            Console.WriteLine("How much would you like to DEPOSIT?");
                            try
                            {
                                amount = decimal.Parse(Console.ReadLine());
                                checkingAccount.Deposit(amount);
                                System.Threading.Thread.Sleep(3000);
                            }
                            catch (Exception)
                            { }

                        }
                        else if (userChoice == "2")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            try
                            {
                                amount = decimal.Parse(Console.ReadLine());
                                checkingAccount.Withdraw(amount);
                                System.Threading.Thread.Sleep(3000);
                            }
                            catch (Exception)
                            { }

                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid number");
                            System.Threading.Thread.Sleep(2000);

                        }

                    }
//Savings Account
                    else if (userChoice == "4")

                    {
                        Console.WriteLine();
                        Console.WriteLine("SAVINGS ACCOUNT");
                        Console.WriteLine("Press 1: to DEPOSIT\nPress 2: to WITHDRAW");
                        userChoice = Console.ReadLine();
                        Console.Clear();

                        if (userChoice == "1")
                        {
                            Console.WriteLine("How much would you like to DEPOSIT?");
                            try
                            {
                                amount = decimal.Parse(Console.ReadLine());
                                savingsAccount.Deposit(amount);
                                System.Threading.Thread.Sleep(3000);
                            }
                            catch (Exception)
                            { }

                        }
                        else if (userChoice == "2")
                        {
                            Console.WriteLine("How much would you like to withdraw?");
                            try
                            {
                                amount = decimal.Parse(Console.ReadLine());
                                savingsAccount.Withdraw(amount);
                                System.Threading.Thread.Sleep(3000);
                            }
                            catch (Exception)
                            { }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Option");
                            System.Threading.Thread.Sleep(2000);

                        }
                    }
   //Reserve Account
                    else if (userChoice == "5")
                    {
                        Console.WriteLine();
                        Console.WriteLine("RESERVE ACCOUNT");
                        Console.WriteLine("Press 1: to DEPOSIT\nPress 2: to WITHDRAW");
                        userChoice = Console.ReadLine();
                        Console.Clear();

                        if (userChoice == "1")
                        {
                            Console.WriteLine("How much would you like to DEPOSIT?");
                            try
                            {
                                amount = decimal.Parse(Console.ReadLine());
                                reserveAccount.Withdraw(amount);
                                System.Threading.Thread.Sleep(3000);
                            }
                            catch (Exception)
                            { }
                        }
                        else if (userChoice == "2")
                        {
                            try
                            {
                                Console.WriteLine("How much would you like to withdraw?");
                                amount = decimal.Parse(Console.ReadLine());
                                reserveAccount.Withdraw(amount);
                                System.Threading.Thread.Sleep(3000);
                            }
                            catch (Exception)
                            { }

                        }
                        else
                        {
                            Console.WriteLine("Invalid Option");
                            System.Threading.Thread.Sleep(2000);

                        }
                    }
//Exit Program
                    else if (userChoice == "6")
                    {
                        Console.WriteLine("Logging out");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Please Enter a valid number from the option list");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                    }
                }

            } while (userChoice != "6");

        }

    }
}





























