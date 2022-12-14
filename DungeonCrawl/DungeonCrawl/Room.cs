using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonCrawl
{
    public class Room
    {
        /// This is how we know the type of room the player is in.
        public string typeOfRoom;

        /// This is howmany monsters will be in the room.
        public int numMonsters;

        /// Treasures that could be in the room.
        public int treasureItem;



        /// This is how we start the encounter or action for the room.
        
        public Player partyOfPlayers;
        public List<Monster> monsters;
        public List<Treasure> treasures;

      

        public void GenerateRoom(int playerchance)
        {
            //Test Message
            Console.WriteLine("Room generation test complete!");
        }

        public void Encounter()
        {
            throw new System.NotImplementedException();
        }

        public Room(Player pl, List<Monster> ml, List<Treasure> t)
        {
            partyOfPlayers = pl;
            monsters = ml;
            treasures = t;
        }
    }
}