﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson9
{
    public interface IRateOperations
    {
        double Rate { get;  set; }

        void RateSet(double r);

        void RatePlus();

    }
}
