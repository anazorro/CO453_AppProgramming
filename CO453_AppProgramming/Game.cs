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

        private string computerChoice;
        private string playerChoice;
        private string playerName = "Ana";

        private int computerScore = 0;
        private int playerScore = 0;

        public const int MAXN_TURNS = 3; //how many times the game will run before it finishes

        private Random randomGenerator;

        static void Main()
        {
            Game myGame = new Game();  // create new Game object
            myGame.Play();             // call its play method
        }

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
            for (int turn = 1; turn <= MAXN_TURNS; turn++)
            {
                SetupScreen();
                Start();

                GetPlayerChoice();
                GetComputerChoice();

                DrawChoice(Players.COMPUTER);
                DrawChoice(Players.PLAYER);

                ShowChoices();
                ShowResult();

                Console.ReadKey();
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void SetupScreen()
        {
            Console.Title = " The Great Scissors-Paper-Stone Game";

            Console.SetWindowSize(100, 36);
            Console.SetBufferSize(100, 36);

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Clear();  // clear screen in chosen colour
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void Start()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Play the Scissors Paper Stone Game");
            Console.WriteLine("==================================");
            Console.WriteLine();
            //playerName = UserLib.GetString("Please enter your name > ");
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void GetPlayerChoice()
        {
            Console.WriteLine(playerName + " what is your choice ?");
            Console.Write("Scissors Paper or Stone : ");

            playerChoice = Console.ReadLine();
            playerChoice = playerChoice.ToUpper();
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void GetComputerChoice()
        {
            int choice;
            choice = randomGenerator.Next(3);  // pick a random number (0, 1 or 2)
            if (choice == 0)
            {
                computerChoice = SCISSORS;
            }
            else if (choice == 1)
            {
                computerChoice = PAPER;
            }
            else if (choice == 2)
            {
                computerChoice = STONE;
            }
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowChoices()
        {
            Console.WriteLine("\n\t You picked " + playerChoice);
            Console.WriteLine("\tThe computer choice is " + computerChoice);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void ShowResult()
        {
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("\n\tA DRAW!!");
            }
            else if ((playerChoice == STONE && computerChoice == PAPER) ||
            (playerChoice == SCISSORS && computerChoice == STONE) ||
            (playerChoice == PAPER && computerChoice == SCISSORS))
            {
                computerScore = computerScore + 1;
            }
            else if ((playerChoice == PAPER && computerChoice == STONE) ||
                (playerChoice == STONE && computerChoice == SCISSORS) ||
                (playerChoice == SCISSORS && computerChoice == PAPER))
            {
                playerScore = playerScore + 1;
            }

            Console.WriteLine("\n\nThe Computer has won " + computerScore + " times");
            Console.WriteLine("\n\n" + playerName + " has won " + playerScore + " times");
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private void DrawChoice(Players player)
        {
            string choice;
            int x;

            if (player == Players.COMPUTER)
            {
                x = 50;
                choice = computerChoice;
            }

            else
            {
                choice = playerChoice;
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