// Source: https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
// C# Coding Questions For Technical Interviews
// Author: Ankit Sharma
// Student: Joseph Hong
// Synopsis: The original problem asks for removing duplicate characters. This program
//           goes a bit further and checks for duplicate words in a sentence. It then
//           outputs the unique words in the sentence, the duplicate word(s), number
//           of times the duplicate word(s) appear, and then calculates the percentage
//           of duplicate occurrence.

using System;
using System.Collections.Generic;

class CheckDupeWords
{
    static void Main(string[] args)
    {
        void checkDupes(string str)
        {
            // Using the string.Split() to separate
            // each words in a string into an array
            string[] ss = str.Split(' ');

            // The counter variable counts the occurrences
            // of number of duplicates in the string (if any)
            int count = 0;

            // Two lists are created: One for a unique list called
            // myList, and one for a duplicate list.
            var myList = new List<string>();
            var duplicates = new List<string>();

            // Iterate through each "element" of the string array.
            foreach (var s in ss)
            {
                // Check to see if the unique list contains an existing
                // word. If not, add them to the list.
                if (!myList.Contains(s))
                    myList.Add(s);

                // Duplicate words are added to the Duplicate list
                // and increments the duplicate counter by 1.
                else
                {
                    duplicates.Add(s);
                    count++;
                }

            }

            Console.WriteLine("List without duplicates: ");
            // show list without duplicates 
            foreach (var s in myList)
                Console.WriteLine(s);

            Console.WriteLine("Duplicate List: ");
            // show duplicates list
            foreach (var s in duplicates)
            {
                Console.WriteLine(s);
            }
            // Display the number of duplicates
            Console.WriteLine("Number of Duplicates: " + count);

            // Convert int variable count and int value of the Length of string
            // to type double. This will allow percentage calculation rather
            // than allowing the calculations to round down to the lowest integer.
            double avg = (double)count / (double)ss.Length;
            Console.WriteLine("Percentage of Duplicates = " + avg);
        }
        Console.WriteLine("Please enter a sentence:");
        string userstr = Console.ReadLine();
        checkDupes(userstr);
    }
}

// Modification:  Added comments. Modified the program to output the unique words
//                as well as the words that are repeated. Includes the number of
//                duplicate words that appear in the string and also calculates the
//                percentage of duplicates in the string.

// Analysis:      The program uses foreach to loop through and search for unique
//                words that do not currently exist in a List. These unique words
//                are then added to this list. The loop also checks for duplicates
//                and places the word(s) into a separate duplicate list. Each time
//                a duplicate word is found, it adds to the counter, which is then
//                used to find the percentage of these words in the Length of the
//                string.

// Output:
// Please enter a sentence:
// here there every where there here
// List without duplicates:
// here
// there
// every
// where
// Duplicate List:
// there
// here
// Number of Duplicates: 2
// Percentage of Duplicates = 0.333333333333333
