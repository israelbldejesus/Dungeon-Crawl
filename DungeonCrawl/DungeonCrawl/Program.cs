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
            //  These are the global variables that will be used in the main program.
            List<Player> party = new List<Player>();//  This list will keep track of the players
            List<Monster> monsters = new List<Monster>(); // keeps track of the monsters

            //  ClassStats variables
            List<ClassStats> classes = new List<ClassStats>();  //  Declare and initialize the list of Class Stats
            classes.Add(new ClassStats("Warrior", 70, 7, 6, 7));
            classes.Add(new ClassStats("Hunter", 65, 8, 8, 4));
            classes.Add(new ClassStats("Paladin", 80, 8, 4, 4));
            classes.Add(new ClassStats("Tank", 100, 4, 2, 9));

            int modelCount = classes.Count - 1;  //  The number of Class Types available


            void Pause()//  This method will add a pause.
            {
                Console.WriteLine("Press any button to continue.");
                Console.ReadKey();
                //Console.Clear();
            }

            bool VerifyChoiceYN()// This method will ask for yes or no and verify for correct input. 
            {
                bool choice = false;

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
                Console.Clear();
                return choice;
            }

    // These are the methods for the main program. 
    static Player CreatePlayer(List<ClassStats> c)
    {
            Console.WriteLine("Enter your player name: ");
            string input1 = Console.ReadLine();
            Console.WriteLine("Select the class you want from the options:");

            for(int i = 0; i < c.Count(); i++)
            {
                Console.WriteLine(i+1 + "\t" + c[i].ToString());
            }

            int input2 = Convert.ToInt32(Console.ReadLine());

            Player player = new Player(input2, input1);

            return player;
        }

            //art from https://www.asciiart.eu/mythology/dragons
            Console.WriteLine("            _                                      _                   \r\n          _/(               <~\\  /~>               )\\_                 \r\n        .~   ~-.            /^-~~-^\\            .-~   ~.               \r\n     .-~        ~-._       : /~\\/~\\ :       _.-~        ~-.            \r\n  .-~               ~~--.__: \\0/\\0/ ;__,--~~               ~-.         \r\n /                        ./\\. ^^ ./\\.                        \\        \r\n.                         |  ( )( )  |                         .       \r\n-~~--.        _.---._    /~   U`'U   ~\\    _.---._        .--~~-       \r\n      ~-. .--~       ~~-|              |-~~       ~--. .-~             \r\n         ~              |  :        :  |_             ~                \r\n                        `\\,'  :  :  `./' ~~--._                        \r\n                       .(<___.'  `,___>),--.___~~-.                    \r\n                       ~ (((( ~--~ ))))      _.~  _)                   \r\n                          ~~~      ~~~/`.--~ _.--~                     \r\n                                      \\,~~~~~                          \r\n                          Dungeon Crawl                                \r\n                          ======= =====       ");
            Pause();
            Console.Clear() ;

            bool keeplooping = true;
            do
            {
                //  Wake up, then describe the scene.
                Console.WriteLine(" You wake up in daze. Your head hurts really bad and you don't know where you are." +
                    " You decide to look around and notice you are in an empty room with three doors. " +
                    "You think to yourself how did I get here?"); //    Added more story here.
                Console.WriteLine("Which door do LayoutKind wish to go through"); //    This is meant to ask and determine which door you head through.
                string RoomChoice = Console.ReadLine();
                Pause();
                Console.Clear();

                party.Add(CreatePlayer(classes));

                Room activeRoom = new Room(party);

                //  This counter will know what room we are in at the moment. 
                int roomCounter = 1;
                while (roomCounter < 10)
                {
                    if (roomCounter == 9)//  When you get to the 9th room you will enter a boss room
                    {
                        //  Boss room
                    }
                    Console.WriteLine("Select your next move.");


                    roomCounter++;
                }


            } while (keeplooping);

           
            
            //Make the player create their character. 

            
            
        }
    }
}
