using System.Collections.Generic;
using System.Diagnostics;
using System;
namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        protected Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Board.UpdateTotalScore(Score); // Update the score.
            Console.WriteLine($"{Description} is collected, congrats!!!!");
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }
    }
}