using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LRogueEgen
{
    static class Extensions
    {
        public static IDrawable CreatureAtExten(this IEnumerable<Creature> creatures, Cell cell)
        {
            return creatures.FirstOrDefault(c => c.Cell == cell);
        }
    }
}
