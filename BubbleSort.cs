// Source: https://www.geeksforgeeks.org/bubble-sort/
// Bubble Sort
// Author: Geeks for Geeks
// Student: Joseph Hong
// Synopsis: One of many sorting algorithm, this program
//           demonstrates a Bubble Sort.

using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            void bubbleSort(int[] array1)
            {
                // An int variable is needed to store
                // values that will be used to 
                int temp;

                // The first for loop will pass through the array
                for(int i = 0; i < array1.Length; i++)
                {
                    // The second for loop will be used to compare the
                    // adjacent elements
                    for (int j = 0; j < array1.Length - 1; j++)
                    {
                        // Check if the current index element is greater 
                        // than the next index's element.
                        if (array1[j] > array1[j+1])
                        {
                            // Store the larger value into the temp variable
                            temp = array1[j];
                            // Swap and set the greater value to the lesser one
                            array1[j] = array1[j + 1];
                            // Swap and set the lesser index element with temp
                            array1[j + 1] = temp;
                        }
                    }
                }
                // Display the sorted array
                foreach(int n in array1)
                {
                    Console.Write(n + " ");
                }
            }
            // Create an array with hardcoded values
            int[] myArray = { 3, 7, 2, 11, 5, 3, 1 };
            
            // Call the method
            bubbleSort(myArray);
        }
    }
}

// Modification:  Added comments. Modified the original
//                code to merge the print method. Removed
//                int n = arr.Length, and removed the first loop
//                with n - 1 (or arr.Length - 1) as my condition was
//                going to pass through the entire array. Also,
//                changed the display of the new array using foreach
//                instead of a second for loop. Added hardcoded values
//                and invokes only one method to sort the array.

// Analysis:      The program uses a Bubble Sort algorithm to sort
//                an unordered int array. It first looks through the array
//                and uses nested for loop to check if the left value
//                is greater than the right, and will continuously swap them
//                until it reaches the "end" of the array. This ensures that
//                the largest int value is sorted at the end. The sort
//                continues until the array is sorted in ascending order.

// Output:
// 1 2 3 3 5 7 11
