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
    /// This class plays The Scissors-Paper-Stone Game
    /// Author: Ana Zorro, ID: 21903356
    /// Started: 12/02/2019
    /// Last Update:
    /// </summary>
    public class Game
    {
        public const string SCISSORS = "SCISSORS";
        public const string STONE = "STONE";
        public const string PAPER = "PAPER";

        public static string PlayerName { get; set; }
        public static string ComputerName { get; set; }
        public static string ComputerChoice { get; set; }
        public static string PlayerChoice { get; set; }
        public static string Winner { get; set; }

        public static int PlayerScore { get; set; }
        public static int ComputerScore { get; set; }

        private static Random randomGenerator = new Random();

        //static void Main()
        //{
        //    Game myGame = new Game();

        //    myGame.Play();
        //}

        /// <summary>
        /// *******************************************************
        /// This method will Start the Game
        /// *******************************************************
        /// </summary>
        public static void Start()
        {
            PlayerScore = 0;
            ComputerScore = 0;

            PlayerName = "Ana";
            ComputerName = "The Computer";
        }

        /// <summary>
        /// *******************************************************
        /// This method will End the Game
        /// *******************************************************
        /// </summary>
        public static void End()
        {
            if (PlayerScore > ComputerScore)
                Winner = PlayerName;
            else if (PlayerScore < ComputerScore)
                Winner = ComputerName;
            else
                Winner = "No Winner";
        }

        /// <summary>
        /// *******************************************************
        /// This method will Get the Computer Choice
        /// *******************************************************
        /// </summary>
        public static void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);

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
        /// This method will Work out the Winner
        /// *******************************************************
        /// </summary>
        public static void WorkoutWinner()
        {
            if (PlayerChoice == ComputerChoice)
            {
                Winner = "No Winner";
            }
            else if ((PlayerChoice == STONE && ComputerChoice == PAPER) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == STONE) ||
                    (PlayerChoice == PAPER && ComputerChoice == SCISSORS))
            {
                Winner = ComputerName;
                ComputerScore++;
            }
            else if ((PlayerChoice == STONE && ComputerChoice == SCISSORS) ||
                    (PlayerChoice == SCISSORS && ComputerChoice == PAPER) ||
                    (PlayerChoice == PAPER && ComputerChoice == STONE))
            {
                Winner = PlayerName;
                PlayerScore++;
            }
        }
    }
}