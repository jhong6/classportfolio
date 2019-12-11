// Source: https://www.w3resource.com/csharp-exercises/basic/index.php
// C# Sharp Basic Declarations and Expressions : Exercises, Practice, Solution #16
// Author: w3resource
// Student: Joseph
// Synopsis: This C# program creates a new string where the first and last character
//           will change their positions.

using System;
namespace BasicCSharpExercises
{
    class Program 
    {
        static void Main(string[] args)
        {
            string swapFandL(string mystring)
            {
                // Create an empty string
                string newstring = "";
                
                // Check to see if string can carry out the function
                if (mystring.Length < 2)
                {
                    return "Cannot swap";
                }
                else
                {   
                    // Start at index 1 and end at second to last index.
                    for (int i = 1; i < mystring.Length - 1; i++)
                    {
                        // Append the iterated values to the new string
                        newstring += mystring[i];
                    }
                    
                    // After the loop, append the last index first, followed by the new string,
                    // and the first value of the index.
                    newstring = mystring[mystring.Length - 1] + newstring + mystring[0];
                    return newstring;
                }
             }
             // Call the method
             Console.WriteLine(swapFandL("Hello!"));
         }
    }

// Modification:  Entirely re-written code that finds the same
//                results.

// Analysis:      My own solution to the problem, the author's
//                solution uses a built-in function, substring().
//                I instead iterated each element starting from
//                index 1 and second to last index. Then,
//                the new string variable is reassigned with
//                concatenating the last index value first, followed
//                by the appended string from the for loop, and finally
//                the first index.

// Output:
// !elloH
