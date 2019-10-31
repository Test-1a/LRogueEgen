using System;

namespace LRogueEgen
{
    internal class Game
    {
        private Map map;
        private Hero hero;
        private bool gameInProgress;

        public Game()
        {
        }

        internal void Run()
        {
            Initialize();
            Play();
        }

        private void Play()     //this is during the game
        {
            do
            {
                DrawMap();
            } while (gameInProgress);
           // do
           // {
           //   draw map
           //   get command
           //   execute action
           //   draw map
           //enemy actions
           //   
           // } while game in progress (true);
        }

        private void DrawMap()
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    Cell cell = map.GetCell(y, x);
                                        
                    //Console.ForegroundColor = cell?.Color;  //if cell is null we do not try to access "Color"
                    //Console.ForegroundColor = cell?.Color ?? ConsoleColor.White;    //if cell?.Color == null 
                                                                                    //we chose ConsoleColor.White again
                    //Console.Write(cell.Symbol);
                    IDrawable drawable = cell;

                    foreach (var creature in map.Creatures)
                    {
                        if(creature.Cell == cell)
                        {
                            drawable = creature;
                            break;
                        }
                    }
                    Console.ForegroundColor = drawable?.Color ?? ConsoleColor.White;
                    Console.Write(drawable?.Symbol);

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void Initialize()   //this is done once before the game starts
        {
            //ToDo: Read from config file later
            map = new Map(width: 10, height: 10);    //Start by creating the gameplan
                                                     //hardcode the size of the map

            var heroCell = map.GetCell(0, 0);

            hero = new Hero(heroCell);
            map.Creatures.Add(hero);
        }

    }
}