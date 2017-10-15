using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Savings_Account : Account
    {
        protected decimal minimumBalance;

        public decimal MinimumBalance
        {
            get { return this.minimumBalance; }
            set { this.minimumBalance = value; }
        }

        public Savings_Account()
        {
            accountType = "--Savings Account-- ";
            accountNumber = "902-85-1464771";
            currentBalance = 7200.00m;
            minimumBalance = 0.01m;
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
            if (currentBalance >= minimumBalance)
            {
                Console.WriteLine("Your updated current balance is: $" + currentBalance);
                Console.WriteLine();
            }
            else
            {
                currentBalance += withdrawAmount;  // to balance out the erroneous withdrawal amount.
                Console.WriteLine("Your Savings Account must have a minimum balance of $0.01");
                Console.WriteLine("Please enter a valid amount to withdraw.");
                WithdrawMoney();
            }
        }
    }
}