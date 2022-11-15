using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Player
    {
        /// <summary>
        /// This will determine the base Attack and HP and Dexterity.
        /// </summary>
        public int Level = 1;
        /// <summary>
        /// This is the health of the player.
        /// </summary>
        public int HP = 100;//depends on level and race
        /// <summary>
        /// This is the base attack of the player.
        /// </summary>
        public int Attack = 10;
        /// <summary>
        /// This will modify the base stats of the player.
        /// </summary>
        public string Species;
        /// <summary>
        /// This is the name of the playable character.
        /// </summary>
        public string Name;
        /// <summary>
        /// This is the stat that will determine chance of hitting.
        /// </summary>
        public int Dexterity;//depende on level and race
        /// <summary>
        /// This is the factor that will determine chance of blocking attack.
        /// </summary>
        public int Armor;

        //Cntructor for player class.

        public Player(string s, string n)
            {
                Name= n;
                Species= s; 
            }

        public Score Score
        {
            get => default;
            set
            {
            }
        }

        public Room Room
        {
            get => default;
            set
            {
            }
        }

        public Dice Dice
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method will update the stats of the player whenever something happens.
        /// </summary>
        public void UpdatePlayerStats()
        {
            throw new System.NotImplementedException();
        }
    }
}