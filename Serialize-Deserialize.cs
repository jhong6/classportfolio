// Source: https://docs.microsoft.com/en-us/dotnet/standard/serialization/basic-serialization
// Basic Serialization
// Author: Microsoft
// Student: Joseph Hong
// Synopsis: This basic program demonstrates the serialization of an instance of a serializable class
//           to a file using binary formatter.

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializeDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates MyObject obj using the default constructor
            MyObject obj = new MyObject();

            // The public variables are assigned with new values for obj
            Console.WriteLine("Please enter a value for n1: ");
            obj.n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a value for n2: ");
            obj.n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input a string: ");
            obj.str = Console.ReadLine();

            // An instance of the BinaryFormatter class is created (using default values) and
            // is stored into the declared IFormatter variable. The IFormatter interface gives
            // the proper functions for formatting serialized objects.
            IFormatter formatter = new BinaryFormatter();

            // An instance of a FileStream is created along with a specified file path and name,
            // creation mode, write permission, and prevents requests to open the file until it
            // is closed.
            Stream stream = new FileStream(@"D:\Myfile.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            // Serializes the object
            formatter.Serialize(stream, obj);
            // Closes the stream
            stream.Close();

            // Similar to the previous instance of creating a stream, this instead looks for the .bin file
            // and opens and reads the contents of specified binary file.
            stream = new FileStream(@"D:\Myfile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            // This deserializes the formatter interface into the original object through boxing.
            MyObject dObj = (MyObject)formatter.Deserialize(stream);

            // Display the readable values from the .bin file.
            Console.WriteLine(dObj.n1);
            Console.WriteLine(dObj.n2);
            Console.WriteLine(dObj.str);
        }

        // The [Serializable] attribute indicates that the class, MyObject
        // can be serialized.
        [Serializable]
        public class MyObject
        {
            public int n1 = 0;
            public int n2 = 0;
            public String str = null;
        }
    }
}

// Modification: Minimal modifications. Added comments and limited user interactions.

// Analysis:     In order to serialize using the BinaryFormatter, the class must have the
//               [Serializable] attribute, otherwise it will run into an exception. Although
//               not explicitly shown, the members with this attribute are all serialized,
//               regardless of the variables' access modifier (private variables are serialized)
//               Also, Deserializing the object (so that the original contents can be readable)
//               requires that the interface variable be cast back into the original class object.

/* Output:
 * Please enter a value for n1:
 * 5
 * Please enter a value for n2:
 * 291
 * Input a string:
 * a Simple string
 * 5
 * 291
 * a Simple string
*/
