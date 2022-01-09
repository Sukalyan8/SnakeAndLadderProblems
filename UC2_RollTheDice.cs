using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderProblem
{
    class UC2_RollTheDice
    {
        public static void RollTheDice()
        {
            int player = 1;
            int StartingPositon = 0;

            Random random = new Random();
            int DiceRoll = random.Next(1, 7);

            Console.WriteLine("No. of Player " + player);

            Console.WriteLine("You got number :" + DiceRoll);
            Console.ReadLine();
        }
    }

}

