using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DungeonCrawl
{
    public class Monster
    {
        //Constructor for monster. 
        public Monster(string mt, int l, int a, int ar, int d, int xp)
        {
            MonsterType = mt;
            Level = l;
            Attack = a;
            Armor = ar;
            Dexterity = d;
            XP = xp;
        }

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
        public string MonsterType;

        /// This is the experience the monster will drop when defeated.
        public int XP;

        /// This is describing the monster.
        public string Description;

        public Room Room
        {
            get => default;
            set
            {

            }
        }

        /// This will calculate the stats for the monster.
        public void CalcMosnterStats()
        {
            throw new System.NotImplementedException();
        }

        
    }
}