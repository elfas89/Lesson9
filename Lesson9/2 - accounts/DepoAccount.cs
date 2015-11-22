using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class DepoAccount : BankAccount, IRateOperations
    {
        protected double rate;

        public DepoAccount(double b, string o)
            : base(b, o)
        {
            balance = b;
            owner = o;
            rate = 0.0;
        }

        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }

        public void RateSet(double r)
        {
            Rate = r;
        }

        public void RatePlus()
        {
            double newBalance = balance + balance * rate / 100;
            balance = newBalance;
        }
    }
}
