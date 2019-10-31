using System.Collections.Generic;

namespace LRogueEgen
{
    internal class Cell
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public string Symbol => ". ";   //public string Symbol { get { return ". "; } }

        //public string Symbol
        //{
        //    get
        //    {
        //        return ". ";
        //    }
        //}

        public Creature Creature { get; set; }

        
    }
}