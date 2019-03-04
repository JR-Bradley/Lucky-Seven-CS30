using System;

namespace LuckySeven
{
    class Program
    {
        static void Main(string[] args)
        {
          int totalNumberOfSevens = 0;
          Random rng = new Random();

          int die1;
          int die2;
        
        // while (true)
        // {

        // }


            for (int i = 0; i < 100; i++)
            {
                die1 = rng.Next(1, 7);
                die2 = rng.Next(1, 7);

                if (die1 + die2 == 7)
                    totalNumberOfSevens++;
            }

            Console.WriteLine("Out of 100 rolls, you rolled {0} sevens", totalNumberOfSevens);
            Console.ReadLine();
        }
    }
}
