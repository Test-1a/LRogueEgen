using System;
using System.Collections.Generic;

namespace LRogueEgen
{
    internal class Cell : IDrawable
    {
        public int X { get;  }
        public int Y { get; }

        public Cell(int y, int x)
        {
            Color = ConsoleColor.Red;
            X = x;
            Y = y;
        }

        public List<Item> Items { get; set; } = new List<Item>();
        public string Symbol => ". ";   //public string Symbol { get { return ". "; } }

        //public string Symbol      // this means the same as above 
        //{
        //    get
        //    {
        //        return ". ";
        //    }
        //}

        public ConsoleColor Color { get; set; }

        public Creature Creature { get; set; }


    }
}