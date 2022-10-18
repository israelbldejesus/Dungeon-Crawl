using System;
//  This program will calculated the required amount of wood needed to build a specified bookcase.

//  Author:  Brian Arthaud-Day

namespace DungeonCrawl
{
    class Program
    {
        static void Main(string[] args)
        {
            double height;  //the height of the bookcase, measured in inches
            double width, depth;  //the width and depth, respectively, of the bookcase, measured in inches
            int shelfCount = 5;  //Number of shelves ordered.  The default value is 5.
            int numCases = 0;  //Number of bookcases ordered.  The default value is 0.
            string woodType;  //The type of wood to be used for the bookcase.
            double totalArea;  //The total area of wood required for the bookcase.
            double areaSide, areaBack, areaShelf;  //The area for 1 each of the side, back, and shelves.
            double totalToOrder;  //How much wood to purchase for the order
            double overage = .1;  //How much additional wood to order for error

            //  Initialize the variables
            height = 36;
            width = 200;
            depth = 4.36;
            shelfCount = 3;
            numCases = 2;
            woodType = "walnut";

            //  Calculate the area of each part of the bookcase.
            areaSide = height * depth;
            areaBack = width * height;
            areaShelf = width * depth;

            totalArea = (areaSide * 2) + areaBack + areaShelf * shelfCount;
            /* Total area of the bookcase = area of the side * ...
             * 
             */

            //  Calculate the amount of wood to order.
            totalToOrder = totalArea * numCases;
            totalToOrder += (totalToOrder * overage);

            //  Display options
            //  Console.WriteLine(totalToOrder);  //Just displays the total wood to order.
            //  string ouputText = "You should order " + totalToOrder + " wood.";
            Console.WriteLine("You should order " + totalToOrder + " wood.");  //  "inline" method
            Console.WriteLine("You should order {0} wood.", totalToOrder);  //  "placeholder" method

            Console.Write("You should order ");  //  Showing Console.Write
            Console.Write(totalToOrder);
            Console.Write(" wood.");
            Console.WriteLine("It works, see??");
            Console.Write("Opps");

            Console.WriteLine("\nOrder {0:C} wood.\nOrder {1} wood.\nThis will allow you to " +
                "create {2} bookcases with the following dimensions:\n" +
                "width:  {3}\nheight:  {4}\ndepth:  " + depth, totalToOrder, woodType, numCases,
                width, height);  //placeholders, escape sequences, and inline output

            //  Getting user inputs
            string inputString;
            Console.WriteLine("Please enter the height for the new bookcase:");
            inputString = Console.ReadLine();
            height = Convert.ToDouble(inputString);
            //  Console.WriteLine("You typed \"" + inputString + "\".");
            double newArea = height * width;
            Console.WriteLine("The area is {0} square inches or {1} square feet.", newArea, newArea / 144);
        }
    }
}
