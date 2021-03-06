﻿using System;

namespace RockPaperScissors
{
    class RPSapp

    {
        RPSGenerator rps = new RPSGenerator();

        public static string Welcome()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine("");
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        public static string Opponent()
        {
            Console.WriteLine("Would you like to play against Rocky or Tim(r/t)?");
            string against = Console.ReadLine();

            //try
            //{
                if (against == "t")
                {
                    return "Tim";
                }
                else if (against == "r")
                {
                    return "Rocky";
                }
           // }
            
            /*catch
            {
                Opponent();
            }*/

            return against;
           
        }

        public static string Choice()
        {
            Console.WriteLine("Rock, paper or scissors? (R/P/S): ");
            string choice = Console.ReadLine();
            return choice;
        }

        public static string Calculate(string against, Rocky r, Other o)
        {
            if (against == "Rocky")
            {
                string cr = r.GenerateRPS();
                Console.WriteLine(against + ": " + cr);
                return cr;
            }

            else if (against == "Tim")
            {
                string cr = o.GenerateRPS();
                Console.WriteLine("Tim: " + cr);
                return cr;
            }
            else
            {
                //Check into this section -- not sure how to make it throw an exception
                Console.WriteLine("Please choose r or t.");
                string tryAgain = RPSapp.Opponent();
                return tryAgain;
            }
        }

        public static void hcDisplay(string n, string hc)
        {
            Console.WriteLine(n + ": " + hc);
        }

        public static void Winner(string x, string y, string n, string ag)
        {
            //wanted to return total, wins, losses and ties, but not sure how to return 4 values
            int all = 1;
            int hw = 0;
            int hl = 0;
            int tie = 0;

            if (x == "rock" && y == "rock" || x == "paper" && y == "paper" || x == "scissors" && y == "scissors")
            {
                Console.WriteLine("Draw!");
                tie++;
                all++;
            }

            else if (x == "rock" && y == "paper")
            {
                Console.WriteLine(n + " wins!");
                hw++;
                all++;
            }

            else if (x == "rock" && y == "scissors")
            {
                Console.WriteLine(ag + " wins!");
                hl++;
                all++;
            }

            else if (x == "paper" && y == "rock")
            {
                Console.WriteLine(ag + " wins!");
                hl++;
                all++;
            }

            else if (x == "paper" && y == "scissors")
            {
                Console.WriteLine(n + " wins!");
                hw++;
                all++;
            }

            else if (x == "scissors" && y == "rock")
            {
                Console.WriteLine(n + " wins!");
                hw++;
                all++;
            }

            else if (x == "scissors" && y == "paper")
            {
                Console.WriteLine(ag + " wins!");
                hl++;
                all++;
            }
           
        }

        //didn't figure out a way to make this work
        public static void FinalCount(int a, int m, int r, int t)
        {
            Console.WriteLine("You played " + a + "games. You won " + m+ " times, Rocky won " + r+ " times, and Tim won " + t+ " times." );
        }

        public static bool Continue()
        {
            Console.WriteLine("Play again? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }

            return goOn;
        }

    }
}
