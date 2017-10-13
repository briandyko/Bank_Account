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

            string accountChoice = Console.ReadLine();


            if (userChoice == 1)
            {
                groverCleveland.GetInfo();
            }          
            else if (userChoice == 2)
            
                if (accountChoice == "a")
                    {
                    checking1.ViewBalance(); 
                    } 
                else if (accountChoice == "b")
                    {
                    savings1.ViewBalance();
                    }


            }


        }
    }

