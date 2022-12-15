using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using static System.Formats.Asn1.AsnWriter;

//  This program will be a role-playing game simulator. Player(s) will be able choose a character and go through a series of rooms, fight monsters, find treasure and possibly emerge victoriously! 
//  Class: MIS 411
//  Author:  Israel, Jacob, Vivian

namespace DungeonCrawl
{ 
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            // dialogue for trap room
            void Trigger()
            {
                Thread.Sleep(2000);
                Console.WriteLine("You enter the room but something feels off...");
                Thread.Sleep(2000);
                Console.WriteLine("Sudenly a trap door opens below you and you fall to the ground.");
                Thread.Sleep(2000);
                // kill the player
                Console.WriteLine("You have triggered a trap and died!");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("███████████████████████████\r\n███████▀▀▀░░░░░░░▀▀▀███████\r\n████▀░░░░░░░░░░░░░░░░░▀████\r\n███│░░░░░░░░░░░░░░░░░░░│███\r\n██▌│░░░░░░░░░░░░░░░░░░░│▐██\r\n██░└┐░░░░░░░░░░░░░░░░░┌┘░██\r\n██░░└┐░░░░░░░░░░░░░░░┌┘░░██\r\n██░░┌┘▄▄▄▄▄░░░░░▄▄▄▄▄└┐░░██\r\n██▌░│██████▌░░░▐██████│░▐██\r\n███░│▐███▀▀░░▄░░▀▀███▌│░███\r\n██▀─┘░░░░░░░▐█▌░░░░░░░└─▀██\r\n██▄░░░▄▄▄▓░░▀█▀░░▓▄▄▄░░░▄██\r\n████▄─┘██▌░░░░░░░▐██└─▄████\r\n█████░░▐█─┬┬┬┬┬┬┬─█▌░░█████\r\n████▌░░░▀┬┼┼┼┼┼┼┼┬▀░░░▐████\r\n█████▄░░░└┴┴┴┴┴┴┴┘░░░▄█████\r\n███████▄░░░░░░░░░░░▄███████\r\n██████████▄▄▄▄▄▄▄██████████\r\n███████████████████████████");
                Console.WriteLine("You have Lost..."); 
                
            }

            // dice generator
            int RollDice()
            {
                Random rand = new Random();
                return rand.Next(1, 20);
            }

            //  These are the global variables that will be used in the main program.
            //List<Player> party = new List<Player>(); //  This list will keep track of the players
            List<Monster> monsters = new List<Monster>(); // keeps track of the monsters
            List<Treasure> treasures = new List<Treasure>(); // list to keep track of treasures

            //  ClassStats variables
            List<ClassStats> classes = new List<ClassStats>();  //  Declare and initialize the list of Class Stats
            classes.Add(new ClassStats("Warrior", 70, 7, 6, 7));
            classes.Add(new ClassStats("Hunter", 65, 8, 8, 4));
            classes.Add(new ClassStats("Paladin", 80, 8, 4, 4));
            classes.Add(new ClassStats("Tank", 100, 4, 2, 9));

            int modelCount = classes.Count - 1;  //  The number of Class Types available

            
            void Pause() //  This method will add a pause.
            {
                Console.WriteLine("Press any button to continue.");
                Console.ReadKey();
            }

            Random random = new Random(); //Builds a dice to rolled for treasure 

            int diRoll = random.Next(1, 8);

            Treasure tRoom() //Builds a treasure room 

            {

                Thread.Sleep(2000);
                Console.WriteLine("You enter the room and notice a something shinning in the back of this cold room");
                Thread.Sleep(2000);
                Console.WriteLine("As you walk closer to it, you notice that it is a gold chest.");
                Thread.Sleep(2000);
                Console.WriteLine("You decide to open it to find treasure!");
                Thread.Sleep(2000);
                Console.WriteLine("Press any button to Roll Dice for treasure type:");

                Thread.Sleep(2000);
                Console.WriteLine(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(2000);
                Console.Write(".");

                Console.WriteLine("\nYou rolled a {0}!", diRoll);

                if (diRoll == 2)
                {
                    Console.WriteLine("You found a Ruby!");
                    Console.WriteLine("____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__________¶¶¶____¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n________¶¶¶__¶¶__¶¶_¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶_¶¶¶¶¶\r\n______¶¶¶__¶¶¶__¶¶__¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶__¶¶¶¶¶¶\r\n____¶¶¶___¶¶¶___¶¶_¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶___¶¶¶¶¶\r\n___¶¶___¶¶¶¶¶__¶¶__¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶¶____¶¶¶¶¶\r\n_¶¶____¶¶¶¶¶___¶¶__¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶_____¶¶¶¶¶¶\r\n¶¶¶¶¶_____¶¶__¶¶__¶¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__¶¶¶¶¶¶¶____¶¶¶__¶¶¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n___¶¶¶___¶¶¶¶¶¶__________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n_____¶¶__¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶\r\n_______¶¶_¶¶¶_¶¶_________¶¶¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶\r\n________¶¶__¶¶_¶¶__¶¶¶¶¶_¶¶¶______¶¶¶¶___¶¶¶\r\n__________¶¶_¶¶_¶¶__¶¶¶¶_¶¶¶_____¶¶¶¶__¶¶¶\r\n___________¶¶_¶¶_¶¶_¶¶¶¶__¶¶____¶¶¶¶__¶¶¶\r\n_____________¶¶_¶_¶¶_¶¶¶__¶¶___¶¶¶¶_¶¶¶\r\n_______________¶_¶_¶¶_¶¶__¶¶__¶¶¶¶_¶¶¶\r\n________________¶¶__¶__¶__¶¶__¶¶¶¶¶¶\r\n__________________¶__¶____¶¶_¶¶¶¶¶¶\r\n___________________¶¶_¶___¶¶¶¶¶¶¶\r\n_____________________¶¶¶__¶¶¶¶¶¶\r\n______________________¶¶¶_¶¶¶¶\r\n________________________¶¶¶¶¶\r\n__________________________¶\r\n");
                    return treasures[1];
                }
                else if (diRoll == 3 || diRoll == 4)
                {
                    Console.WriteLine("You found an Emerald");
                    Console.WriteLine("____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__________¶¶¶____¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n________¶¶¶__¶¶__¶¶_¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶_¶¶¶¶¶\r\n______¶¶¶__¶¶¶__¶¶__¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶__¶¶¶¶¶¶\r\n____¶¶¶___¶¶¶___¶¶_¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶___¶¶¶¶¶\r\n___¶¶___¶¶¶¶¶__¶¶__¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶¶____¶¶¶¶¶\r\n_¶¶____¶¶¶¶¶___¶¶__¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶_____¶¶¶¶¶¶\r\n¶¶¶¶¶_____¶¶__¶¶__¶¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__¶¶¶¶¶¶¶____¶¶¶__¶¶¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n___¶¶¶___¶¶¶¶¶¶__________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n_____¶¶__¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶\r\n_______¶¶_¶¶¶_¶¶_________¶¶¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶\r\n________¶¶__¶¶_¶¶__¶¶¶¶¶_¶¶¶______¶¶¶¶___¶¶¶\r\n__________¶¶_¶¶_¶¶__¶¶¶¶_¶¶¶_____¶¶¶¶__¶¶¶\r\n___________¶¶_¶¶_¶¶_¶¶¶¶__¶¶____¶¶¶¶__¶¶¶\r\n_____________¶¶_¶_¶¶_¶¶¶__¶¶___¶¶¶¶_¶¶¶\r\n_______________¶_¶_¶¶_¶¶__¶¶__¶¶¶¶_¶¶¶\r\n________________¶¶__¶__¶__¶¶__¶¶¶¶¶¶\r\n__________________¶__¶____¶¶_¶¶¶¶¶¶\r\n___________________¶¶_¶___¶¶¶¶¶¶¶\r\n_____________________¶¶¶__¶¶¶¶¶¶\r\n______________________¶¶¶_¶¶¶¶\r\n________________________¶¶¶¶¶\r\n__________________________¶\r\n");
                    return treasures[2];
                }
                else if (diRoll == 5 || diRoll == 6)
                {
                    Console.WriteLine("You found a Saphire!");
                    Console.WriteLine("____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__________¶¶¶____¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n________¶¶¶__¶¶__¶¶_¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶_¶¶¶¶¶\r\n______¶¶¶__¶¶¶__¶¶__¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶__¶¶¶¶¶¶\r\n____¶¶¶___¶¶¶___¶¶_¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶___¶¶¶¶¶\r\n___¶¶___¶¶¶¶¶__¶¶__¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶¶____¶¶¶¶¶\r\n_¶¶____¶¶¶¶¶___¶¶__¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶_____¶¶¶¶¶¶\r\n¶¶¶¶¶_____¶¶__¶¶__¶¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__¶¶¶¶¶¶¶____¶¶¶__¶¶¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n___¶¶¶___¶¶¶¶¶¶__________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n_____¶¶__¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶\r\n_______¶¶_¶¶¶_¶¶_________¶¶¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶\r\n________¶¶__¶¶_¶¶__¶¶¶¶¶_¶¶¶______¶¶¶¶___¶¶¶\r\n__________¶¶_¶¶_¶¶__¶¶¶¶_¶¶¶_____¶¶¶¶__¶¶¶\r\n___________¶¶_¶¶_¶¶_¶¶¶¶__¶¶____¶¶¶¶__¶¶¶\r\n_____________¶¶_¶_¶¶_¶¶¶__¶¶___¶¶¶¶_¶¶¶\r\n_______________¶_¶_¶¶_¶¶__¶¶__¶¶¶¶_¶¶¶\r\n________________¶¶__¶__¶__¶¶__¶¶¶¶¶¶\r\n__________________¶__¶____¶¶_¶¶¶¶¶¶\r\n___________________¶¶_¶___¶¶¶¶¶¶¶\r\n_____________________¶¶¶__¶¶¶¶¶¶\r\n______________________¶¶¶_¶¶¶¶\r\n________________________¶¶¶¶¶\r\n__________________________¶\r\n");
                    return treasures[3];
                }
                else if (diRoll == 7)
                {
                    Console.WriteLine("You found the Rare Dimond of MIS411");
                    Console.WriteLine("____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__________¶¶¶____¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n________¶¶¶__¶¶__¶¶_¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶_¶¶¶¶¶\r\n______¶¶¶__¶¶¶__¶¶__¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶__¶¶¶¶¶¶\r\n____¶¶¶___¶¶¶___¶¶_¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶___¶¶¶¶¶\r\n___¶¶___¶¶¶¶¶__¶¶__¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶¶____¶¶¶¶¶\r\n_¶¶____¶¶¶¶¶___¶¶__¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶_____¶¶¶¶¶¶\r\n¶¶¶¶¶_____¶¶__¶¶__¶¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__¶¶¶¶¶¶¶____¶¶¶__¶¶¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n___¶¶¶___¶¶¶¶¶¶__________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n_____¶¶__¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶\r\n_______¶¶_¶¶¶_¶¶_________¶¶¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶\r\n________¶¶__¶¶_¶¶__¶¶¶¶¶_¶¶¶______¶¶¶¶___¶¶¶\r\n__________¶¶_¶¶_¶¶__¶¶¶¶_¶¶¶_____¶¶¶¶__¶¶¶\r\n___________¶¶_¶¶_¶¶_¶¶¶¶__¶¶____¶¶¶¶__¶¶¶\r\n_____________¶¶_¶_¶¶_¶¶¶__¶¶___¶¶¶¶_¶¶¶\r\n_______________¶_¶_¶¶_¶¶__¶¶__¶¶¶¶_¶¶¶\r\n________________¶¶__¶__¶__¶¶__¶¶¶¶¶¶\r\n__________________¶__¶____¶¶_¶¶¶¶¶¶\r\n___________________¶¶_¶___¶¶¶¶¶¶¶\r\n_____________________¶¶¶__¶¶¶¶¶¶\r\n______________________¶¶¶_¶¶¶¶\r\n________________________¶¶¶¶¶\r\n__________________________¶\r\n");
                    return treasures[4];
                }
                else
                {
                    Console.WriteLine("You found Nothing");
                    Console.WriteLine("____________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__________¶¶¶____¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n________¶¶¶__¶¶__¶¶_¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶_¶¶¶¶¶\r\n______¶¶¶__¶¶¶__¶¶__¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶__¶¶¶¶¶¶\r\n____¶¶¶___¶¶¶___¶¶_¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶___¶¶¶¶¶\r\n___¶¶___¶¶¶¶¶__¶¶__¶¶¶¶¶_¶¶¶¶____¶¶¶¶¶¶¶____¶¶¶¶¶\r\n_¶¶____¶¶¶¶¶___¶¶__¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶_____¶¶¶¶¶¶\r\n¶¶¶¶¶_____¶¶__¶¶__¶¶¶¶¶¶_¶¶¶¶_____¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n__¶¶¶¶¶¶¶____¶¶¶__¶¶¶¶¶¶_¶¶¶¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n___¶¶¶___¶¶¶¶¶¶__________¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶\r\n_____¶¶__¶___¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶__¶¶¶\r\n_______¶¶_¶¶¶_¶¶_________¶¶¶¶¶¶¶¶¶¶¶¶¶¶___¶¶¶¶\r\n________¶¶__¶¶_¶¶__¶¶¶¶¶_¶¶¶______¶¶¶¶___¶¶¶\r\n__________¶¶_¶¶_¶¶__¶¶¶¶_¶¶¶_____¶¶¶¶__¶¶¶\r\n___________¶¶_¶¶_¶¶_¶¶¶¶__¶¶____¶¶¶¶__¶¶¶\r\n_____________¶¶_¶_¶¶_¶¶¶__¶¶___¶¶¶¶_¶¶¶\r\n_______________¶_¶_¶¶_¶¶__¶¶__¶¶¶¶_¶¶¶\r\n________________¶¶__¶__¶__¶¶__¶¶¶¶¶¶\r\n__________________¶__¶____¶¶_¶¶¶¶¶¶\r\n___________________¶¶_¶___¶¶¶¶¶¶¶\r\n_____________________¶¶¶__¶¶¶¶¶¶\r\n______________________¶¶¶_¶¶¶¶\r\n________________________¶¶¶¶¶\r\n__________________________¶\r\n");

                    return treasures[0];
                }
            }

            bool VerifyChoiceYN() // This method will ask for yes or no and verify for correct input. 
            {
                bool choice = false;

                // exception handling
                do
                {
                    string str = Console.ReadLine().Substring(0);
                    if (str == "Y" || str == "y")
                    {

                        choice = false;
                        return choice;

                    }
                    if (str == "N" || str == "n")
                    {
                        return choice;
                    }
                    else
                    {
                        Console.WriteLine("Please enter Y for Yes or N for No.");
                        Pause();
                    }

                } while (!choice);
                Console.Clear(); // clears console
                return choice;
            }

            static List<Monster> AddMonsters(string path) //    This method is for adding the monsters here.
            {
                List<Monster> monsters = new List<Monster>();
                if (File.Exists(path)) // reads file if it exists
                {
                    StreamReader sr = new StreamReader(path); // path is first external file
                    while (!sr.EndOfStream) // reads each line in the file
                    {
                        string mt = sr.ReadLine();
                        int l = Convert.ToInt32(sr.ReadLine());
                        int a = Convert.ToInt32(sr.ReadLine());
                        int ar = Convert.ToInt32(sr.ReadLine());
                        int d = Convert.ToInt32(sr.ReadLine());
                        int xp = Convert.ToInt32(sr.ReadLine());

                        monsters.Add(new Monster(mt, l, a, ar, d, xp));
                    }
                }
                else
                {
                    Console.WriteLine("Could not find the file");
                }
                return monsters;
            }

            static List<Treasure> AddTreasures(string path1)    // method for adding treasures from external file
            {
                List<Treasure> treasures = new List<Treasure>();
                if (File.Exists(path1)) // reads file if it exists
                {
                    StreamReader sr = new StreamReader(path1); // path 1 is second external file
                    while (!sr.EndOfStream) // read each  line in the file
                    {
                        string t = sr.ReadLine();
                        int v = Convert.ToInt32(sr.ReadLine());                        

                        treasures.Add(new Treasure(v, t));
                    }
                }
                else
                {
                    Console.WriteLine("Could not find the file.");
                }
                return treasures;
            }

            // this method will write the summary to a file
            static void PrintReceipt(Player p, List<Monster> m, List<Treasure> t, int c)//Score(treasure), name of user, rooms cleared, monsters killed
            {
                string path2 = "Game Summary.txt";
                using (StreamWriter sw = new StreamWriter(path2, true)) // true will append data to file, path 2 is third external file
                {
                    int highScore = 0;
                    sw.WriteLine("Player Name: " + p.Name);
                    sw.WriteLine("Player Class: " + p.ClassType);
                    foreach(Monster m2 in m)
                    {
                        sw.WriteLine("Monster Name: " + m2.MonsterType);
                        highScore += 10;
                    }
                    foreach(Treasure t2 in t)
                    {
                        sw.WriteLine("Treasure Name: " + t2.typeOfTreasure);
                        highScore += t2.Value;
                    }
                    sw.WriteLine("Rooms: " + c);
                    highScore += (c * 10);
                    sw.WriteLine(highScore);
                    sw.Close();
                }
            }

            //  This method will verify the input of the user. 
            int ChooseClass(List<ClassStats> c)
            {
                int output = 0;
                bool loop2 = true;
                while (loop2)
                {
                    // try-catch method for exception handling
                    try
                    {
                        Console.WriteLine("Select a class by entering a number between 1 and 4: ");
                        output = Convert.ToInt32(Console.ReadLine());
                        if (output < 1 || output > 4)
                        {
                            Console.WriteLine("Enter a valid number between 1 and 4.");
                            Pause();
                            
                            loop2 = true;
                        }
                        else
                        {
                            loop2 = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Enter a valid number between 1 and 4.");
                        Pause();
                        
                        loop2 = true;
                    }
                }

                return output;
            }

            //  This method will verify the input of the user for door. 
            int ChooseDoor()
            {
                int output = 0;
                bool loop2 = true;
                while (loop2)
                {
                    // try-catch method for exception handling
                    try
                    {
                        Console.WriteLine("Select a door by entering a number between 1 and 3: ");
                        output = Convert.ToInt32(Console.ReadLine());
                        if (output < 1 || output > 3)
                        {
                            Console.WriteLine("Enter a valid number between 1 and 3");
                            Pause();

                            loop2 = true;
                        }
                        else
                        {
                            loop2 = false;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Enter a valid number between 1 and 3.");
                        Pause();

                        loop2 = true;
                    }
                }

                return output;
            }

            // These are the methods for the main program. 
            Player CreatePlayer(List<ClassStats> c)
            {
                Console.WriteLine("Enter your player name: ");
                string input1 = Console.ReadLine();
                Console.WriteLine("Select the class you want from the options:");

                for (int i = 0; i < c.Count(); i++) // counter
                {
                    Console.WriteLine("\n" + (i + 1) + "\t" + c[i].ToString());
                }

                int input2 = ChooseClass(c);

                ClassStats output = classes[input2];

                Player player = new Player(output, input1);

                Console.WriteLine("Player created!");
                return player;
            }


            /*
             * ************************************************************************************************************************************************************
             * This is where the main code and logic starts.
             * ************************************************************************************************************************************************************
             */


            //art from https://www.asciiart.eu/mythology/dragons
            Console.WriteLine("            _                                      _                   \r\n          _/(               <~\\  /~>               )\\_                 \r\n        .~   ~-.            /^-~~-^\\            .-~   ~.               \r\n     .-~        ~-._       : /~\\/~\\ :       _.-~        ~-.            \r\n  .-~               ~~--.__: \\0/\\0/ ;__,--~~               ~-.         \r\n /                        ./\\. ^^ ./\\.                        \\        \r\n.                         |  ( )( )  |                         .       \r\n-~~--.        _.---._    /~   U`'U   ~\\    _.---._        .--~~-       \r\n      ~-. .--~       ~~-|              |-~~       ~--. .-~             \r\n         ~              |  :        :  |_             ~                \r\n                        `\\,'  :  :  `./' ~~--._                        \r\n                       .(<___.'  `,___>),--.___~~-.                    \r\n                       ~ (((( ~--~ ))))      _.~  _)                   \r\n                          ~~~      ~~~/`.--~ _.--~                     \r\n                                      \\,~~~~~                          \r\n                          Dungeon Crawl                                \r\n                          ======= =====       ");
            Pause();
            Console.Clear();

            bool keeplooping = true;
            do
            {
                //party.Add(CreatePlayer(classes)); //    This will call a method to create the player. 
                Player player1 = CreatePlayer(classes);
                
                monsters = AddMonsters("Monster.txt"); // calls external file
                treasures = AddTreasures("Treasure.txt"); // calls external file
                List<Treasure> treasurePrintList = new List<Treasure>();
                List<Monster> MonsterPrintList = new List<Monster>();

                Console.WriteLine("\nLoading...");  // Adding dramatic loading screen
                Thread.Sleep(4000); // time for next console to display
                Console.WriteLine("Done!");
                Pause();
                Console.Clear();

                //  Wake up, then describe the scene.
                Console.WriteLine("You wake up in daze. ");
                Thread.Sleep(2000);
                Console.WriteLine("Your head hurts really bad and you don't know where you are.");
                Thread.Sleep(2000);
                Console.WriteLine("You decide to look around and notice you are in an empty room with three doors. ");
                Thread.Sleep(2000);
                Console.WriteLine("You think to yourself how did I get here?"); //    Added more story here.
                Thread.Sleep(3000);
                Pause();
                Console.Clear();
                          

                Room activeRoom = new Room(player1, monsters, treasures); // calling room for player, monster, and treasure

                //  This counter will know what room we are in at the moment. 
                int roomCounter = 1;
                while (roomCounter < 10)
                {
                    if (roomCounter == 9)//  When you get to the 9th room you will enter a boss room
                    {
                        //  Boss room
                        Console.WriteLine("Encounter with boss mosnter.");
                    }
                    else
                    {
                        Console.WriteLine("Which door do wish to go through?"); //    This is meant to ask and determine which door you head through.
                        Console.WriteLine("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒███████████████████▒▒▒▒▒▒▒███████████████████████▒▒▒▒█████████████████████████████████▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒╔╗▒▒▒▒▒▒▒▒█▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒╔╝║▒▒▒▒▒▒▒▒█▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒╔═══╗▒▒▒▒▒▒██▒▒▒▒█▒▒▒▒▒▒╔═══╗▒▒▒▒▒█▒▒▒▒▒╔═══╗▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒╚╗║▒▒▒▒▒▒▒▒█▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒║╔═╗║▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒║╔═╗║▒▒▄▄▒█▒▄▄▒▒║╔═╗║▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒║║▒▒▒▒▒██▌█▒▒▒▒▒▒█▒▒▒▒██▌▒▒▒╚╝╔╝║▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒╚╝╔╝║▒▐██▒█▒██▌▒╚╝╔╝║▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒╔╝╚╗▒▒▒▒▀▀▒█▒▒▒▒▒▒█▒▒▒▒▀▀▒▒▒▒╔═╝╔╝▒▒▒▒▒▒██▒▒▒▒█▒▒▒▒▒▒╔╗╚╗║▒▒▒▒▒█▒▒▒▒▒╔╗╚╗║▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒╚══╝▒▒▒▒▒▒▒█▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒║║╚═╗▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒║╚═╝║▒▒▒▒▒█▒▒▒▒▒║╚═╝║▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒╚═══╝▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒╚═══╝▒▒▒▒▒█▒▒▒▒▒╚═══╝▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒██▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒██▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▒\r\n▒▒▒███████████████████▒▒▒▒▒▒▒██████████████████████▒▒▒▒▒█████████████████████████████████▒\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒\r\n");
                        
                        //Displaying door options for selection
                        // Prompt the user to enter a choice (1, 2, or 3)
                        Console.Write("Enter which door do you wish to enter (1, 2, or 3): ");
                        int choice = ChooseDoor();                        

                        if (choice == 1)
                        {
                            Console.WriteLine("You chose door 1!");
                            Pause();
                            Console.Clear();
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("You chose door 2!");
                            Pause();
                            Console.Clear();
                        }
                        else if (choice == 3)
                        {
                            Console.WriteLine("You chose door 3!");
                            Pause();
                            Console.Clear();
                        }                        

                        Console.WriteLine("Press any button to Roll Dice for room type:");
                        Console.ReadKey();
                        int dieRoll = RollDice();
                        

                        Thread.Sleep(2000);
                        Console.Write(".");
                        Thread.Sleep(2000);
                        Console.Write(".");
                        Thread.Sleep(2000);
                        Console.Write(".");
                        Thread.Sleep(2000);
                        Console.Write(".");
                        Console.WriteLine("\nYou rolled a {0}!", dieRoll);
                        Pause();
                        Console.Clear();
                    
                        if (dieRoll == 1 || dieRoll >= 2)
                        {
                            Trigger();
                            roomCounter = 10;
                            Pause();
                            Console.Clear();
                        }
                        else if (dieRoll >= 3 && dieRoll <= 10 )
                        {
                            Console.WriteLine("Encounter with small mosnter.");
                            //MonsterPrintList.Add();
                            //activeRoom.GenerateRoom(MediumMonster);
                            Pause();
                            Console.Clear();
                        }
                        else if (dieRoll >= 11 && dieRoll <=16)
                        {
                            Console.WriteLine("Encounter with big mosnter.");
                            //MonsterPrintList.Add();
                            //activeRoom.GenerateRoom(StrongMonster);
                            Pause();
                            Console.Clear();
                        }
                        else if (dieRoll >= 17 && dieRoll <= 20 )
                        {
                            treasurePrintList.Add(tRoom());//adding the treasure to out printing list.
                            Pause();
                            Console.Clear();
                        }                        
                    }
        roomCounter++;
                }
                Console.WriteLine("Do you wish to play again?(Y/N)");
                keeplooping = VerifyChoiceYN();
                Console.Clear();
                PrintReceipt(player1, MonsterPrintList, treasurePrintList, roomCounter);
            } while (keeplooping);            
        }
    }
}
