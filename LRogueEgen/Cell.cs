using System;
using System.Collections.Generic;

namespace LRogueEgen
{
    internal class Cell : IDrawable
    {
        public Cell()
        {
            Color = ConsoleColor.Red;
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