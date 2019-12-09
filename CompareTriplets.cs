// Source: https://www.hackerrank.com/challenges/compare-the-triplets/problem
// Compare the Triplets
// Author: hackerrank.com
// Student: Joseph Hong
// Synopsis: Alice and Bob each created one problem for HackerRank. 
//           A reviewer rates the two challenges, awarding points on a scale from
//           1 to 100 for three categories: problem clarity, originality, and difficulty.
//           Complete the function compareTriplets. Return an array of two integers 
//           denoting the respective comparison points earned by Alice and Bob.
//
//           Sample Input 
//
//           17 28 30
//           99 16 8
//           Sample Output 
//
//           2 1

using System;
using System.Collections.Generic;

class CompareTriplets
{
    static List<int> compareTriplets(List<int> a, List<int> b)
    {
        // Create a new List<int> which will tally up
        // the points earned by Alice and Bob
        List<int> result = new List<int>();

        // This will add 0 to the indices of [0] and [1], respectively.
        result.Add(0);
        result.Add(0);

        // This for loop will iterate through the Count of a's List
        // since both Lists are of the same Count.
        for (int i = 0; i < a.Count; i++)
        {
            // As the loop iterates through each element,
            // it will compare the values, adding value of 1
            // to index 0 if Alice has bigger value or to index
            // 1 if Bob's element is larger.
            if (a[i] > b[i])
            {
                result[0] += 1;
            }
            else if (a[i] < b[i])
            {
                result[1] += 1;
            }
        }
        // Returns the List with the total amount of Points earned
        // by Alice and Bob.
        return result;
    }
    static void Main(string[] args)
    {
        // Create two lists as test cases with int values
        List<int> alice = new List<int>() { 86, 98, 60 };
        List<int> bob = new List<int>() { 85, 100, 55 };

        // Create a new list that stores the result List
        // from the compareTriplets() method, as the results
        // List is local to the method being used.
        List<int> fsResult = compareTriplets(alice, bob);
        
        Console.WriteLine("Alice\tBob");

        // Simply use foreach to display the values of the fsResult
        foreach(var n in fsResult)
        {
            Console.Write(n + "\t");
        }
    }
}

// Modification:  Added comments. Modified the Main method to include
//                two Lists as the original code uses test cases
//                not available to the solver. Also included foreach
//                loop to display the List.

// Analysis:      This is a solution to a simple comparision problem. Based
//                on the values in the two Lists that are compared, the
//                List with the higher value receieves a point and vice versa.
//                These "points" are added to index of [0] or [1] (for Alice
//                and Bob, respectively) and the total "points" are displayed
//                when the method is called in Main.

// Output:
// Alice  Bob
// 2      1
