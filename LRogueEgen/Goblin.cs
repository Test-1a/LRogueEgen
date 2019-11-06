namespace LRogueEgen
{
    internal class Goblin : Creature
    {
        public Goblin(Cell cell) :base(cell, "G ")
        {
            Damage = 15;
            Maxhealth = 25;
        }
    }
}