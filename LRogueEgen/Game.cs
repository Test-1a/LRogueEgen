using System;
using System.Linq;

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
                //draw map
                DrawMap();

                //   get command
                GetInput();

                //draw map
                DrawMap();
            } while (true);                 //skillnad 1
            //} while (gameInProgress);     //skillnad 1

            // do
            // {

           
           //   execute action
           //   draw map
           //enemy actions
           //   
           // } while game in progress (true);
        }

        private void GetInput()
        {
            ConsoleKey keyPressed = UI.GetKey();

            switch (keyPressed)
            {
                case ConsoleKey.LeftArrow:
                    //Move(hero.Cell.X - 1, hero.Cell.Y);
                    Move(new Position(0, -1));
                    break;
                case ConsoleKey.UpArrow:
                    //Move(hero.Cell.X, hero.Cell.Y - 1);
                    Move(new Position(-1, 0));
                    break;
                case ConsoleKey.RightArrow:
                    //Move(hero.Cell.X + 1, hero.Cell.Y);
                    Move(new Position(0, 1));
                    break;
                case ConsoleKey.DownArrow:
                    //Move(hero.Cell.X, hero.Cell.Y + 1);
                    Move(new Position(1, 0));
                    break;
             }
        }

        //private void Move(int x, int y)
        private void Move(Position movement)
        {
            //var newPosition = map.GetCell(y, x);
            //if (newPosition != null) hero.Cell = newPosition;
            Position newPosition = hero.Cell.Position + movement;
            Cell newCell = map.GetCell(newPosition);
            if (newCell != null) hero.Cell = newCell;

        }

        private void DrawMap()
        {
            UI.clear();
            UI.Draw(map);
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