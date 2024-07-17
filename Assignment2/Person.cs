using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Person:IComparable<Person>
    {
        string Name;
        int Age;
        public Person(string Name,int Age) {
            this.Name = Name;
            this.Age = Age;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Name: {this.Name}, Age: {this.Age}");
        }
        public int CompareTo(Person other)
        {
            if (this.Age > other.Age) { 
                return 1; 
            }
            else if (this.Age < other.Age) {
                return -1;
            }
            else { 
                return 0;
            }
        }



    }
}
