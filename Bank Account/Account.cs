using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    abstract class Account
    {
        protected string accountNumber;
        static decimal currentBalance;
        protected string accountType;
        protected decimal depositAmount;
        protected decimal withdrawAmount;

        public string AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        
        public decimal CurrentBalance
        {
            get { return this.CurrentBalance; }
            set { this.CurrentBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountNumber; }
            set { this.accountType = value; }
        }

        public Account()
        {

        }

        public void AccountOptions()
        {
            Console.WriteLine("a. Checking Account");
            Console.WriteLine("b. Savings Account");
        }

        public virtual void ViewBalance()
        {
           Console.WriteLine("Your account currently contains: " + currentBalance);
        }

        public void DepositMoney()
        {
            depositAmount = decimal.Parse(Console.ReadLine());
            currentBalance =+ depositAmount;
        }

        public void WithdrawMoney()
        {
            withdrawAmount = decimal.Parse(Console.ReadLine());
            currentBalance =- withdrawAmount;
        }
    }
}
