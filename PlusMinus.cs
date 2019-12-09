// Source: https://www.hackerrank.com/challenges/plus-minus/problem
// Plus Minus
// Author: hackerrank.com
// Student: Joseph Hong
// Synopsis: Given an array of integers, calculate the fractions of its 
//           elements that are positive, negative, and are zeros. Print 
//           the decimal value of each fraction on a new line.

using System;

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        // Three int variables are declared
        // to keep as "counters" and initialized
        // to 0.
        int posCount = 0;
        int negCount = 0;
        int zCount = 0;
        
        // Double variables are used
        // for positive, negative,
        // and zero values.
        double avg1, avg2, avg3;
        
        // For loop goes through the array
        // and keeps individual counters based
        // on the int values in the array.
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > 0) {
                posCount+=1;
            }
            else if(arr[i] < 0) {
                negCount += 1;
            }
            else {
                zCount += 1;
            }
        }
        // Each of the count variables are converted
        // to type double.
        avg1 = (double)posCount / arr.Length;
        avg2 = (double)negCount / arr.Length;
        avg3 = (double)zCount / arr.Length;
        
        // Outputs the ratio of the number occurrence of
        // positive, negative, and zero values, if any.
        Console.WriteLine(avg1 + "\n" + avg2 + "\n" + avg3);
    }

    static void Main(string[] args) {
        // Array with hardcoded int values.
        int[] arr = { 1, 3, -5, 17, 20, -13, 0}
        
        // Call the calculating method
        plusMinus(arr);
    }
}

// Modification:  Removed unncessary namespaces. Added comments.
//                Created my own method that calculates and
//                outputs the ratio. Modified the Main method
//                to include hardcoded array of values.

// Analysis:      This is my solution to the coding problem. It
//                simply counts the number of times each positive,
//                negative, and zero values appear in the array.
//                The counters are then coverted to type double so
//                that the ratio can be properly calculated, as the
//                program will output the wrong calculation if they
//                are not converted (e.g. if postive counter is 1
//                (and the length of the array is 10, it will output
//                0 instead of 0.1).

// Output:
// 0.571428571428571
// 0.285714285714286
// 0.142857142857143
