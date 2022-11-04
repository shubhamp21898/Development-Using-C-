using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_Series
{
    class FabbonicSeries
    {
        public void Fab(int Num)
        {
            int FIrstnum = 0, SecondNum = 1, NextNum;
           

            NextNum = FIrstnum + SecondNum;
            Console.Write(FIrstnum + " " + SecondNum+" ");
            for(int i=2;i<Num;i++)
            {
                NextNum = FIrstnum + SecondNum;
                Console.Write(NextNum + " ");
                FIrstnum = SecondNum;
                SecondNum = NextNum;
                
            }
            Console.ReadKey();
        }
       
    }
}
