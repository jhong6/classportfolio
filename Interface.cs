// Source: http://www.dotnetperls.com/interface
// Author: Sam Allen
// Student: Joseph Hong
// Download Date: Oct 31, 2019
// Synopsis: A simple example of creating and using an interface.

using System;

namespace InterfaceSampleCode
{
    // Interface is declared with the keyword, "interface," followed by the
    // interface name ("I" is used to denote that it's interface). Similar to
    // classes and structs, the default access modifier for interfaces is internal
    // when declared directly within the namespace.
    interface IPerl
    {
        // Interfaces do not contain the details of implementations of methods
        // and only accept member signatures. Two void methods are declared: 
        // One takes no parameter and the other requires int values.
        void Read();
        void CompareUserValues(int x, int y);
    }

    // When a struct or class (Test class for this example) implements an interface,
    // the struct or class must implement every member of the interface.
    class Test: IPerl
    {
        //Implementation of the Read method from Interface
        public void Read()
        {
            Console.WriteLine("This Read Method only displays a string");
        }
        // This second implementation specifies the functionality of the method where
        // it compares two int values and displays a string based on these values.
        public void CompareUserValues(int x, int y)
        {
            if (x > y)
                Console.WriteLine(x + " is larger than " + y);
            else if (y > x)
                Console.WriteLine(y + " is greater than " + x);
            else
                Console.WriteLine("The two values are equal.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // An instance of a Test class is created and is stored in IPerl variable, perl.
            IPerl perl = new Test();

            // Call the Read method
            perl.Read();

            // Prompt the user for two int values, which are converted to int from string
            Console.Write("Enter a value for x: ");
            int inputX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a value for y: ");
            int inputY = Convert.ToInt32(Console.ReadLine());
            // Call the ComapreUserValues
            perl.CompareUserValues(inputX, inputY);
        }
    }
}
// Modifications: Modified the original Test class's implementation of Read method to include a longer string.
//                Added additional method and implementation for the interface and the Test class, 
//                CompareUserValues, that has two parameters. Also added a simple user interaction that prompts
//                for two values that are passed to the added method.

// Analysis:      The main method shows an instance of a Test class that is assigned to the interface variable, perl.
//                Alternatively, a Test class variable could have been created to display the same result. E.g.
//                Test test1 = new Test(). This could make the code easier to follow.

/* Output:
 * This Read Method only displays a string
 * Enter a value for x: 5
 * Enter a value for y: 13
 * 13 is greater than 5 
*/
