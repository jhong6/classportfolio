// Source: https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
// C# Coding Questions For Technical Interviews
// Author: Ankit Sharma
// Student: Joseph Hong
// Synopsis: This program finds the sum of the digits of a positive integer

using System;

namespace SequentialSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an int variable to be searched within an array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] sampleArray = new int[5] { 15, 13, 5, 4, 98 };
            SeqSearch(sampleArray, n);
        }
        // Method takes array and int values in its parameter
        static void SeqSearch(int[] array, int key)
        {
            // The for loop will loop through the entire array
            for (int index = 0; index < array.Length; index++)
            {
                // If matching value is found, then set ret to index number
                // and terminate the entire method after displaying
                // the position of the key.
                if(array[index] == key)
                {
                    Console.WriteLine("Found {0} at index {1}.", key, index);
                    return;
                }
            }
            // If the key does not exist, simply display that it doesn't exist.
            Console.WriteLine("{0} does not exist in this array", key);
        }
    }
}

// Modification:    Added comments. Added user input. Removed
//                  unused namespaces. Modified the original method
//                  from int to void in order to let the user know if the
//                  desired value exists.

// Analysis:        This simple program uses linear search algorithm
//                  to look for an existing key within a predetermined
//                  array of integers. It simply lets the user know
//                  if the specified integer to look for exists.

// Output:
// Enter an int variable to be searched within an array:
// 13
// Found 13 at index 1.
