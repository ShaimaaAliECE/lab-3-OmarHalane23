using System.Collections.Generic;
using System.Diagnostics;
using System;
namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description) { }

        public virtual void DoAction()
        {
            // Base Tool action
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
        }
    }
}