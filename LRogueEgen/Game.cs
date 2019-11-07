using System;
using System.Linq;
using System.Collections.Generic;

namespace LRogueEgen
{
    internal class Game
    {
        private Map map;
        private Hero hero;
        private bool gameInProgress = true;

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
            //} while (true);                 //skillnad 1
            } while (gameInProgress);     //skillnad 1

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
                    //Move(new Position(0, -1));
                    Move(Direction.W);
                    break;
                case ConsoleKey.UpArrow:
                    //Move(hero.Cell.X, hero.Cell.Y - 1);
                    //Move(new Position(-1, 0));
                    Move(Direction.N);
                    break;
                case ConsoleKey.RightArrow:
                    //Move(hero.Cell.X + 1, hero.Cell.Y);
                    //Move(new Position(0, 1));
                    Move(Direction.E);
                    break;
                case ConsoleKey.DownArrow:
                    //Move(hero.Cell.X, hero.Cell.Y + 1);
                    //Move(new Position(1, 0));
                    Move(Direction.S);
                    break;
                case ConsoleKey.P:
                    PickUp();
                    break;
                case ConsoleKey.I:
                    Inventory();
                    break;
                case ConsoleKey.Q:
                    gameInProgress = false;
                    break;
             }
        }

        private void Inventory()
        {
            foreach (var item in hero.Backpack)
            {
                Console.WriteLine(item);
            }
        }

        private void PickUp()
        {
            var items = hero.Cell.Items;
            var item = items.FirstOrDefault();
            if (item == null) return;
            if (hero.Backpack.Add(item)) items.Remove(item);
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
            map.Creatures.Add(new Goblin(map.GetCell(4, 7)));
            map.Creatures.Add(new Goblin(map.GetCell(2, 9)));
            map.Creatures.Add(new Ogre(map.GetCell(2, 8)));
            map.Creatures.Add(new Ogre(map.GetCell(8, 3)));
            map.GetCell(3, 3).Items.Add(Item.Coin());
            map.GetCell(3, 6).Items.Add(Item.Hat());
            map.GetCell(2, 2).Items.Add(Item.Coin());
            map.GetCell(3, 3).Items.Add(Item.Hat());
        }

    }
}