using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Collectable : Displayable// Removed the semicolon here
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        protected Collectable(string description) // This is correct, assuming there's no misplaced code around
        {
            Description = description;
        }

        public abstract void AddMe(List<Collectable> list);

        public virtual void Display()
        {
            Console.WriteLine($"{Description} is displayed");
        }
    }
} 