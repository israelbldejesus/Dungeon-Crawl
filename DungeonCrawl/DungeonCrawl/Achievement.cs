using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Achievement
    {
        /// <summary>
        /// This is the list of all the possible achievement.
        /// </summary>
        public List<Achievement> AchList;

        public Score Score
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This will apply the bonus to the score.
        /// </summary>
        public int ApplyAchBonus()
        {
            throw new System.NotImplementedException();
        }
    }
}