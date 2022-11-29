using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Dice
    {
        /// Player's Dex as it is passed through.
        public int pDex;

        /// Player's armor.
        public int pArmor;

        /// Monster's armor.
        public int mArmor;

        /// Monster's dex.
        public int mDex;

        /// This will return chance of hitting.
        public int CalcChance()
        {
            throw new System.NotImplementedException();
        }
    }
}