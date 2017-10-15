﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Program
    {
        static void Main(string[] args)
        {
            // login screen


            //

            Client groverCleveland = new Client();
            Checking_Account checking1 = new Checking_Account();
            Savings_Account savings1 = new Savings_Account();

            //Generic Coroporate Bank Welcome Screen
            Console.WriteLine("Welcome to Whatever Bank!");

            bool perpectualMenu = true;  // for program running until "exit"

            do
            {
                // User Menu

                Console.WriteLine("Please type in the number of your desired action below. \n");
                Console.WriteLine("1. View Client Information");
                Console.WriteLine("2. View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 5)
                {
                   perpectualMenu = false;
                }

                string accountChoice;  // to store input from view account balance, deposit funds, and withdraw funds 

                // View Client Info

                if (userChoice == 1)
                {
                    groverCleveland.GetInfo();
                }

                // View Account Balance

                else if (userChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please type in the letter of the account you would like to view:");
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    accountChoice = Console.ReadLine();

                    if (accountChoice == "a")
                    {
                        checking1.ViewAccountDetails();
                    }
                    else if (accountChoice == "b")
                    {
                        savings1.ViewAccountDetails();
                    }
                    else
                    {
                        Console.WriteLine("Please choose from a valid selection.");
                    }
                }

                // Deposit Funds

                else if (userChoice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please type in the letter of the account you would like to make a deposit:");
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    accountChoice = Console.ReadLine();

                    if (accountChoice == "a")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please type in the amount you would like to deposit:");
                        checking1.DepositMoney();
                    }
                    else if (accountChoice == "b")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please type in the amount your would like to deposit:");
                        savings1.DepositMoney();
                    }

                    else
                    {
                        Console.WriteLine("Please choose from a valid selection.");
                    }
                }

                // View Withdraw Funds

                else if (userChoice == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("Please type in the letter of the account you would like to make a withdrawal:");
                    Console.WriteLine("a. Checking Account");
                    Console.WriteLine("b. Savings Account");
                    accountChoice = Console.ReadLine();

                    if (accountChoice == "a")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please type in the amount you would like to withdraw:");
                        checking1.WithdrawMoney();
                    }

                    else if (accountChoice == "b")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please type in the amount your would like to withdraw:");
                        savings1.WithdrawMoney();
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Please choose from a valid selection.");
                    }

                // Exit

                }

                else if (userChoice == 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for stopping by Whatever Bank!!!");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please choose from a valid selection.");
                }

            }

            while (perpectualMenu == true);  // ends do-while loop for program running until "exit"
            
        }

    }
}

