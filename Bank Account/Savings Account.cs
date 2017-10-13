﻿using System;
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
        }

        public override void ViewAccountDetails()
        {
            base.ViewAccountDetails();
        }

        public override void DepositMoney()
        {
            currentBalance = 7200.00m;
            base.DepositMoney();
        }

        public override void WithdrawMoney()
        {
            currentBalance = 7200.00m;
            base.WithdrawMoney();
        }

    }
}
