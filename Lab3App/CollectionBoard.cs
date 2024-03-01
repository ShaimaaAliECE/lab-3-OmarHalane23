using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class CollectionBoard
    {
        public int TotalScore { get; set; }
        public int TotalValue { get; set; }

        // Method to update total score
        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
        }

        // Method to update total value
        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
        }
    } // This is the end of the class definition.
}