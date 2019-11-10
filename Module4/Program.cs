// Source: https://www.tutlane.com/tutorial/csharp/csharp-static-class-with-examples
// C# Static Class with Examples
// Author: Tutlane.com
// Student: Joseph Hong
// Downloaded Date: 11/4/19
// Synopsis: Simple program demonstrating declaration and usage of a static class

using System;

namespace StaticClass
{
    // Static class can only contain static members
    static class User
    {

        public static string name;

        public static string location;

        public static int age;

        public static void Details()
        {
            Console.WriteLine("This string displays static method");
        }
        // Static method that calculates the average of two numbers
        public static void TwoNumAverage(double x, double y)
        {
            double average = (x + y) / 2;
            Console.WriteLine("The average of {0} and {1} is {2}", x, y, average);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // The public access modifier for the static members allows
            // string and int values to be set and displayed in the output.
            User.name = "Suresh Dasari";
            User.location = "Hyderabad";
            User.age = 32;

            Console.WriteLine("Name: {0}", User.name);
            Console.WriteLine("Location: {0}", User.location);
            Console.WriteLine("Age: {0}", User.age);

            // Calls the Details() method from the User static class
            User.Details();

            // Calls the TwoNumAverage with type double values in its parameter 
            User.TwoNumAverage(15.3, 37.5);

            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
// Modification: Changes include revising the original string from Details() method,
//               adding a new static method that averages the two double values and
//               calling it in the Main method, and comments.

// Analysis:     Static classes cannot be instantiated so their members can only be used
//               as long as the static classes are used themselves. 

/*Sample Output:
 * Name: Suresh Dasari
 * Location: Hyderabad
 * Age: 32
 * This string displays static method
 * The average of 15.3 and 37.5 is 26.4
 * 
 * Press Enter Key to Exit..
*/
