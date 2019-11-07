using System;
using System.Linq;

namespace LRogueEgen
{
    internal static class UI    //pga vill ha enbart 1 UI, inte flera UI
    {
        internal static void Draw(Map map)
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);

                    //if cell is null we do not try to access "Color"
                    //Console.ForegroundColor = cell?.Color ?? ConsoleColor.White;    //if cell?.Color == null 
                    //we chose ConsoleColor.White again


                    //removed due to Extensions
                    //IDrawable drawable = map.CreatureAt(cell) ?? cell;    //check if a creature is in the cell

                    //removed when we started to add Items to the map (see below)
                    //Extensions
                    //IDrawable drawable = map.Creatures.CreatureAtExten(cell) ?? cell;   //CreaturAtExten är en Extension-metod
                    //som man kommer åt via NameSpace

                    IDrawable drawable = map.Creatures.CreatureAtExten(cell) ??
                        (IDrawable)cell.Items.FirstOrDefault() ??
                        cell;
                    
                    //var drawable = map.Creatures.FirstOrDefault((x) => x.Cell == cell) as IDrawable ?? cell;

                    //removed due to "IDrawable drawable = map.CreatureAt(cell) ?? cell;"
                    //foreach (var creature in map.Creatures)
                    //{
                    //    if (creature.Cell == cell)
                    //    {
                    //        drawable = creature;
                    //        break;
                    //    }
                    //}

                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable?.Symbol);

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        internal static ConsoleKey GetKey()
        {
            return Console.ReadKey(intercept: true).Key;
        }

        internal static void clear()
        {
           // Console.Clear();
            Console.SetCursorPosition(0, 0);    //Not blinking
            Console.CursorVisible = false;
        }
    }
}