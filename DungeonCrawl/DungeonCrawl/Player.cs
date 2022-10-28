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
        public int Level;
        /// <summary>
        /// This is the health of the player.
        /// </summary>
        public int HP;
        /// <summary>
        /// This is the base attack of the player.
        /// </summary>
        public int Attack;
        /// <summary>
        /// This will modify the base stats of the player.
        /// </summary>
        public string Species;
        /// <summary>
        /// This is the name of the playable character.
        /// </summary>
        public string Name;

        /// <summary>
        /// This method will update the stats of the player whenever something happens.
        /// </summary>
        public void UpdatePlayerStats()
        {
            throw new System.NotImplementedException();
        }
    }
}