using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace DungeonCrawl
{
    public class Monster
    {
        struct Monster1(string mt, int h, int l, int a, int ar, int d, int xp)
        {
            
        }
        /// This is the health of the monster.
        public int HP;

        /// This will determine the base HP and Attack.
        public int Level;

        /// This is how much damage the monster does
        public int Attack;

        /// This is the factor that will determine chance of blocking attack.
        public int Armor;

        /// This is the stat that will determine chance of hitting.
        public int Dexterity;

        /// This determines if a monster is a boss.
        public bool Boss;

        /// This list will contain all the types of monsters.
        public List<Monster> MonsterType;

        /// This is the experience the monster will drop when defeated.
        public int XP;

        /// This is describing the monster.
        public string Description;

        // add constructor for monster?

        List<Animal> zoo = new List<Animal>();
        string input;
        int counter, coatInput, classInput;

        string path = "animals.txt";
        string path2 = "zoo.txt";

            //  Write code to open the "animals.txt" file and read the contents into Animal object.  Add those objects to the 'zoo' List.
            //  Be sure to account for a missing file exception handling.  It is useful to print the newly created contents for verification.
            //  Some data types will need to be converted.  Consider Exception Handling for those items.

/*
 *  if (File.Exists(path))
{
    StreamReader sr = new StreamReader(path);
    while (!sr.EndOfStream)
    {
        Animal animal = new Animal();
        animal.name = sr.ReadLine();
        animal.coat = (Coat)Convert.ToInt32(sr.ReadLine());
        animal.classifiction = (Classifiction)Convert.ToInt32(sr.ReadLine());
        animal.legs = Convert.ToInt32(sr.ReadLine());
        animal.weight = Convert.ToDouble(sr.ReadLine());

        animal.PrintAnimal();

        zoo.Add(animal);
    }
}
else
{
    Console.WriteLine("Could not find the file");
}*/
// streamread file and add monster to file through list

static void Main(string[] args)
{
// inserting external file and adding monsters to file
string path = "Monster.txt"; // file for monster
//string excerpt = null;

if (File.Exists(path)) // if file exist, execute if code
{
    using (StreamReader sr = new StreamReader(path))
    {
        while (!sr.EndOfStream)
        {

        }

        sr.Close();
        //Pause();
    }
    using (StreamReader sr2 = new StreamReader(path))
    {
        while (!sr2.EndOfStream)
        {
            Monster MonsterType = new Monster();
        }

        sr2.Close();
    }
}
}


public Room Room
{
get => default;
set
{

}
}

/// This will calculate the stats for the monster.
public void CalcMosnterStats()
{
throw new System.NotImplementedException();
}
}
}