using System.Collections.Generic;
using System.Diagnostics;
using System;
namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }

        public void UpdateTotalValue()
        {
            Board.UpdateTotalValue(Value);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
            Console.WriteLine($"Total Value is updated to: {Board.TotalValue}");
        }
        public override void Display()
        {
            Console.WriteLine($"Coin {Description} is displayed");
        }
    }
}