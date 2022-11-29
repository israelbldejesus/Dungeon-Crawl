using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;
//  This program will calculated the required amount of wood needed to build a specified bookcase.

//  Author:  Brian Arthaud-Day

namespace DungeonCrawl
{
    class Program
    {
        static void Main(string[] args)
        {
            //These are the global variables that will be used in the main program.
            List<Player> party = new List<Player>();//This list will keep track of the players

            // These are the methods for the main program. 
            static Player CreatePlayer()
            {
                Console.WriteLine("Enter your player name.");
                string input1 = Console.ReadLine();
                Console.WriteLine("Select the class you want form the options.");
                int input2 = Convert.ToInt32(Console.ReadLine());

                Player player = new Player(input2, input1);

                return player;
            }

            //art from https://www.asciiart.eu/mythology/dragons
            Console.WriteLine("            _                                      _                   \r\n          _/(               <~\\  /~>               )\\_                 \r\n        .~   ~-.            /^-~~-^\\            .-~   ~.               \r\n     .-~        ~-._       : /~\\/~\\ :       _.-~        ~-.            \r\n  .-~               ~~--.__: \\0/\\0/ ;__,--~~               ~-.         \r\n /                        ./\\. ^^ ./\\.                        \\        \r\n.                         |  ( )( )  |                         .       \r\n-~~--.        _.---._    /~   U`'U   ~\\    _.---._        .--~~-       \r\n      ~-. .--~       ~~-|              |-~~       ~--. .-~             \r\n         ~              |  :        :  |_             ~                \r\n                        `\\,'  :  :  `./' ~~--._                        \r\n                       .(<___.'  `,___>),--.___~~-.                    \r\n                       ~ (((( ~--~ ))))      _.~  _)                   \r\n                          ~~~      ~~~/`.--~ _.--~                     \r\n                                      \\,~~~~~                          \r\n                          Dungeon Crawl                                \r\n                          ======= =====       ");

            bool keeplooping = true;
            do{
                //Wake up, then describe the scene.
                Console.WriteLine("Wake up, then describe the scene.");

                party.Add(CreatePlayer());

                Room activeRoom = new Room(party);

                //This inner loop will hadle the actions of a player inside the room. 
                bool innerloop1 = true;
                do
                {
                    Console.WriteLine("Select your next move.");

                } while (innerloop1);


            }while(keeplooping);

           
            
            //Make the player create their character. 

            
            
        }
    }
}
