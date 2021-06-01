using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine_Lib
{
    public class Account
    {
        private int _balance = 0; //Quantity of money in account

        public Account () { }

        public Account(int balance)
        {
            _balance = balance;
        }

        public int GetBalance() //Getting money
        {
            return _balance;
        }

        public void SetBalance(int money) //Putting money
        {
            _balance += money;
        }
    }
}
