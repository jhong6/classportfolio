// Source: https://www.sanfoundry.com/csharp-program-create-file/
// C# Program to Create a File
// Author: Manish Bhojasia
// Student: Joseph Hong
// Synopsis: This program creates a text file with string values.

using System;
using System.IO;
using System.Text;

namespace FileReadCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // This prompts the user to specify the directory in which to create a file.
            Console.WriteLine("Enter the directory path\n" +
                              "(e.g. C:\\Documents):");

            // Declare a string variable for the directory path that stores the user's input.
            string textpath = Console.ReadLine();

            // The Exists method from the Directory Class is called to see if the path file is valid, or
            // checks to see if the specified drive exists.
            bool directoryExists = Directory.Exists(textpath);

            // If the bool variable is true, then the program executes the following implementations
            if(directoryExists)
            {
                Console.WriteLine("Please enter the name of the file you wish to create\n" +
                                  "(e.g. mytext.txt):");
                string textname = Console.ReadLine();
                // This using alias directive creates a variable type Filestream
                // and calls the Create() function to create the name of the file
                // based on the existing directory.
                using (FileStream fs = File.Create(textpath+textname))
                {
                    Console.WriteLine("Please enter values for your file:");
                    string userString = Console.ReadLine();
                    // An instantiation of UTF8Encoding class that calls the GetBytes
                    // method that encodes the string parameter into bytes, which is
                    // then assigned to the variable of type Byte.
                    Byte[] info = new UTF8Encoding(true).GetBytes(userString);

                    // The variable from the using alias directive calls the Write()
                    // method
                    fs.Write(info, 0, info.Length);
                }

                // Using alias directive calls the OpenText method that
                // opens an existing file (that was created previously)
                // based on the filepath.
                using (StreamReader sr = File.OpenText(textpath+textname))
                {
                    // Displays the text from the written until the end
                    // is reached
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                Console.Read();
            }

            // If the file path does not exist, then alert the user that the entered
            // string or path is invalid.
            else
            {
                Console.WriteLine("You have entered an invalid file path.");
            }
            Console.ReadLine();
        }
    }
}
// Modification:    Added comments and modified program to allow user interaction. Included the 
//                  method .Exists() from the Directory class that checks whether or not
//                  user's input for the file directory is valid.
//

// Analysis:        The program simply prompts the user to specify the directory, which is
//                  checked to see if it is valid, and then prompts the user to name the file
//                  and input custom values to be saved. The program then creates the file
//                  based on user's input (if the directory is valid, otherwise it ends the
//                  program) and then displays the contents of the newly created file using
//                  the OpenText() method from File Class and ReadLine() method.

/* Output:
 * Enter the directory path
 * (e.g. C:\Documents):
 * D:\
 * Please enter the name of the file you wish to create
 * (e.g. mytext.txt):
 * test1.txt
 * Please enter values for your file:
 * testing string
 * testing string
*/
