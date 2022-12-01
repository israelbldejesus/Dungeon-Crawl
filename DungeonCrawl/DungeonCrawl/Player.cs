using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Linq;

namespace DungeonCrawl
{
          public class Player
            {
                /// This will determine the base Attack and HP and Dexterity.
                public int Level = 1;

                /// This is the health of the player.
                public int HP = 100;//depends on level and race

                /// This is the base attack of the player.
                public int Attack = 10;

                /// This will modify the base stats of the player.
                public int ClassType;

                /// This is the name of the playable character.
                public string Name;

                /// This is the stat that will determine chance of hitting.
                public int Dexterity;//depende on level and race

                /// This is the factor that will determine chance of blocking attack.
                public int Armor;

                // Constructor for player class.

                public Player(int s, string n)
                {
                    Name = n;
                    ClassType = s;
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

                public Treasure Treasure
                {
                    get => default;
                    set
                    {
                    }
                }


                /// This method will update the stats of the player whenever something happens.
                public void UpdatePlayerStats()
                {

                }
            }
        }

