namespace LRogueEgen
{
    internal class Map
    {
        private readonly int width;     //cannot be changed during the game
        private readonly int height;

        private readonly Cell[,] cells; //2-dimentionell array av celler

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;

            cells = new Cell[height, width];    //kvadratisk spelplan
                                                //contains storageboxes for cells
                                                //all positions are now "null" (contains no cells)

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    cells[x, y] = new Cell();
                }
            }

        }
    }
}