 using System.Diagnostics;
using System;
namespace Lab3App
{
    public class Diamond : Treasure
    {
        public Diamond(string description, int score) : base(description, score) { }

        public override void Display()
        {
            // Specific display message for Diamond
            Console.WriteLine($"Dimond{Description} is displayed");
        }
    }
}