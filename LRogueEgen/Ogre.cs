namespace LRogueEgen
{
    internal class Ogre : Creature
    {
        public Ogre(Cell cell) :base(cell, "O ")
        {
            Color = System.ConsoleColor.Cyan;
            Damage = 25;
            Maxhealth = 125;
        }
    }
}