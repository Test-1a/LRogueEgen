using System;

namespace LRogueEgen
{
    internal interface IDrawable
    {
        ConsoleColor Color { get; set; }
        string Symbol { get; }
    }
}