using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CO453_AppProgramming.SPS;

namespace CO453_AppProgramming.SPS
{
    /// <summary>
    /// This class will handle the input and output 
    /// of the SPS Game
    /// </summary>
    public static class GameInterface
    {
        private static string playerName = "Ana";

        private static Game game = new Game();

        public const int MAXN_TURNS = 3; //how many times the game will run before it finishes

        public static void RunGame()
        {
            for (int turn = 1; turn <= MAXN_TURNS; turn++)
            {
                SetupScreen();
                StartGame();

                GetPlayerChoice();
                Game.GetComputerChoice();

                Game.DrawChoice(Players.COMPUTER);
                Game.DrawChoice(Players.PLAYER);

                Game.WorkOutResult();

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
        private static void ShowChoices()
        {
            Console.WriteLine("\n\t You picked " + Game.PlayerChoice);
            Console.WriteLine("\tThe computer choice is " + Game.ComputerChoice);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void ShowResult()
        {
            if(Game.Winner == "Draw")
            {
                Console.Write("\n\nThis was a draw");
            }
            else
            {
                Console.Write("\n\nThe " + Game.Winner + " has won");
            }

            Console.WriteLine(" Computer = " + Game.ComputerScore + " Player = " + Game.PlayerScore);
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void GetPlayerChoice()
        {
            Console.WriteLine(playerName + " what is your choice ?");
            Console.Write("Scissors Paper or Stone : ");

            string choice = Console.ReadLine();
            choice = choice.ToUpper();
            Game.PlayerChoice = choice;
        }

        /// <summary>
        /// *******************************************************
        /// 
        /// *******************************************************
        /// </summary>
        private static void SetupScreen()
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
        private static void StartGame()
        {
            Console.WriteLine("==================================");
            Console.WriteLine("Play the Scissors Paper Stone Game");
            Console.WriteLine("==================================");
            Console.WriteLine();
            //playerName = UserLib.GetString("Please enter your name > ");
        }
    }
}
