using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Monster
    {
        /// <summary>
        /// This is the health of the monster.
        /// </summary>
        public int HP;
        /// <summary>
        /// This will determine the base HP and Attack.
        /// </summary>
        public int Level;
        /// <summary>
        /// This is how much damage the monster does
        /// </summary>
        public int Attack;
        /// <summary>
        /// This is the factor that will determine chance of blocking attack.
        /// </summary>
        public int Armor;
        /// <summary>
        /// This is the stat that will determine chance of hitting.
        /// </summary>
        public int Dexterity;
        /// <summary>
        /// This determines if a monster is a boss.
        /// </summary>
        public bool Boss;
        /// <summary>
        /// This list will contain all the types of monsters.
        /// </summary>
        public List<Mosnter> MonsterType;

        public Room Room
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This will calculate the stats for the mosnter.
        /// </summary>
        public void CalcMosnterStats()
        {
            throw new System.NotImplementedException();
        }
    }
}