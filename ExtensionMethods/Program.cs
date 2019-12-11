// Source: https://www.geeksforgeeks.org/extension-method-in-c-sharp/
// Extension Method in C#
// Author: ankita_saini
// Student: Joseph Hong
// Synopsis: Extension method allows adding new methods in the
//           exisiting class without modifying the source code
//           of the original type.

using System;
namespace ExtensionMethod
{
  public class GFG 
  { 
    // Main Method 
    public static void Main(string[] args) 
    { 
        // Instantiate a new object called g from
        // class Geek and has access to all methods
        Geek g = new Geek(); 
        
        // Call all the methods, including
        g.M1(); 
        g.M2(); 
        g.M3(); 
        g.M4(); 
        g.M5("This is the 5th method"); 
    } 
}

 // Modification: Minimum. Added comments and 2
 //               custom methods.
  
 // Analysis:     The program simply demonstrates
 //               accessing different methods
 //               by using the binding parameter
 //               (using "this" keyword).
 
 // Output:
 // Method Name: M1
 // Enter your name:
 // Bob
 // Hello Bob
 // Enter a value for x:
 // 3
 // Enter a value for y:
 // The sum of the two is: 5
 // Method Method Name: M4
 // This is the 5th method
