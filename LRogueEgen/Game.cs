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
                Draw();
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

        private void Draw()
        {
            throw new NotImplementedException();
        }

        private void Initialize()   //this is done once before the game starts
        {
            //ToDo: Read from config file later
            map = new Map(width: 10, height: 10);    //Start by creating the gameplan
                                                         //hardcode the size of the map

            hero = new Hero();
        }

    }
}