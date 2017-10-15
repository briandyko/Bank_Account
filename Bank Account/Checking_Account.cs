using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Checking_Account : Account
    {

        public Checking_Account()
        {
            accountType = "--Checking Account-- ";
            accountNumber = "538-32-2239931";
            currentBalance = 10000.00m;
        }

        public override void ViewAccountDetails()
        {
            base.ViewAccountDetails();
        }

        public override void DepositMoney()
        {
            base.DepositMoney();
        }

        public override void WithdrawMoney()
        {
            withdrawAmount = decimal.Parse(Console.ReadLine());
            currentBalance -= withdrawAmount;
            Console.WriteLine("Your updated current balance is: $" + currentBalance);
        }




    }
}
