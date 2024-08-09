using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Problem1
    {
        public void AddNumbers(int a,int b)
        {
            Console.WriteLine($"The Addition of {a} and {b} is {a+b}");
        }
        public void MultipleNumbers(int a,int b)
        {
            Console.WriteLine($"The Multiplication of {a} and {b} is {a * b}");

        }

        public static void Process()
        {
            Console.WriteLine("Enter first Number: ");
            int num1 = Convert.ToInt32( Console.ReadLine() );
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32( Console.ReadLine() );

            Problem1 problem1 = new Problem1();
            problem1.AddNumbers(num1,num2);
            problem1.MultipleNumbers(num1,num2);
          
        }
    }
}
