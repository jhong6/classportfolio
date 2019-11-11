// Source: https://www.tutlane.com/tutorial/csharp/csharp-constructors-with-examples
// C# Constructors With Examples
// Author: Tutlane.com
// Student: Joseph Hong
// Download Date: 11/5/19
// Synopsis: A single class with multiple constructors with unique parameters

using System;

namespace ClassConstructorOverload
{
    class User
    {
        // By default, constructor members are private and usually
        // require auto-implemented properties (or getters/setters)
        // when these variables are needed. Since these variables are
        // public, there is no need for the properties.
        public string name, location;
        public int age, salary;

        // A default constructor with specified string values, name
        // and location.
        public User()
        {
            name = "Suresh Dasari";
            location = "Hyderabad";
        }
        // This constructor takes two string values and assigns them
        // to the specified variables.
        public User(string a, string b)
        {
            name = a;
            location = b;
        }

        // Constructor takes int variables and assigns them to the
        // int variables.
        public User(int x, int s)
        {
            age = x;
            salary = s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // This instantiates an object and will use the default constructor
            User user = new User();
            
            // Instantiates another object but uses the constructor that accepts two
            // string values.
            User user1 = new User("Rohini Alavala", "Guntur");

            // This creates another object that takes int values.
            User user2 = new User(35, 90000);

            // Displays the default values for string variables, name and location.
            Console.WriteLine(user.name + ", " + user.location);

            // Displays the constructor with new string values specified at the instantiation
            Console.WriteLine(user1.name + ", " + user1.location);
            
            // Displays the constructor with int values for its parameters
            Console.WriteLine("Age is: " + user2.age + "\tSalary: " + user2.salary);

            Console.WriteLine("\nPress Enter Key to Exit");
            Console.ReadLine();
        }
    }
}

// Modification: Added comments. Added two public int variables, age and salary, and
//               created a third constructor that took these values. The main method
//               also demonstrates the use of this constructor.

// Analysis:     A class can have multiple constructors and each of these constructors can
//               have different parameters. If no constructor is specified in the class, then
//               a default constructor is created and sets the member variables to default values
//               based on the Default Values Table.

/* Sample Output:
 * Suresh Dasari, Hyderabad
 * Rohini Alavala, Guntur
 * Age is: 35      Salary: 90000
 *
 * Press Enter Key to Exit
*/
