using System;
using System.Collections.Generic;
using System.Linq;

namespace LRogueEgen
{
    internal class Map  //knows where all creature are
    {
        //private readonly int width;     //readonly => cannot be changed during the game
       // private readonly int height;

        public int Width { get; }
        public int Height { get; }

        //public int MyProperty { get; set; }

       // public int Width => width;  //this means the same as the method for height
       // public int Height { get { return height; } }

        private readonly Cell[,] cells; //2-dimentionell array (will be
                                        //filled by cells)

        public List<Creature> Creatures { get; set; } = new List<Creature>();

        public Map(int width, int height)
        {
            this.Width = width;
            this.Height = height;

            cells = new Cell[height, width];    //kvadratisk spelplan (antal rader och antal kolumner)
                                                //contains storageboxes for cells
                                                //all positions are now "null" (contains no cells)

            for (int y = 0; y < height; y++)    //here the spelplan is filled with cells
            {
                for (int x = 0; x < width; x++)
                {
                    cells[y, x] = new Cell(y, x);
                }
            }

        }

        internal IDrawable CreatureAt(Cell cell)    //
        {
            //Returns creature as IDrawable if the cell contains any creature
            return Creatures.FirstOrDefault(creature => creature.Cell == cell);  //LINQ kan köras på alla Collections
        }

        internal Cell GetCell(int y, int x)   //ändra från "object" to "Cell"
        {                                     //logik för spelplanen
            //return cells[y, x];

            if (x < 0 || x >= Width || y < 0 || y >= Height) return null;
            return cells[y, x];
            

        }
    }
}