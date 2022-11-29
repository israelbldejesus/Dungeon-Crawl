using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Monster
    {
        /// This is the health of the monster.
        public int HP;

        /// This will determine the base HP and Attack.
        public int Level;

        /// This is how much damage the monster does
        public int Attack;

        /// This is the factor that will determine chance of blocking attack.
        public int Armor;

        /// This is the stat that will determine chance of hitting.
        public int Dexterity;

        /// This determines if a monster is a boss.
        public bool Boss;

        /// This list will contain all the types of monsters.
        public List<Monster> MonsterType;

        /// This is the experience the monster will drop when defeated.
        public int XP;

        public Room Room
        {
            get => default;
            set
            {
            }
        }

        /// This will calculate the stats for the mosnter.
        public void CalcMosnterStats()
        {
            throw new System.NotImplementedException();
        }
    }
}