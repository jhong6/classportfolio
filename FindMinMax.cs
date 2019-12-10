// Source: Summer 2019 – CSC 395 – ST: Algorithm & Data Structure Concepts
// M2: C# Quick Review & Searching Algorithms Sorting Algorithms
// Author: Razvan Mezei
// Student: Joseph Hong
// Synopsis: This program finds either the minimum or maximum value
//           from an array.

using System;

namespace FindMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array of int values
            int[] someArray = { 4, 13, 2, 98, 56, 1035, 45, 1 };

            // Prompt user for selection
            Console.WriteLine("Which function would you like to use to find the minimum or maximum value in an array?" +
                              "\nEnter \"1\" for minimum or \"2\" for maximum");
            string choice = Console.ReadLine();

            // Output depending on user's selection
            if (choice == "1")
            {
                Console.WriteLine(FindMin(someArray));
            }
            else if(choice == "2")
            {
                Console.WriteLine(FindMax(someArray));
            }
            else
            {
                Console.WriteLine("{0} is not among the option.", choice);
            }
        }
        
        // Method to finding Minimum value in an array
        static int FindMin(int[] arr)
        {
            // First set the min value to the first element for comparison
            int minVal = arr[0];
            // The for traverses through the entire array
            for(int i = 0; i<arr.Length; i++)
            {
                // Check if each element is less than the current value of minVal
                // If true, then reassign the minVal as the new minimum
                if(arr[i] < minVal)
                {
                    minVal = arr[i];
                }
            }
            return minVal;
        }

        // Method of finding Max value in an array
        static int FindMax(int[] arr)
        {
            // Similar to FindMin method but the only logic changed
            // is conditional statement with greater than operator.
            int maxVal = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                
                if(arr[i] > maxVal)
                {
                    maxVal = arr[i];
                }
            }
            return maxVal;
        }
    }
}
// Modification:    Added comments. Added second method to find
//                  max value. Added user interaction and an array.

// Analysis:        The two methods use a simple algorithm: It first
//                  sets the int variable to the first element of the
//                  array. It then traverses through the array and
//                  compares each element with the min/max variable
//                  and changes accordingly.

// Output:
// Which function would you like to use to find the minimum or maximum value in an array?
// Enter "1" for minimum or "2" for maximum
// 2
// 1035
