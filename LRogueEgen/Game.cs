using System;

namespace LRogueEgen
{
    internal class Game
    {
        private Map map;
        private Hero hero;

        public Game()
        {
        }

        internal void Run()
        {
            Initialize();
            Play();
        }

        private void Play()
        {
            
        }

        private void Initialize()
        {
            //ToDo: Read from config file later
            map = new Map(width: 10, height: 10);    //Start by creating the gameplan
                                                         //hardcode the size of the map

            hero = new Hero();
        }

    }
}