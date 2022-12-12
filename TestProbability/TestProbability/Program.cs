bool keepLoop = true;
do
{
    /* Random rand = new Random();
     int yes = 0;
     const int iterations = 10000000;
     for (int i = 0; i < iterations; i++)
     {
         if (rand.Next(1, 101) <= 25)
         {
             yes++;
         }
     }
     Console.WriteLine((float)yes / iterations);
     Console.WriteLine("Want to keep looping?(y/n)");
    }*/
    int pDex = 8;

    int output = pDex * 10;
    //output /= 20;

    Console.WriteLine(output);

    //return output;
    if (Console.ReadLine() == "n")
    {
        keepLoop = false;
    }
    else
    {
        keepLoop = true;
    }
} while (keepLoop);