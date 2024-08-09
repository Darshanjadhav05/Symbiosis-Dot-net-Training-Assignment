using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    

    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> peopleList = new List<Person>() 
{ new Person("Darshan", 20), new Person("Sarang", 21), new Person("Om", 18), new Person("Yadnesh", 17) };
            Console.WriteLine("Before Sorting: ");
            foreach (Person p in peopleList)
            {
                p.PrintDetails();
            }
            peopleList.Sort();

            Console.WriteLine("\nAfter Sorting: ");
            foreach (Person p in peopleList)
            {
                p.PrintDetails();
            }
        }
    }
}
