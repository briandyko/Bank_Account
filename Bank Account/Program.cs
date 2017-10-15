using System;
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
            // add a do-while loop to handle the typing in of exit? Also fits the program should run until the user selects exit parameter.

            //Generic Coroporate Bank Welcome Screen
            Console.WriteLine("Welcome to Whatever Bank! \n Please type in the number of your desired action below. \n");
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            int userChoice = int.Parse(Console.ReadLine());

            Client groverCleveland = new Client();
            Checking_Account checking1 = new Checking_Account();
            Savings_Account savings1 = new Savings_Account();

            string accountChoice;  // to store view account balance, deposit funds, and withdraw funds user input

            if (userChoice == 1)
            {
                groverCleveland.GetInfo();
            }
            else if (userChoice == 2)
            {
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
            }
            else if (userChoice == 3)
            {
                Console.WriteLine("Please type in the letter of the account you would like to make a deposit:");
                Console.WriteLine("a. Checking Account");
                Console.WriteLine("b. Savings Account");
                accountChoice = Console.ReadLine();

                if (accountChoice == "a")
                {
                    Console.WriteLine("Please type in the amount you would like to deposit:");
                    checking1.DepositMoney();
                }
                else if (accountChoice == "b")
                {
                    Console.WriteLine("Please type in the amount your would like to deposit:");
                    savings1.DepositMoney();
                }
            }


            else if (userChoice == 4)
            {
                Console.WriteLine("Please type in the letter of the account you would like to make a withdrawal:");
                Console.WriteLine("a. Checking Account");
                Console.WriteLine("b. Savings Account");
                accountChoice = Console.ReadLine();

                if (accountChoice == "a")
                {
                    Console.WriteLine("Please type in the amount you would like to withdraw:");
                    checking1.WithdrawMoney();
                }

                else if (accountChoice == "b")
                {

                    Console.WriteLine("Please type in the amount your would like to withdraw:");
                    savings1.WithdrawMoney();
                }
                //    if (savings1.CurrentBalance <= 0)

                //    savings1.KeepMinimumPlease();            



                else if (userChoice == 5)
                {
                    Console.WriteLine("Thank you for stopping by Whatever Bank!!!");
                }
                else
                {
                    Console.WriteLine("Please choose from a valid selection.");
                }

                // make way to say "Thank you for stopping by Whatever Bank" at the end of each choice instead of hardcoding it in everywhere??




            }


        }
    }
}
