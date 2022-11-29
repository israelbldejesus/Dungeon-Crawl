using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Room
    {
        /// <summary>
        /// This is how we know the type of room the player is in.
        /// </summary>
        public string typeOfRoom;
        /// <summary>
        /// This is howmany monsters will be in the room.
        /// </summary>
        public int numMonsters;
        /// <summary>
        /// Treasures that could be in the room.
        /// </summary>
        public string treasureItem;

        /// <summary>
        /// This is how we start the encounter or action for the room.
        /// </summary>
        
        public List<Player> partyOfPlayers;
        public void Encounter()
        {
            throw new System.NotImplementedException();
        }

        public Room(List<Player> p)
        {
            partyOfPlayers = p;
        }
    }
}