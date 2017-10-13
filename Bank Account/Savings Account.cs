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
         
        }

        public override void ViewBalance()
        {
            base.ViewBalance();
        }
    }
}
