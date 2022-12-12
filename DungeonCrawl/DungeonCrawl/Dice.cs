using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Dice
    {
        /// Player's Dex as it is passed through.
        public int playerDex;

        /// Monster's dex.
        public int monsterDex;

        /// This will return chance of hitting.
        public int HitChance(int pDex, int mDex)
        {
            playerDex = pDex;
            monsterDex = mDex;
            return 0;
        }

        //This method will generate a number for generating a room. 
        public int RoomChance(int pDex)
        {
            playerDex = pDex;

            int output = 

            return 0;
        }
    }
}