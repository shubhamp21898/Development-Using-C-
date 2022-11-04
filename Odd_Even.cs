using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci_Series
{
    class Odd_Even
    {
       public Boolean Check_Even(int iVal)
        {
            if((iVal%2)==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Even()
        {
            int No;
            Console.WriteLine("Enter a No :");
            No = Int32.Parse(Console.ReadLine());
            Odd_Even obj = new Odd_Even();
            bool EvenOdd_Bool = obj.Check_Even(No);
                if (EvenOdd_Bool == true)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
