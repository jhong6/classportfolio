//Demonstration of using sealed class to prevent inheritance
using System;
//Create a sealed class with public access modifiers
sealed class SealedClass
{
    public int x;
    public int y;
}
 
class SealedTest
{
    //Driver method
    static void Main()
    {
        //Can only
        SealedClass sc = new SealedClass();
        sc.x = 110;
        sc.y = 150;
        Console.WriteLine("x = {0}, y = {1}", sc.x, sc.y);
        Console.ReadLine();
    }
}
//Source: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/sealed
