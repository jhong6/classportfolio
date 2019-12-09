// Source: https://www.hackerrank.com/challenges/simple-array-sum/problem
// Simple Array Sum
// Author: hackerrank.com
// Student: Joseph Hong
// Synopsis: Given an array of integers, find the sum of its elements.

using System;
using System.Collections.Generic;

class ArraySum
{
    static int simpleArraySum(List<int> ar)
    {
        // Declare int total and initialize to 0
        int total = 0;
        
        // Starting at Count 0 for the List,
        // iterate through each element.
        for (int i = 0; i < ar.Count; i++)
        {
            // As the loop iterates through,
            // add the current integer to the
            // total variable.
            total += ar[i];
        }
        
        // After the iteration and the total is finalized,
        // return the value of the total
        return total;
    }
        static void Main(string[] args)
    {
        // create a counter
        int count = 0;
        
        // Prompt user to enter the size of the List.
        Console.WriteLine("Please enter a size (of integer) for the List");
        
        // Convert the string value to Int and store it to variable n
        int n = Convert.ToInt32(Console.ReadLine());
        
        // Create a new List called myArray
        List<int> myArray = new List<int>();
        
        // The while loop will allow user to keep enter new int variables
        // based on the size of the List
        while(count != n)
        {
            // Convert userinput to int
            int userIn = Convert.ToInt32(Console.ReadLine());
            
            // The converted int input is added to myArray
            myArray.Add(userIn);
            
            // Add value of 1 to counter
            count++;
        }
        
        // Display the total value of the int List.
        Console.WriteLine(simpleArraySum(myArray));
    }
}
// Modification: Added comments. Modified the original problem to accept
//               List<T> instead of regular array. Modified the Main method
//               to request user to input custom size and values for the list
//               using while loop.

// Analysis:     This is my modified solution to my original solution to the problem
//               that used int[] array. Using List<T>, this modified solution asks
//               users to input their own size and values in the Main method. Once,
//               the user finishes with the inputs, the program then sums all the int
//               values in the List and returns the total sum.

// Output:
// Please enter a size (of integer) for the List
// 5
// Enter your values:
// 23
// 5
// 7
// 9
// 1
// Total:45
