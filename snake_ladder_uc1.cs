using System;

namespace snake__and__ladder_project
{
    class Sanke_ladder_uc1
    {
        static void Main(string[] args)
        {
            //Constants
            int NO_OPERATION = 0;
            int SNAKE_POSITION = 1;
            int LADDER_POSITION= 2;
            //variables
            int position = 0;
            Random random = new Random();
            //computation
            int Move = random.Next(1,6);
            int option = random.Next(0, 2);
            Console.WriteLine("game start position is o");

        }
    }
}

