using System;
using System.Linq;

namespace CO453_AppProgramming.Unit5
{
    class MP3TopTen
    {
        //Sets a constant size
        public const int MAXN_SONGS = 10;

        //Defines votes as a private integer array and uses the constant
        private int[] votes = new int[10];

        //Defines songs as a private string array
        private string[] songs = new string[]
            {
                "Sweet but Psycho",
                "7 Rings",
                "Swan Song",
                "Nothing Breaks Like a Heart",
                "Baby",
                "Dancing with a Stranger",
                "Rewrite the Stars",
                "Without Me",
                "Perfect to Me",
                "Giant"
            };

        /// <summary>
        /// This is the main method that can be used to run an instance
        /// of this MP3TopTen class
        /// </summary>
        public static void Main()
        {
            MP3TopTen chart = new MP3TopTen();

            chart.Show();
            chart.GetVote();

            Console.ReadKey();
        }

        //This method shows how many votes each song has
        public void Show()
        {
            Console.Clear();
            UserLib.WriteTitle("Top Ten MP3");

            int i = 0;
            foreach (string song in songs)
            {
                i++;
                Console.WriteLine("\tSong No " + i + " has " + " < " + votes[i - 1] + " > " + " votes " + song);
                //Console.WriteLine("\tTotal number of votes " + " < " + votes[i] + " > ");
            }
        }

        /// <summary>
        /// This method will repeatedly ask the user to vote for one
        /// of the top ten songs. It will store that vote in a votes
        /// array.
        /// </summary>
        public void GetVote()
        {
            int songNo;
            UserLib.WriteTitle("Top 10 MP3 Songs");
            do
            {
                songNo = UserLib.GetInt("Choose 1 - " + songs.Count() + " > ");

                if(songNo > 0 && songNo <= MAXN_SONGS)
                {
                    votes[songNo - 1]++;
                    Show();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Song " + songNo + "does not exists!");
                }
                Show();
            } while (songNo != 0);
            
        }
    }
}