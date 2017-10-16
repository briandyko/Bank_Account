using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client : Account
    {
        // field

        protected object genericUser;
        private string bankIdentificationNumber;
        private string customerYears;

        // Properties

        public object GenericUser
        {
            get { return this.genericUser; }
            set { this.genericUser = value; }
        }

        public string BankIdentificationNumber
        {
            get { return this.bankIdentificationNumber; }
            set { this.bankIdentificationNumber = value; }
        }

        public string CustomerYears
        {
            get { return this.CustomerYears; }
            set { this.CustomerYears = value; }
        }

        //Constructor

        public Client()
        {   bankIdentificationNumber = "Customer ID: 4931bvX2984z";
            customerYears = "Whatever Bank customer for 8 years!";

        }

        //Methods

        public void GetInfo()
        {
            Console.WriteLine(bankIdentificationNumber + "\n" + customerYears);
            Console.WriteLine();
            Console.WriteLine("Thanks for being a loyal customer " + "!");
            Console.WriteLine();
        }

        public override void WithdrawMoney()
        {
            // here just because it has to be since it's a derived class of Account.
        }

        

    }
}
