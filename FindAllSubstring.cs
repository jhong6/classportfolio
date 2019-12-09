// Source: https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
// C# Coding Questions For Technical Interviews
// Author: Ankit Sharma
// Student: Joseph Hong
// Synopsis: Q.7: How to find all possible substring of a given string?

using System;

class FindAllSubstring
{
    static void Main(string[] args)
    {
        // The method takes string value for its parameter
        void findallSubstr2(string str)
        {
            // Iterate through the string like an array
            for (int i = 0; i < str.Length; i++)
            {
                // Decalre a new empty string. That will override
                // each of the "old" string values appended from the
                // nested for loop.
                string mystring = "";
                
                // This second for loop starts based on the value of i.
                // If an integer value like 0 is entered, then this will
                // cause a display error and will repeat already displayed
                // string values, rather than iterating through the next
                // elements.
                for (int j = i; j < str.Length; j++)
                {
                    mystring += str[j];
                    Console.Write(mystring + " ");
                }
            }
        }
        
        Console.WriteLine("Please enter a string to find all possible substring:");
        string userIn = Console.ReadLine();
        findallSubstr2(userIn);
    }
}

// Modification:  Added comments. Included user interaction.
//                Uses simple string variable and not a StringBuilder.

// Analysis:      This is a modified solution from the author's input.
//                The program finds all the substrings (including spaces)
//                and displays them all. So if an input of "abc" is entered,
//                then we can expected to see: a ab abc b bc c. These substrings
//                are "found" through a nested for loop, where (instead of using a
//                hardcoded integer) it reassigns itself based on the integer of the
//                first for loop. This will avoid logical error and will prevent
//                displaying duplicates of the substrings.

// Output:
// Please enter a string to find all possible substring:
// abcdef
// a ab abc abcd abcde abcdef b bc bcd bcde bcdef c cd cde cdef d de def e ef f
