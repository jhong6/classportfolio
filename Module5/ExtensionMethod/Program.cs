using System;
namespace ExtensionMethod
{
    static class NewMethodClass
    {
        //Method 4
        public static void M4(this Geek g)
        {
            Console.WriteLine("Method Name: M4");
        }
        //Method 5
        public static void M5(this Geek g, string str)
        {
            Console.WriteLine(str);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geek g = new Geek();
            g.M1();
            g.M2();
            g.M3();
            g.M4();
            g.M5("Method Name: M5");
        }
    }
}
//Source: https://www.geeksforgeeks.org/extension-method-in-c-sharp/
