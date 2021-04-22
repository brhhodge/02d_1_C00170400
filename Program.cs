// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02d_1

using System;

namespace _02d_1_C00170400
{
    class Program
    {
        static void Main(string[] args)
        {
            Dirt sample_1 = new Dirt(); // dirt class object created using default constructor from compiler
            Dirt sample_2 = new Dirt{Grams_sand = 0.89, Grams_clay = 0.47}; // dirt class object created using object initializer notation
            Dirt sample_3 = new Dirt{Grams_sand = 0.32, Grams_clay = 0.75}; // dirt class object created using object initializer notation

            // Print statements to display each dirt class object's initial values 
            Console.WriteLine("Sample_1: " + sample_1.Grams_clay + " grams of clay; " + sample_1.Grams_sand + " grams of sand");
            Console.WriteLine("Sample_2: " + sample_2.Grams_clay + " grams of clay; " + sample_2.Grams_sand + " grams of sand");
            Console.WriteLine("Sample_3: " + sample_3.Grams_clay + " grams of clay; " + sample_3.Grams_sand + " grams of sand");

            Console.WriteLine();

            // Dirt class properties calls and print statements to show functioning of dirt class properties and set/get functions, along with their newly set values
            sample_1.Grams_clay = 0.25;
            sample_1.Grams_sand = 0.75;
            Console.WriteLine("Sample_1: " + sample_1.Grams_clay + " grams of clay; " + sample_1.Grams_sand + " grams of sand");
            sample_2.Grams_clay = 0.69;
            sample_2.Grams_sand = 0.28;
            Console.WriteLine("Sample_2: " + sample_2.Grams_clay + " grams of clay; " + sample_2.Grams_sand + " grams of sand");
            sample_3.Grams_clay = 0.18;
            sample_3.Grams_sand = 0.81;
            Console.WriteLine("Sample_3: " + sample_3.Grams_clay + " grams of clay; " + sample_3.Grams_sand + " grams of sand");

            Console.WriteLine();

            // Overridden ToString() method call to demonstrate proper method functiong 
            Console.WriteLine(sample_1.ToString());
            Console.WriteLine(sample_2.ToString());
            Console.WriteLine(sample_3.ToString());

            Console.WriteLine();

            // Print statements and calling of read-only expression bodied method to demonstrate proper functioning
            Console.WriteLine("Sample_1's combined clay and sand weight is " + sample_1.Sum + " grams");
            Console.WriteLine("Sample_2's combined clay and sand weight is " + sample_2.Sum + " grams");
            Console.WriteLine("Sample_3's combined clay and sand weight is " + sample_3.Sum + " grams");

        }
    }
}
