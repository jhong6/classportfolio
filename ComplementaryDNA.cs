// Source: https://www.codewars.com/kata/554e4a2f232cdd87d9000038
// ComplementarDNA
// Author: JustyFY
// Student: Joseph Hong
// Synopsis: Create a method to output the complementary values
//           of a DNA string.

using System;

namespace CodeSamples
{
    class ComplementaryDNA
    {
        public static string MakeComplement(string dna)
        {
            // Using the ToUpper() ensures that the string
            // is capitalized. Otherwise, the condition logic
            // in this method will not be met.
            dna = dna.ToUpper();

            // Create a new string variable to be used to append
            // each complement.
            string newdna = "";

            // For loop that goes through the provided
            // string and appends respective complements.
            for (int i = 0; i < dna.Length; i++)
            {
                if (dna[i] == 'A')
                    newdna += 'T';
                else if (dna[i] == 'T')
                    newdna += 'A';
                else if (dna[i] == 'G')
                    newdna += 'C';
                else if (dna[i] == 'C')
                    newdna += 'G';
            }

            // This returns the new string
            return newdna;
        }
            static void Main(string[] args)
        {
            // Calls the MakeComplement method
            // to return a new string based on the custom
            // input, "AATG"
            Console.WriteLine(MakeComplement("AATG"));
        }
    }
}
// Modification: My solution to the problem. Added comments. Added
//               Main method to call the solution's method along
//               with custom string value.

// Analysis:    The program simply converts DNA strings to each of
//              their respective complements: A and T would be
//              complements of each other, and C and G would be
//              complements. The program would set these complements
//              to a new string variable that is displayed when the method
//              is called in Main.

// Output:
// TTAC
