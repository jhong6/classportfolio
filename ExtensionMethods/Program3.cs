// Source: https://www.geeksforgeeks.org/extension-method-in-c-sharp/
// Extension Method in C#
// Author: ankita_saini
// Student: Joseph Hong
// Synopsis: Extension method allows adding new methods in the
//           exisiting class without modifying the source code
//           of the original type.

public class GFG { 
  
    // Main Method 
    public static void Main(string[] args) 
    { 
        // Instantiate a new object called g from
        // class Geek
        Geek g = new Geek(); 
        
        // Call all the methods, including
        g.M1(); 
        g.M2(); 
        g.M3(); 
        g.M4(); 
        g.M5("Method Name: M5"); 
    } 
} 
