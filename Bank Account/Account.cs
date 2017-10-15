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
        protected decimal currentBalance;
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
            set { this.currentBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountNumber; }
            set { this.accountType = value; }
        }
     
        public virtual void ViewAccountDetails()
        {
            Console.WriteLine(accountType);
            Console.WriteLine("Account # : " + accountNumber);
            Console.WriteLine("Your account currently contains: $" + currentBalance);
            Console.WriteLine();

        }

        public virtual void DepositMoney()
        {
            depositAmount = decimal.Parse(Console.ReadLine());
            currentBalance += depositAmount;
            Console.WriteLine("Your updated current balance is: $" + currentBalance);
            Console.WriteLine();
        }

        // required abstract method

        public abstract void WithdrawMoney();
    
    }
}
