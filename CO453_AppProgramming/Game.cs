using System;
using CO453_AppProgramming.SPS;

namespace CO453_AppProgramming
{
    public enum Players
    {
        COMPUTER,
        PLAYER
    }

    /// <summary>
    /// This class plays ...
    /// Author: Ana Zorro, ID: 21903356
    /// Started: 12/02/2019
    /// </summary>
    class Game
    {
        public const string SCISSORS = "SCISSORS";
        public const string STONE = "STONE";
        public const string PAPER = "PAPER";

        public static string ComputerChoice { get; set; }

        public static string PlayerChoice { get; set; }

        public static string Winner { get; set; }

        public static int ComputerScore = 0;
        public static int PlayerScore = 0;

        
        private static Random randomGenerator;

        //static void Main()
        //{
        //    Game myGame = new Game();  // create new Game object
        //    myGame.Play();             // call its play method
        //}

        /// <summary>
        /// *******************************************************
        /// Create a new random number generator object
        /// *******************************************************
        /// </summary>
        public Game()
        {
            randomGenerator = new Random();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public void Play()
        {
            
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void WorkOutResult()
        {
            if (PlayerChoice == ComputerChoice)
            {
                Winner = "Draw";
            }
            else if ((PlayerChoice == STONE && ComputerChoice == PAPER) ||
            (PlayerChoice == SCISSORS && ComputerChoice == STONE) ||
            (PlayerChoice == PAPER && ComputerChoice == SCISSORS))
            {
                ComputerScore = ComputerScore + 1;
                Winner = "Computer";
            }
            else if ((PlayerChoice == PAPER && ComputerChoice == STONE) ||
                (PlayerChoice == STONE && ComputerChoice == SCISSORS) ||
                (PlayerChoice == SCISSORS && ComputerChoice == PAPER))
            {
                PlayerScore = PlayerScore + 1;
                Winner = "Player";
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);  // pick a random number (0, 1 or 2)
            if (choice == 0)
            {
                ComputerChoice = SCISSORS;
            }
            else if (choice == 1)
            {
                ComputerChoice = PAPER;
            }
            else if (choice == 2)
            {
                ComputerChoice = STONE;
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        public static void DrawChoice(Players player)
        {
            string choice;
            int x;

            if (player == Players.COMPUTER)
            {
                x = 50;
                choice = ComputerChoice;
            }

            else
            {
                choice = PlayerChoice;
                x = 5;
            }

            if (choice == SCISSORS)
            {
                Images.DrawScissors(x, 7);
            }
            else if (choice == PAPER)
            {
                Images.DrawPaper(x, 7);
            }
            else if (choice == STONE)
            {
                Images.DrawStone(x, 7);
            }
        }
    }
}