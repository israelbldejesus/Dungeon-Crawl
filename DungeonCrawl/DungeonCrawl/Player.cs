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

    public enum ClassTypes
    {
        Warrior,
        Hunter,
        Paladin,
        Tank
    }

    public struct ClassStats  //  Structure defining the name and Class type sepcifications.
    {
        public string ClName;
        public int HP;     //  Fields within a struct are assigned the "public" access setting so that the fields can be 
        public int Attack;   //  accessed by the Main() method (and other methods) in the program.  Each field is established 
        public int Dexterity;    //  as a datatype (including ENUMs, LISTS<>, Classes, and other STRUCTs).  Recalling the values stored
        public int Armour;    //  in a field involve using the variable name of the instantiated STRUCT followed by a period and then

        public ClassStats(string c, int h, int a, int d, int ar)   //  Constructor for a ClassStats struct
        {
            ClName = c; 
            HP = h;       
            Attack = a;     
            Dexterity = d;     
            Armour = ar;     
        }

        public override string ToString()  //  Replaces the default ToString() method created with the class is created.
        {
            string s = "Class Type:  " + ClName + "\nStats:\tHealth Points:  " + HP + "\n\t\tAttack Power:  " + Attack + "\n\t\tDexterity: " + Dexterity + "\n\t\tArmour Points: " + Armour;
            return s;       //  The default ToString() method shows the namespace, the name of the struct. 
        }
        
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

                static void Main()  //  Main() is a method of the Program class.
                {
                    //  ClassStats variables
                    List<ClassStats> models = new List<ClassStats>();  //  Declare and initialize the list of Class Stats
                models.Add(new ClassStats("Class Types", 0, 0, 0, 0));
                    models.Add(new ClassStats("Warrior", 70, 7, 6, 7));
                    models.Add(new ClassStats("Hunter", 65, 8, 8, 4));
                    models.Add(new ClassStats("Paladin", 80, 8, 4, 4));
                    models.Add(new ClassStats("Tank", 100, 4, 2, 9));

                    int modelCount = models.Count - 1;  //  The number of Class Types available

                }
            }
        }
    }
