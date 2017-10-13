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
            //Generic Coroporate Bank Welcome Screen
            Console.WriteLine("Welcome to Whatever Bank! \n Please type in the number of your desired action below. \n");         
            Console.WriteLine("1. View Client Information");
            Console.WriteLine("2. View Account Balance");
            Console.WriteLine("3. Deposit Funds");
            Console.WriteLine("4. Withdraw Funds");
            Console.WriteLine("5. Exit");
            int userChoice = int.Parse(Console.ReadLine());

            Client groverCleveland = new Client();

            if (userChoice == 1)
            {
                groverCleveland.GetInfo();
            }


        }
    }
}
