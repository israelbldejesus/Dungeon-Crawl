using System;
using System.Collections.Generic;
//  This program take in an order for a bookcase, in detail, and calculate how much wood needs to be ordered and how much the bookcase will cost.

//  Author:  Brian Arthaud-Day

namespace ClassDemo
{
    public enum WoodType  // Enumerated List of possible wood types - values assigned are to help with menu listing and indexing
    {
        Oak = 1,
        Ash = 2,
        Walnut = 3,
        Mahogany = 4,
        Cherry = 5
    }

    public struct BookCase  //  Structure defining the name, model sepcifications, and base cost for each bookcase model.
    {
        public string name;
        public double height;
        public double width;
        public double depth;
        public double baseCost;

        public BookCase(string n, double h, double w, double d, double b)  //  Constructor for a BookCase struct
        {
            name = n;
            height = h;
            width = w;
            depth = d;
            baseCost = b;
        }

        public override string ToString()  //  Replaces the default ToString() method created with the class is created.
        {
            string s = "Bookcase Model:  " + name + "\nDimensions:\theight:  " + height + " inches\n\t\twidth:  " + width + " inches\n\t\tdepth" + depth + " inches\n";
            return s;
        }
    }

    public struct Order  //  Structure to store selections of the model, wood type, shelves and number ordered
    {
        public BookCase bCase;  //  Details of the selected bookcase to be ordered from the List of BookCase Structs
        public WoodType wood;  //  Enumerate List value for the type of wood selected
        public int shelfNum;  //  The selected number of shelves
        public int qty;  //  The number of bookcases ordered OF THIS MODEL
        public double cost;  //  The unit cost for 1 bookcase with these specifications

        public Order(BookCase bc, WoodType w, int s, int q, double c)
        {
            bCase = bc;
            wood = w;
            shelfNum = s;
            qty = q;
            cost = c;
        }

        public string ToString(BookCase bc)  //  Convert the values of the Order class (or object) into a printable string format.
        {
            string s;
            s = "Model:  " + bc.name + "\tWood:  " + wood + "\tShelves:  " + shelfNum;
            s += "\n\tUnit Cost:  " + cost + "\tQuantity:  " + qty + "\t Total Cost:  " + (cost * qty);
            return s;
        }
    }

    class Program
    {
        static void Main()
        {
            //  Bookcase variables
            int shelfCount = 0;  //Number of shelves, per bookcase, to be ordered.
            int numCases = 0;  //Number of bookcases to be ordered.  The default value is 0.
            double overage = .1;  //How much additional wood to order to account for error
            List<BookCase> models = new List<BookCase>();  //  Declare and initialize the list of bookcase models
            models.Add(new BookCase("Model Names", 0, 0, 0, 0));
            models.Add(new BookCase("Tall", 35, 16, 23, 2.75));
            models.Add(new BookCase("Extra Tall", 72, 30, 24, 2.65));
            models.Add(new BookCase("Medium", 56, 23, 4, 3.15));
            models.Add(new BookCase("Narrow", 44, 18, 5, 3.45));
            models.Add(new BookCase("The Answer", 42, 42, 42, 3.89));

            //  Declare and 
            //  List<double> bcCost = new List<double>() { 0, 2.75, 2.65, 3.15, 3.45, 3.89 };  //  The cost per sq. ft. for each type of wood (indexes match with woodOptions list)
            int modelCount = models.Count - 1;  //  The number of bookcase models available
            int woodCount = Enum.GetValues(typeof(WoodType)).Length;  //  The number of wood options available
            List<Order> order = new List<Order>();
            Order item = new Order();
            Boolean orderMore = true;

            //  Functional Variables
            string inputString;  //  For receiving general input from the user.
            int selection = 0;  //  To be used for the model selection
            Boolean validInput;  //  Variable used in "validation loops" (testing validity of the data)
            Boolean confirm;  //  Variable used in "confirmation loops" (capturing the response of whether the user confirms a selection or not)
            int counter;  //  Used in loops to display selection options or test for various criteria
            string woodInput;  //  Input string used when selecting the wood type
            string shelfInput;  //  Input string used when selecting the number of shelves to include
            int woodChoice = 0;  //  variable to hold the index of the selected wood type (index zero holds a label for the field)
            double bcArea, bcSide, bcBack, bcShelf, bcTotalArea;  //  surface area subtotals and totals
            double baseCost, totalCost;  //  cost variables
            const int minShelfHeight = 14;  //  Constant to hold the minimum shelf height, used in calculating the maximum number of shelves available for a given model
            int maxShelves;  //  The maximum number of shelves that can be ordered with the selected model
            const int maxPurchase = 6;  //  The maximum number of units that cam be purchased in a single order

            //  Display Greeting
            Console.WriteLine("Welcome to Bookcases by The Owl and the Worm Shop, the wisest bookcase maker around!");

            //  Display all models with their dimensions

            do  //  Confirmation Loop, ensuring user chose the proper bookcse.
            {
                counter = 0;
                Console.WriteLine("{0} and Dimensions", models[0].name);
                foreach (BookCase bc in models)
                {
                    //  Skip displaying the titles and placeholder values at index 0 in the list and array.
                    switch (counter)
                    {
                        case 0:
                            counter++;
                            continue;
                        default:
                            Console.WriteLine("Index {0} = {1} Dimensions", counter, bc.name);
                            Console.WriteLine("\tHeight:  {0}\n\tWidth:  {1}\n\tDepth:  {2},",
                                bc.height, bc.width, bc.depth);
                            counter++;
                            continue;
                    }
                }

                do  // Validation loop to ensure proper data entry
                {
                    //Ask user for bookcase selection and validate their response
                    Console.WriteLine("Which bookcase would you like to order?");
                    try  //  Check for valid data type
                    {
                        inputString = Console.ReadLine();
                        selection = Convert.ToInt32(inputString);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please enter a numerical value between 1 and {0}", modelCount);
                        validInput = false;
                        continue;
                    }

                    if (selection < 1 || selection > modelCount)
                    {
                        Console.WriteLine("Please enter a numerical value between 1 and {0}", modelCount);
                        validInput = false;
                    }
                    else
                    {
                        validInput = true;
                    }
                } while (!validInput);  //  Return to validation loop

                //  Have user confirm the bookcase selection
                Console.WriteLine("You have selected the {0} bookcase with the follwing dimensions:", models[selection].name);
                Console.WriteLine("\tHeight:  {0} inches\n\tWidth:  {1} inches\n\tDepth:  {2} inches", models[selection].height, models[selection].width, models[selection].depth);
                Console.WriteLine("The base cost for this bookcase is will depend on the type of wood selected.");
                Console.WriteLine("Would you like to proceed with this selection? (y/n)");  //  Confirm the selection
                inputString = Console.ReadLine();
                if (inputString == "n" || inputString == "N")  //  Assume a default respons of 'Yes'
                {
                    confirm = false;
                }
                else
                {
                    confirm = true;
                }

            } while (!confirm);  //  Return to confirmation loop
            item.bCase = models[selection];

            Console.Clear();
            //Ask user for wood type
            do  //  Confirmation loop for wood type selection
            {
                //  counter = 0;
                Console.WriteLine("Please select your type of wood:");

                foreach (WoodType wt in Enum.GetValues(typeof(WoodType)))
                {
                    Console.WriteLine("{0}.  {1}", (int)wt, wt);
                }

                do  // Validation loop to ensure proper data entry
                {
                    //Ask user for bookcase selection and validate their response
                    Console.WriteLine("Which type of wood would you like to order?");
                    //Ask user for wood type selection and validate their response
                    try  //  Check for valid data type
                    {
                        woodInput = Console.ReadLine();
                        woodChoice = Convert.ToInt32(woodInput);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please enter a numerical value between 1 and {0}", woodCount);
                        validInput = false;
                        continue;
                    }

                    if (woodChoice < 1 || woodChoice > woodCount)
                    {
                        Console.WriteLine("Please enter a numerical value between 1 and {0}", woodCount);
                        validInput = false;
                    }
                    else
                    {
                        validInput = true;
                    }
                } while (!validInput);
                item.wood = (WoodType)woodChoice;
                //  Calculate the base area of each bookcase section and subtotal (without shelves)
                bcBack = models[selection].height * models[selection].width;
                bcSide = models[selection].height * models[selection].depth;
                bcShelf = models[selection].width * models[selection].depth;
                bcArea = bcBack + bcSide * 2 + bcShelf * 2;  //  Area for the base model, less shelves (in square inches)
                baseCost = bcArea * models[selection].baseCost / 144;  //  Base cost per square foot of wood

                //  Have user confirm the bookcase selection
                Console.WriteLine("You have selected {0} wood.", (WoodType)woodChoice);
                Console.WriteLine("The base cost for the {0} bookcase made of {1} wood is {2:C}.", models[selection].name, (WoodType)woodChoice, baseCost);
                Console.WriteLine("Would you like to proceed with this selection? (y/n)");  //  Confirm the selection
                inputString = Console.ReadLine();
                if (inputString == "n" || inputString == "N")  //  Assume a default respons of 'Yes'
                {
                    confirm = false;
                }
                else
                {
                    confirm = true;
                }
            } while (!confirm);

            //  How many shelves to include in the bookcase
            Console.Clear();
            maxShelves = (int)(models[selection].height / minShelfHeight);
            Console.WriteLine("The maximum allowable shelves for the {0} bookcase is {1}.", models[selection].name, maxShelves);
            do  // Validation loop to ensure proper data entry
            {
                Console.WriteLine("How many shelves would you like to include in your bookcase?");
                try  //  Check for valid data type
                {
                    shelfInput = Console.ReadLine();
                    shelfCount = Convert.ToInt32(shelfInput);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please enter a numerical value between 1 and {0}", models[selection].height / shelfCount);
                    validInput = false;
                    continue;
                }

                if (shelfCount < 0 || shelfCount > maxShelves)
                {
                    Console.WriteLine("Please enter a numerical value between 1 and {0}", models[selection].height / shelfCount);
                    validInput = false;
                }
                else
                {
                    validInput = true;
                }
            } while (!validInput);
            item.shelfNum = shelfCount;
            //  Calculate the total area of one bookcase in square inches
            bcTotalArea = bcArea + shelfCount * bcShelf;

            //  How many bookcases to purchase?
            Console.Clear();
            do  //  Confirmation loop for number to purchase
            {
                do  // Validation loop to ensure proper data entry
                {
                    //Ask user for bookcase selection and validate their response
                    Console.WriteLine("How many bookcases would you like to purchase?");
                    //Ask user for wood type selection and validate their response
                    try  //  Check for valid data type
                    {
                        inputString = Console.ReadLine();
                        numCases = Convert.ToInt32(inputString);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("Please enter a numerical value between 1 and {0}", maxPurchase);
                        validInput = false;
                        continue;
                    }

                    if (numCases < 1 || numCases > maxPurchase)
                    {
                        Console.WriteLine("Please enter a numerical value between 1 and {0}", maxPurchase);
                        validInput = false;
                    }
                    else
                    {
                        validInput = true;
                    }
                } while (!validInput);

                item.qty = numCases;  //  Add the user's selection of the number of cases to the order line item.

                totalCost = bcTotalArea * models[selection].baseCost / 144;  //  The total cost for 1 bookcase, with shelves
                item.cost = totalCost;  //  Add the total cost of one bookcase to the order line item.

                //  Print line item "receipt" and have user confirm the bookcase selection
                Console.WriteLine("You have selected to purchase {0} of the {1} bookcases made of {2}.", item.qty, item.bCase.name, item.wood);
                Console.WriteLine("Each bookcase will have {0} shelves.", item.shelfNum);
                Console.WriteLine("The cost for each bookcase is {0:C} for a grand total of {1:C}.", totalCost, totalCost * item.qty);
                Console.WriteLine("Would you like to proceed with this selection? (y/n)");  //  Confirm the selection
                inputString = Console.ReadLine();
                if (inputString == "n" || inputString == "N")  //  Assume a default respons of 'Yes'
                {
                    confirm = false;
                }
                else
                {
                    confirm = true;
                }
            } while (!confirm);  //  Continue with the order upon customer confirmation.  Replace the order

            //  Summarize this line item and calculate the necessary wood to order.
            Console.WriteLine(item.bCase.ToString());
            Console.WriteLine("The amount of wood to order for this order is {0:F0} sq in (or {1:F2} sq ft) of {2} wood.", bcArea * (1 + overage), (bcArea * (1 + overage)) / 144, (WoodType)woodChoice);

            order.Add(item);  //  Add the ordered item to the order list (for receipt printing purposes.

            Console.WriteLine("Thank you for using The Owl and the Worm!");
        }
    }
}
