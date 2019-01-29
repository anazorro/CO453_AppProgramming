using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_AppProgramming
{
    /// <summary>
    /// This class contains useful methods that can be used 
    /// in a variety of other Console programs
    /// 
    /// Author: Ana Zorro
    /// </summary>
    class UserLib
    {
        public static void WriteTitle(string title)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Ana's " + title);
            Console.WriteLine("--------------------------");
            Console.WriteLine();
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static int GetInt(string prompt)
        {
            int mark;
            string input;

            Console.WriteLine();
            Console.Write(prompt);
            input = Console.ReadLine();
            mark = Convert.ToInt32(input);

            return mark;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static decimal GetDecimal(string prompt)
        {
            decimal amount;
            string input;

            Console.WriteLine();
            Console.Write(prompt);
            input = Console.ReadLine();
            amount = Convert.ToDecimal(input);

            return amount;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter a integer value which is
        /// input as a string and converted to an int
        /// </summary>
        public static double GetDouble(string prompt)
        {
            double amount;
            string input;

            Console.WriteLine();
            Console.Write(prompt);
            input = Console.ReadLine();
            amount = Convert.ToDouble(input);

            return amount;
        }

        /// <summary>
        /// This method displays a prompt for the
        /// user to enter their name
        /// </summary>
        public static string GetString(string prompt)
        {
            string input;

            Console.WriteLine();
            Console.Write(prompt);

            input = Console.ReadLine();

            return input;
        }
    }
}
