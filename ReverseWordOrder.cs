// Source: https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
// C# Coding Questions For Technical Interviews
// Author: Ankit Sharma
// Student: Joseph Hong
// Synopsis: Q.3: How to reverse the order of words in a given string?
//                The user will input a sentence and we need to reverse the sequence of 
//                words in the sentence.

using System;

class ReverseWordOrder
{
    static void Main(string[] args)
    {
        // Declare a method that takes a string
        // in its parameter
        void reversWordOrderString(string str1)
        {
            // Using string.Split() method and specifying
            // the space, the original string now returns
            // like an array of strings separated by space 
            // character (e.g. "Hello World" will be similar 
            // to: Hello is now in index[0] and World is now 
            // index[1]. And this new value is assigned to
            // a string array.
            string[] array = str1.Split(' ');
            
            // This temp will be used to append each element
            // of the array into a string.
            string temp = "";
            
            // The for loop will start from the end and iterates
            // through each element.
            for (int i = array.Length - 1; i >= 0; i--)
            {
                // The temp string appends each element.
                temp += array[i] + " ";
            }
            // Using the string.Trim() removes the extra space
            // after the final element.
            Console.Write(temp.Trim());
        }
        
        Console.WriteLine("Please enter a string:");
        string userIn = Console.ReadLine();
        reversWordOrderString(userIn);
    }
}

// Modification: Added comments. Included string.Split() and
//               string.Trim() methods. Added user interaction.

// Analysis:     This is my own solution to the problem. It simply
//               uses only one for loop to iterate through the element
//               of arrays, which is then added to an empty string. But
//               it requires the use of string.Split() to be stored into
//               an array for the loop. It also requires the declaration
//               of a new string.

// Output:
// Please enter a string:
// welcome to This area!
// area! This to welcome
