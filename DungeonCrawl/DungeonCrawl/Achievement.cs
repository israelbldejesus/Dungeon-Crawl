using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Achievement
    {
        /// This is the list of all the possible achievement.
        public List<Achievement> AchList;

        public Score Score
        {
            get => default;
            set
            {
            }
        }

        /// This will apply the bonus to the score.
        public int ApplyAchBonus()
        {
            throw new System.NotImplementedException();
        }
    }
}