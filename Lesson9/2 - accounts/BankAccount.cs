using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class BankAccount
    {
        protected double balance;
        protected string owner;

        public BankAccount(double b, string o)
        {
            balance = b;
            owner = o;
        }

        public double GetBalance()
        {
            return balance;
        }

        public string GetOwner()
        {
            return owner;
        }

        public double Close()
        {
            double closedBalance = balance;
            balance = 0.0;
            return closedBalance; 
        }
    }
}
