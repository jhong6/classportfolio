// Source: https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews/
// C# Coding Questions For Technical Interviews
// Author: Ankit Sharma
// Student: Joseph Hong
// Synopsis: Q.2: How to find if the given string is a palindrome or not?
//                The user will input a string and we need to print “Palindrome” or 
//                “Not Palindrome” based on whether the input string is a palindrome or not.

using System;
using System.Text.RegularExpressions;

class CheckPalindrome.cs
    {
        static void Main(string[] args)
        {
        string isItPalindrome(string str2)
            {
                // Consider capitals, white spaces, special characters, and numbers
                // for this Palindrome? If yes, use Regex.Replace() to remove them.
                // If not, then simply use string.Replace(" ",""). The latter method
                // creates an array of string into individual elements when a white
                // space is in the string.
                
                // This reassigns the original string removing every special characters
                // and spaces, and pushes the letters together.
                str2 = Regex.Replace(str2, @"[^a-zA-Z]+", "");
                
                // This for loop has two variables int i, and int j. The former
                // will iterate from the start of the string while the latter
                // will start from the end.
                for (int i = 0, j = str2.Length - 1; i < str2.Length; i++, j--)
                {
                    // The elements from both ends are compared and if any time
                    // neither elements are equal, this will immediately terminate
                    // the loop and output the string, "Not a Palindrome"
                    if (str2[i] != str2[j])
                    {
                        return "Not a Palindrome";
                    }
                }
                // If every letter is matching, then it returns "Is a Palindrome."
                return "Is a Palindrome";
            }
        Console.WriteLine("Please Enter a string: ");
        string userstring = Console.ReadLine();
        Console.WriteLine(isItPalindrome(userstring));
        }
    }
// Modification:  Added comments. Added my own methods and also
//                included Regex class and its method, Replace()
//                to remove non-alphabetical values in the string.
//                Added the ability for user to input custom string.

// Analysis:      This is a modified answer to the author's solution.
//                Instead of having boolean variables to return a string,
//                I simply modified the method to return "Is a Palindrome"
//                or "Is Not a Palindrome." Additionally, this modified
//                program checks for edge cases like special characters
//                and white spaces. Without using either Regex.Replace()
//                or string.Replace(), the method may erroneously return
//                incorrect string especially if the program's function
//                is to simply look for letters. E.g. "Nurses run" will
//                cause an error since "N" does not equate "n" and the
//                space will be counted against the intended logic.

// Output:
// Please Enter a string:
// toMa moT
// Is a Palindrome
