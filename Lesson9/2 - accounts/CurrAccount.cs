using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class CurrAccount : BankAccount, ICurrOperations
    {
        public CurrAccount(double b, string o)
            : base(b, o)
        {
            balance = b;
            owner = o;
        }

        public double Curr
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }

        }


        public void CurrAdd(double a)
        {
            balance += a;
        }

        public void CurrDiv(double d)
        {
            balance -= d;
        }
    }
}
