﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_Series
{
    class Sum_Of_Count
    {
        public int Num(int N)
        {
            int sum = 0;
            for(int i=1;i<=N;i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
