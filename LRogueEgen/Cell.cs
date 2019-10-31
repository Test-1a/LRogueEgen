using System.Collections.Generic;

namespace LRogueEgen
{
    internal class Cell
    {
        public List<Item> Items { get; set; } = new List<Item>();
        private readonly string symbol;

        public Cell(string symbol)
        {
            symbol = ".";
        }
    }
}