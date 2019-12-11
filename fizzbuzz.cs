// Source: https://exceptionnotfound.net/a-definitive-fizzbuzz-solution-guide-in-c-sharp/
// A Definitive FizzBuzz Solution Guide in C#
// Author: Matthew Jones
// Student: Joseph Hong
// Synopsis: A simple program displaying "fizz" for multiples of 3,
//           "buzz" for multiples of 5, and "fizzbuzz" for both
//            multiples of 3 and 5.

using System;

namespace BasicCSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
        
            void fizzbuzz()
            {
                // Start at 1 and loop until 100 is
                // reached
                for (int i = 1; i <= 100; i++)
                {
                    // If 15 is multiples of 3 and 5
                    // so let this statement have
                    // higher precedence
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    // If multiples of 3 or 5, then
                    // output their strings
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    
                    // If none of the conditions are met
                    // simply, output the integer values
                    else
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            // Run the method
            fizzbuzz();
       }
   }
}

// Modification:  Added additional condition to display integers
//                that do not meet the standards of the displaying
//                the strings.

// Analysis:      The original solution neglected to output
//                other integers. Having just the strings be
//                displayed as fizz, buzz, and fizzbuzz
//                won't truly show if the condition statements
//                are working as intended but may appear meaningless.

// Output
// 1
// 2
// fizz
// 4
// buzz
// fizz
// 7
// 8
// fizz
// buzz
// 11
// fizz
// 13
// 14
//fizzbuzz
...
// fizz
// 97
// 98
// fizz
// buzz
