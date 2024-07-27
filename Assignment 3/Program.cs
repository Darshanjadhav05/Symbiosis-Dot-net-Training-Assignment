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

            Point3D point = new Point3D(1.1f, 2.2f, 3.3f);

            Console.WriteLine("X value is: "+ point.ToString("X"));
            Console.WriteLine();
            Console.WriteLine("Y value is: "+ point.ToString("Y"));
            Console.WriteLine();
            Console.WriteLine("Z value is: "+ point.ToString("Z"));
            Console.WriteLine();
            Console.WriteLine("XYZ value is: "+ point.ToString("XYZ"));
            Console.WriteLine();  
            Console.WriteLine(point.ToString("G"));    
        }
    }
}
