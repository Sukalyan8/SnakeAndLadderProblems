﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadderProblem
{
    class UC3_CheckingPosition
    {
        public const int NoPlay = 0;
        public const int GotLadder = 1;
        public const int SnakeBite = 2;
        public static void CheckingPosition()
        {

            Random random = new Random();
            int DiceRoll = random.Next(1, 7);

            Console.WriteLine("You are getting the Number:" + DiceRoll);

            Random random1 = new Random();
            int Check = random1.Next(0, 3);

            Console.WriteLine("Checking The status:" + Check);
            if (Check == NoPlay)
            {
                Console.WriteLine("The player stays in the same Position");
            }
            else if (Check == GotLadder)
            {
                Console.WriteLine("Well done You are moving Forward By: " + DiceRoll);
            }
            else if (Check == SnakeBite)
            {
                Console.WriteLine(" Oops You are moving Backward by:" + DiceRoll);
            }

        }
    }
}
