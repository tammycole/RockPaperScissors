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
            if (against == "r")
            {
                string cr = r.GenerateRPS();
                Console.WriteLine(cr);
                return cr;
            }

            else
            {
                string cr = o.GenerateRPS();
                Console.WriteLine(cr);
                return cr;
            }
        }

        public static void Winner(string x, string y, string n, string ag)
        {
            if ((x == "rock" && y == "rock") || (x == "paper" && y == "paper") || (x == "scissors" && y == "scissors"))
            {
                Console.WriteLine("Draw!");
            }

            else if (x == "rock" && y == "paper")
            {
                Console.WriteLine(ag + "wins!");
            }

            else if (x == "rock" && y == "scissors")
            {
                Console.WriteLine(n + " wins!");
            }

            else if (x == "paper" && y == "rock")
            {
                Console.WriteLine(n + " wins!");
            }

            else if (x == "paper" && y == "scissors")
            {
                Console.WriteLine(ag + " wins!");
            }

            else if (x == "scissors" && y == "rock")
            {
                Console.WriteLine(ag + " wins!");
            }

            else if (x == "scissors" && y == "paper")
            {
                Console.WriteLine(n + " wins!");
            }
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