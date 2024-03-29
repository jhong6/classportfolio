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
    static class NewMethodClass
    {
        //Method 4
        public static void M4(this Geek g)
        {
            Console.WriteLine("Method Name: M4");
        }
        //Method 5
        public static void M5(this Geek g, string str)
        {
            Console.WriteLine(str);
        }
    }
}

