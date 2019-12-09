// Source: https://www.tutlane.com/tutorial/csharp/csharp-binarywriter
// C# BinaryWriter
// Author: Tutlane.com
// Student: Joseph Hong
// Synopsis: This short program demonstrates creating a binary file using
//           the BinaryWriter class.

using System;
using System.IO;

namespace BinaryWriterExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This simple program uses BinaryWriter to create" +
                              " a binary file.\nPlease enter a valid file path " +
                              "(e.g. C:\\example.txt): ");
            string fpath = Console.ReadLine();

            string filedrive = "";
            // The for statement stores the drive letter inputted by the user. For example,
            // the "C:\" will be stored from the input, "C:\myexample.txt." This will then
            // be used to check if this hard drive exists.
            for (int i = 0; i < 3; i++)
            {
                filedrive += fpath[i];
            }
            // Use the File class's Exists method to check if the file exists

            if (File.Exists(fpath))
                // If the file alaready exists, then delete the file.
            {
                Console.WriteLine("{0} already exists. Deleting the file...",fpath);
                File.Delete(fpath);

            }
            // Use the stored drive letter from the variable, filedrive, to check if
            // the hard drive exists.
            else if(!Directory.Exists(filedrive))
            {
                // If the hard drive does not exist, then display message
                // and end the program.
                Console.WriteLine("The specified drive does not exist.");
                return;
            }

            else
            {
                Console.WriteLine("Writing new binary file...");
            }
            // Instantiates the BinaryWriter object and uses the filepath in the parameters
            // specified the user to Open the filestream and create the binary file.
            using (BinaryWriter bw = new BinaryWriter(File.Open(fpath, FileMode.Create)))

            {
                // The Write method is used to store the following values to the binary file.

                bw.Write(1.25);

                bw.Write("Welcome to Tutlane");

                bw.Write(10);

                bw.Write(true);

                bw.Write("test");

            }
            Console.WriteLine("Binary file success.");
        }
    }
}
// Modification: Added a new string variable that is used to check if the specific hard drive
//               inputted by the user. Added limited user interactions and additional comments.

// Analysis: The BinaryWriter class enables writing primitive data to a stream (as seen from above,
//           the Boolean value "true" is added to the file stream. Unless specified, the encoding
//           type is UTF-8 by default (as shown when the created file is opened in Notepad).

/* Output:
 * This simple program uses BinaryWriter to create a binary file.
 * Please enter a valid file path (e.g. C:\example.txt):
 * D:\test.txt
 * Writing new binary file...
 * Binary file success.
*/
