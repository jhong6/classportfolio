// Source: https://www.sanfoundry.com/csharp-program-insertion-sort/
// C# Program to Perform Insertion Sort
// Author: Manish Bhojasia
// Student: Joseph Hong
// Synopsis: Program that sorts an array using Insertion Sort algorithm.

using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt user to specify the size of the array and convert
            // it to int
            Console.WriteLine("Please enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Use the converted int value to set the size of the array
            int[] arr = new int[n];

            // Create a while loop that requests user to input int values
            // until the size of the array is met.
            Console.WriteLine("Please enter integer values for each element:");
            int count = 0;
            while(count != n)
            {
                int numArray = Convert.ToInt32(Console.ReadLine());
                arr[count] = numArray;
                count++;
            }

            int i;
           
            // Print the array that was inputted by the user
            Console.WriteLine("The Array is :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Call the Insert Sort method
            insertsort(arr, n);
            
            // Display the new Sorted Array
            Console.WriteLine("The Sorted Array is :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
                
        }

        // Insert Sort Method
        static void insertsort(int[] data, int n)
        {
            int i, j;

            // The first for loop iterates through the array
            for (i = 1; i < n; i++)
            {
                // Declare two int variables where
                // item will be used to compare in the
                // nested for loop. ins variable will
                // be used to terminate the loop once insertion
                // sorting is compelete
                int item = data[i];
                int ins = 0;

                // The nested loop will continuously compare
                // the next element with the previous element,
                // and the next element will be inserted into
                // the previous element until it is sorted.
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    // Once sorted, set ins to 1 to terminate the
                    // overall loop
                    else ins = 1;
                }
            }
        }
    }
}

// Modification:    Added comments. Added user input. Removed
//                  unused namespaces.

// Analysis:        This is a program that demonstrates insertion method.
//                  The for loop checks if the current element being compared
//                  with the previous element is less than the latter. If true,
//                  the current element's value is inserted into the previous elment.
//                  This repeats until n-1 times until the entire array is sorted.

// Output:
// Please enter the size of the array:
//5
//Please enter integer values for each element:
// 87
// 19
// 13
// 15
// 13
// The Array is :
// 87
// 19
// 13
// 15
// 13
// The Sorted Array is :
// 13
// 13
// 15
// 19
// 87
