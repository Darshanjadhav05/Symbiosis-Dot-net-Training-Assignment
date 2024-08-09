using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Problem2
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine($"The Addition of {a} and {b} is {a + b}");
        }
        public void MultipleNumbers(int a, int b)
        {
            Console.WriteLine($"The Multiplication of {a} and {b} is {a * b}");

        }
        public static void Process()
        {
            Problem2 problem2 = new Problem2();

            Console.WriteLine("Enter first Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Operation mathOps = new Operation(problem2.AddNumbers);
            Console.WriteLine("Addition Operation: ");
            mathOps(num1 , num2);

            Console.WriteLine();
            Console.WriteLine("After Subscribing to multiplication in delacate");
            mathOps += problem2.MultipleNumbers;
            mathOps(num1, num2);

            Console.WriteLine();
            Console.WriteLine("After UnSubscribing to Addition in delacate");
            mathOps -= problem2.AddNumbers;
            mathOps(num1, num2);

        }
    }
}

