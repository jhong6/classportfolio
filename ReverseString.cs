// Source: https://ankitsharmablogs.com/csharp-coding-questions-for-technical-interviews
// C# Coding Questions For Technical Interviews
// Author: Ankit Sharma
// Student: Joseph Hong
// Synopsis: Q.1: How to reverse a string? The user will input a string and the method 
//                should return the reverse of that string

class ReverseString
    {
        static void Main(string[] args)
        {
            //Q1: Reverse a string input and return the reversed string
            
            // Declares a string method that takes a string value in
            // its parameter
            string ReverseString(string str1)
            {
                // Create new empty string
                string myNewString = "";
                
                // This for loop iterates from the end of
                // the string variable that is passed in the
                // method's parameter.
                for (int i = str1.Length - 1; i >= 0; i--)
                {
                    // As the loop starts, each "element"
                    // of the string is added to the new string
                    myNewString += str1[i];
                }
                
                // Return the fully appended string
                return myNewString;
            }
            // Prompt user to enter a string and store it to
            // a string variable.
            Console.WriteLine("Please enter a string: ");        
            string userinput = Console.ReadLine();
            
            // The ReverseString method is called using
            // the user's input in its parameter.
            Console.WriteLine(ReverseString(userinput));
         }
     }
 
// Modification: Added comments. Added limited user interaction
//               to allow custom strings for input.

// Analysis:      This is my own solution to the problem for reversing
//                a string. The author's solution uses char[] and appends
//                it to a new string variable. My solution instead creates
//                an empty string and appends each char of the original to
//                the new string. It also asks for user's custom string rather
//                than a hardcoded string values.

// Output:
// Please enter a string:
// Hello, There!
// !erehT ,oLLeH
