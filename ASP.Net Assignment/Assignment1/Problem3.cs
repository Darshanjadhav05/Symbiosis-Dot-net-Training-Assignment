using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Problem3
    {
        public void AddNumbers(int a, int b)
        {
            Console.WriteLine($"The Addition of {a} and {b} is {a + b}");
            Console.WriteLine();

        }
        public void MultipleNumbers(int a, int b)
        {
            Console.WriteLine($"The Multiplication of {a} and {b} is {a * b}");
            Console.WriteLine();

        }
        public static void Process()
        {
            Problem3 problem3 = new Problem3();
            Operation mathOps = null;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Multiplication");
                Console.WriteLine("3. Both Operations ");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("Enter first Number: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            mathOps += problem3.AddNumbers;
                            break;
                        case 2:
                            mathOps -= problem3.AddNumbers;
                            mathOps += problem3.MultipleNumbers;

                            break;
                        case 3:
                            mathOps -= problem3.MultipleNumbers;
                            mathOps += problem3.AddNumbers;
                            mathOps += problem3.MultipleNumbers;
                            break;
                    }
                    mathOps(num1, num2);
                }
                else if (choice == 4)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}

