using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    internal class TenDigitFibonacci
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fibonacci Ten Digits ===== ");

          
            long numDigits = 0;
            long num1 = 1;
            long num2 = 1;
            long tempNum = 0;

           

            while (num2 < 10000000001)
            {
                
                if (num2 < 1000000000)
                {
                    numDigits += num2; 
                }
              tempNum = num2;
                num2 = (num1 + num2);
                num1= tempNum;


            }
            Console.WriteLine("The first number in the Fibonacci sequence to get to ten digits is " + numDigits);

        }
    }
}
