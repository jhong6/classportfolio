// Source: www.codewars.com
// Is this a triangle?
// Author: silentZaika
// Student: Joseph Hong
// Synopsis: This is my solution to find if three
//           integers that are passed into the method
//           finds if they can be used to create a
//           triangle.

namespace CodeSamples
{
    class Program
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            // This condition checks to make sure
            // at least one side is not 0 or negative
            // as no side can be these values.
            if (a <= 0 || b <= 0 || c <= 0)
                return false;

            // Use the Triangle Theorem: Sum of 2 sides of 
            // a triangle must be greater than the third side.
            else if (a + b > c && b + c > a && a + c > b)
                return true;

            // If the sides are positive but do not meet the
            // Theorem's condition, then return false.
            else
                return false;
        }
        static void Main(string[] args)
        {
            // Input 3 values: 5, 7, 9
            Console.WriteLine(IsTriangle(5, 7, 9));
        }
    }
}
// Modification: Added my solution to the problem. Added Comments.
//               Added Main to call the method with three integers.

// Analysis:     This is one of many solutions in creating a method
//               to see if provided values is enough to create a triangle.
//               Alternative solution is using switch statements instead of
//               if/else statements.

// Output:
// 
// True
