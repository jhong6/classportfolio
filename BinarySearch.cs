// Source: Summer 2019 – CSC 395 – ST: Algorithm & Data Structure Concepts
// M2: C# Quick Review & Searching Algorithms Sorting Algorithms
// Author: Razvan Mezei
// Student: Joseph Hong
// Synopsis: This program demonstrates and Binary Search Algorithm

using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Predetermined list of int array between 1 and 100
            int[] array = { 1, 4, 9, 11, 17, 20, 45, 60, 100 };
            Console.WriteLine("Enter a value between 1 and 100 to search:");
            
            int n = Convert.ToInt32(Console.ReadLine());
            
            // Call and display the binSearch method
            Console.WriteLine("{0} is at index: {1} ", n, binSearch(array, n));
        }

        // Binary search method
        static int binSearch(int[] arr, int key)
        {
            // The ret variable will be used to return
            // the index of the number (if found)
            // Otherwise, it returns -1;
            int ret = -1;
            int low = 0;
            int high = arr.Length - 1;
            int mid;

            // This starts the algorithm for binary
            // search. The initialized value
            while(low <= high && ret == -1)
            {
                mid = (low + high) / 2;

                if(arr[mid] == key)
                {
                    ret = mid;
                }
                else if(arr[mid] < key)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return ret;
        }
    }
}
// Modification:    Minimum modification. Included an array and
//                  allows user to search for value.

// Analysis:        The binary search works for sorted array. Otherwise,
//                  the algorithm will not work. It searches for the value
//                  by first starting at the midpoint value of the array.
//                  If the midpoint value is less than or greater than the key value,
//                  then the next iteration will search midpoint from either right half
//                  or left half of the first midpoint. This is repeated until either
//                  the value is found or not found (returning -1 if the value does not exist).

// Output:
// Enter a value between 1 and 100 to search:
// 17
// 17 is at index: 4
