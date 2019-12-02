// Source: https://www.sanfoundry.com/csharp-program-multilevel-inheritance/
// 
//Simple program demonstrating multilevel inheritance
using System;

namespace MultiLevelInheritance
{
    //Program inherits from class vehicle
    class Program : vehicle
    {
        public void Noise()
        {
            Console.WriteLine("All vehicles creates noise !!");
        }
        public void noiseLevel(int n)
        {
            if (n == 1)
                Console.WriteLine("Cars can be quiet or somewhat loud!");
            else
                Console.WriteLine("This type of transportation is loud!");
        }
        static void Main(string[] args)
        {
            int userinput;
            Program obj = new Program();
            obj.mode();
            Console.WriteLine("Please enter a number to see ways of transport:" +
                             "\n1: Car\t 2: Ship\t 3: Plane\t Default: Train");
            userinput = Convert.ToInt32(Console.ReadLine());
            obj.modeSelection(userinput);
            obj.feature();
            obj.Noise();
            obj.noiseLevel(userinput);
            Console.Read();
        }
    }
    class Mode
    {
        public void mode()
        {
            Console.WriteLine("There are Many Modes of Transport !!");
        }
        public void modeSelection(int n)
        {
            if (n == 1)
                Console.WriteLine("Transporting by car");
            else if (n == 2)
                Console.WriteLine("Transporting by ship");
            else if (n == 3)
                Console.WriteLine("Transporting by plane");
            else
                Console.WriteLine("Transporting by train");
        }
    }
    //Vehicle inherits from Mode
    class vehicle : Mode
    {
        public void feature()
        {
            Console.WriteLine("They Mainly Help in Traveling !!");
        }
    }
}
