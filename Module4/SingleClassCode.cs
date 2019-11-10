// Source: https://csharp.net-tutorials.com/classes/introduction/
// Introduction to C# classes
// Author: csharp.net-tutorials.com
// Student: Joseph Hong
// Download Date: Oct 31, 2019
// Synopsis: A simple demonstration creating a class and using its constructor
//           to set values when an object is created.

using System;

namespace ClassSampleCode
{
    class Program
    {
        static void Main(string[] args)
        {
            // A variable of type Car is declared
            Car car;

            // Using the keyword "new," a car object is instantiated with a string value
            // of "Red" and the object calls the Describe method from the Car class
            car = new Car("Green", "Ford", 1995);
            Console.WriteLine(car.Describe());

            // Same process as the previous instantiation but prompts for user inputs
            // instead, which are then passed on to the object's parameters
            Console.Write("Please enter your car's color: ");
            string userColor = Console.ReadLine();
            Console.Write("Please enter your car's make: ");
            string userMake = Console.ReadLine();
            Console.Write("Please enter your car's year: ");
            int carYear = Convert.ToInt32(Console.ReadLine());
            car = new Car(userColor, userMake, carYear);
            Console.WriteLine(car.Describe());

            Console.ReadLine();

        }
    }

    // Declaration of a class named "Car." Unless explicitly declared as public,
    // the default access modifier is internal for classes and structs
    // declared within the namespace (nested classes or structs can have
    // more access modifiers such as private or protected).
    class Car
    {
        // The access modifier of class members are private by default but
        // it is explicitly declared here for readability and maintainability
        private string Colors;
        private string Make;
        private int Year;

        // Constructor is a method that has the same name as its type (class or struct),
        // has a parameter list (optional) and does not have a return type. A default
        // constructor with default set of values is created if a constructor is not provided.
        public Car(string color, string make, int year)
        {
            //This keyword is used to refer to the hidden member (private string color)
            this.Colors = color;
            this.Make = make;
            this.Year = year;
        }

        // The method for the class takes no values and simply returns the property
        // called Color
        public string Describe()
        {
            return "This car is " + Color + ", and its make and year is " + carMake + " " + getYear;
        }

        // The properties Color, carMake, and getYear gets and sets the private 
        // string variables, color and carMake, and int variable, Year.
        public string Color
        {
            get { return Colors; }
            set { Colors = value; }
        }
        public string carMake
        {
            get { return Make; }
            set { Make = value; }
        }
        public int getYear
        {
            get { return Year; }
            set { Year = value; }
        }
    }
}
// Modifications: Modified Car class to accept additional string and int values, and added additional
//                getter and setter properties for the new values. Modified the Main method to
//                prompt for user's inputs. Added comments.


// Analysis:      Instantiates an object and calls the class method, and getters and setters.

/* Sample Output: 
 * This car is Green, and its make and year is Ford 1995
 * Please enter your car's color: Red
 * Please enter your car's make: Toyota
 * Please enter your car's year: 2005
 * This car is Red, and its make and year is Toyota 2005
*/
