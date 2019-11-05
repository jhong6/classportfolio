using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloadingSample
{
    class User
    {
        public string name, location;
        public int age, salary;
        //Default constructor with default values
        public User()
        {
            name = "Suresh Dasari";
            location = "Hyderabad";
        }
        //Parameterized Constructor
        public User(string a, string b)
        {
            name = a;
            location = b;
        }

        //Another constructor but taking only int values
        //for age and salary
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
            User user = new User(); //Default Constructor will be called
            User user1 = new User("Rohini Alavala", "Guntur"); //Constructor with the specified parameters will be called
            User user2 = new User(35, 90000); //The constructor with int parameters will be called
            Console.WriteLine(user.name + ", " + user.location);
            Console.WriteLine(user1.name + ", " + user1.location);
            Console.WriteLine("Age is: " + user2.age + "\tSalary: " + user2.salary);
            Console.WriteLine("\nPress Enter Key to Exit");
            Console.ReadLine();
        }
    }
}
//Source: https://www.tutlane.com/tutorial/csharp/csharp-constructors-with-examples