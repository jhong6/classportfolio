// Source: https://www.geeksforgeeks.org/extension-method-in-c-sharp/
// Extension Method in C#
// Author: ankita_saini
// Student: Joseph Hong
// Synopsis: Extension method allows adding new methods in the
//           exisiting class without modifying the source code
//           of the original type.

using System;
namespace ExtensionMethod
{
    class Geek
    {
        //Method 1
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        //Method 2
        public void M2()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }

        //Method 3
        public void M3()
        {
            int x, y;
            Console.WriteLine("Enter a value for x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for y:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of the two is: " + (x+y));
        }
    }
}
