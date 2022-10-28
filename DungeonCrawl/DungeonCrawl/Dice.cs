using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Dice
    {
        /// <summary>
        /// Player's Dex as it is passed through.
        /// </summary>
        public int pDex;
        /// <summary>
        /// Player's armor.
        /// </summary>
        public int pArmor;
        /// <summary>
        /// Monster's armor.
        /// </summary>
        public int mArmor;
        /// <summary>
        /// Monster's dex.
        /// </summary>
        public int mDex;

        /// <summary>
        /// This will return chance of hitting.
        /// </summary>
        public int CalcChance()
        {
            throw new System.NotImplementedException();
        }
    }
}