using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public interface ICurrOperations
    {
        double Curr { get; set; }

        void CurrAdd (double a);

        void CurrDiv(double d);

    }
}
