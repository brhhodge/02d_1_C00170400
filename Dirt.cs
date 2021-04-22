// Brian Hodge
// C00170400
// CMPS 358
// Assignment #02d_1

using System;

namespace _02d_1_C00170400
{
    class Dirt
    {
        private double grams_sand = 0.0; // 2 private data member fields for amount in grams of clay and sand in sample
        private double grams_clay = 0.0; // "  "

        public double Grams_clay { get => grams_clay; set => grams_clay = value; } // public properties for each private data member
        public double Grams_sand { get => grams_sand; set => grams_sand = value; } // "  "

        public double Sum => sum;

        public double sum => Grams_clay + Grams_sand;

        public override string ToString()
        {
            return ("This sample has " + this.Grams_clay + " grams of clay, and  " + this.Grams_sand + " grams of sand");
        }

    }
}