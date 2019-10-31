using System;

namespace LRogueEgen
{
    internal class Map
    {
        private readonly int width;     //readonly => cannot be changed during the game
        private readonly int height;

        //public int MyProperty { get; set; }

        public int Width => width;  //this means the same as the method for height
        public int Height { get { return height; } }

        private readonly Cell[,] cells; //2-dimentionell array (will be
                                        //filled by cells)

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;

            cells = new Cell[height, width];    //kvadratisk spelplan (antal rader och antal kolumner)
                                                //contains storageboxes for cells
                                                //all positions are now "null" (contains no cells)

            for (int y = 0; y < height; y++)    //here the spelplan is filled with cells
            {
                for (int x = 0; x < width; x++)
                {
                    cells[x, y] = new Cell();
                }
            }

        }

        internal Cell GetCell(int y, int x)   //ändra från "object" to "Cell"
        {
            return cells[y, x];
        }
    }
}