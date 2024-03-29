﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Account_Simulator
{
    class BankAccount
    {
        private decimal _balance;

        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }
        public decimal Balance
        {
            get { return _balance; }
        }

        public void Deposit(decimal depositAmount)
        {
            _balance += depositAmount;
        }

        public void Withdraw(decimal withdrawalAmount)
        {
            _balance -= withdrawalAmount;
        }
    }
}
