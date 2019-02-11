using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_AppProgramming.Unit5
{
    class Tournament
    {
        //Sets a constant size
        public const int MAXN_SCORES = 3;
        
        //Defines scores as a private integer array
        //and defines names as a private string array
        private int[] scores = new int[MAXN_SCORES];
        private string[] names = new string[MAXN_SCORES];

        /// <summary>
        /// This is the main method taht can be used to run an instance
        /// of this Tournament class
        /// </summary>
        public static void Main()
        {
            UserLib.WriteTitle("5.1 Tournament Scores");
            Tournament myTournament = new Tournament();
            myTournament.GetDetails();
            myTournament.ShowDetails();
            myTournament.ShowBest();
            Console.ReadKey();
        }

        //This is the class constructor
        public Tournament()
        {
            
        }

        //This method is to get the player's details  
        public void GetDetails()
        {
            for (int i = 0; i < MAXN_SCORES; i++)
            {
                names[i] = UserLib.GetString("Player name > ");
                Console.Write("Enter score " + (i + 1) + " > ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //This method is to show the player's details  
        public void ShowDetails()
        {
            Console.WriteLine();

            for (int i = 0; i < MAXN_SCORES; i++)
            {
                Console.WriteLine("Name: " + names[i] + "'s Score " + (i + 1) + " = " + scores[i]);
            }
        }

        //This method is to show the best score  
        public void ShowBest()
        {
            Console.WriteLine();
            int bestScore = 0;

            for(int i = 0; i < MAXN_SCORES; i++)
            {
                if(scores[i] > bestScore)
                {
                    bestScore = scores[i];
                }
            }
            Console.WriteLine("The best score is " + bestScore);
        }
    }
}
