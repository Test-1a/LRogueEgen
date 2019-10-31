using System;

namespace LRogueEgen
{
    internal abstract class Creature : IDrawable  //is only a description so should not be instanceable
    {
        public Creature(Cell cell, string symbol)
        {
            Symbol = symbol;
            Cell = cell;    //creature vet i vilken cell den är
        }

        public ConsoleColor Color { get; set; } = ConsoleColor.Green;
        public string Symbol { get; } = "C ";   //Om inte Symbol är satt till något sätts den till "C "
                                                //defaultvalue

       public Cell Cell { get; }
    }
}