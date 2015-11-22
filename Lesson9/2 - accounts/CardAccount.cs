using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public class CardAccount : DepoAccount, IRateOperations, ICurrOperations
    {
        public CardAccount(double b, string o)
            : base(b, o)
        {
            balance = b;
            owner = o;
            rate = 0.0;
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
