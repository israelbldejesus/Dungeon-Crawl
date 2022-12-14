using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace DungeonCrawl
{
    public class Treasure
    {
        // constructor for treasure
        public Treasure(int v, string t)
        {
            Value = v;
            typeOfTreasure = t;
        }
        
        

        /// This is the value of the treasure
        public int Value;

        /// This is the type of treasure.
        public string typeOfTreasure;

        public void TreasureChance()
        {
            throw new System.NotImplementedException();
        }
    }
}