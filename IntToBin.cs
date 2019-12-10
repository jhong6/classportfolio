// Source: https://www.sanfoundry.com/csharp-program-print-binary-value/
// C# Program to Print Binary Equivalent of an Integer using Recursion
// Author: Manish Bhojasia
// Student: Joseph Hong
// Synopsis: Program  prints integer values in binary.

using System;

namespace IntToBin
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Instantiate a new object of type prog, pg
            prog pg = new prog();
            Console.WriteLine("Enter a decimal number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary equivalent of num is :");

            // Call Prog class's method, binaryconversion that was implemented
            // below
            pg.binaryconversion(num);
            Console.ReadLine();
        }
    }

    // Define a separate class called prog
    public class prog
    {
        // The class's own method
        public int binaryconversion(int num)
        {

            int bin;
            // Condition to check if user passed value is not 0.
            if (num != 0)
            {
                // The modulus operator is used to compute user's value by 2
                // and is added to 10, which is multiplied by the
                // value of the binaryconversion method. Here the recursion
                // occurs (until method reaches 0) and prints integers in binary form.
                bin = (num % 2) + 10 * binaryconversion(num / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }

        }
    }
}

// Modification: Minimum modification. Removed unused
//               namespaces and added comments.

// Analysis:    This simple program uses recursion to compute and display
//              integers in binary. The logic is that since decimal numbers
//              are of base 10 and binary are of base 2, the method
//              first takes user's value(num) adds the modulus value
//              to 10 which is multiplied by the method's num divided by 2.
//              The process repeats itself until the num variable equals 0
//              and each value is printed.

// Output:
// Enter a decimal number:
// 13
// The binary equivalent of num is :
// 1101
