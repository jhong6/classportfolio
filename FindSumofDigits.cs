// Source: https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
// C# Coding Questions For Technical Interviews
// Author: Ankit Sharma
// Student: Joseph Hong
// Synopsis: This program finds the sum of the digits of a positive integer

using System;

namespace FindSumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Check to make sure user input is positive integer greater than 1
            if(n <= 0)
            {
                Console.WriteLine("Your value must be at least greater than 1");
                return;
            }
            else
            {
                SumOfDigits(n);
            }
        }

        // Method to sum the digits
        static void SumOfDigits(int num)
        {
            // Create a variable used to sum up the values.
            int sum = 0;
            while (num > 0)
            {
                // Add the previous value of sum using the modulus
                sum += num % 10;
                // After the previous calculation, decrement by dividing 10
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}

// Modification:    Added comments. Added user input. Removed
//                  unused namespaces. Also added check to see
//                  if user's input is valid.

// Analysis:        This is a program that adds up the digits of an integer.
//                  For example, an integer 180 would be 1 + 8 + 0, which equals
//                  9. The logic is that we just want the value of each digit
//                  as its own integer. Therefore, using the modulus operator
//                  and using 10 (base 10) will allow us to obtain that exact number
//                  for each iteration of the while loop and be used to get the total
//                  sum of each digit.

// Output:
// Enter a positive integer:
// 1578
// 21
