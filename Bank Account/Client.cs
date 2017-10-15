using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class Client
    {
        private string userName;
        private string bankIdentificationNumber;
        private string userBirthDate;

        
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }   // do i need sets for any of these three values? I don't really want them setting it, at least not yet (stretch task).
        }

        public string BankIdentificationNumber
        {
            get { return this.bankIdentificationNumber; }
            set { this.bankIdentificationNumber = value; }
        }

        public string UserBirthDate
        {
            get { return this.userBirthDate; }
            set { this.userBirthDate = value; }
        }

        public Client()
        {
            userName = "Grover Cleveland";                // for now this can be hardcoded in, but maybe I'll need to console.readline it for the stretch task.
            bankIdentificationNumber = "Customer ID: 4931bvX2984z";
            userBirthDate = "03 / 18 / 1837";

        }

        public void GetInfo()
        {
            Console.WriteLine("\n" + userName + "\n" + bankIdentificationNumber + "\n" + userBirthDate + "\n Thanks for being a loyal customer " + userName + "!");
            Console.WriteLine();
        }


    }
}
