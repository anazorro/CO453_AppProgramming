﻿using System;

namespace CO453_AppProgramming.SPS
{
    /// <summary>
    /// This class will draw the chosen options
    /// Author: Ana Zorro, ID: 21903356
    /// Started: 12/02/2019
    /// Last Update:
    /// </summary>
    class Images
    {
        /// <summary>
        /// *******************************************************
        /// This method will draw an image of Scissors on the console
        /// *******************************************************
        /// </summary>
        public static void DrawScissors(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   //Set start position then increment y to move down
            Console.Write("     \\            /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      \\          /");
            Console.SetCursorPosition(x, y++);
            Console.Write("       \\        /");
            Console.SetCursorPosition(x, y++);
            Console.Write("        \\      /");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\    /");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("           **");
            Console.SetCursorPosition(x, y++);
            Console.Write("          /  \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    (----/    \\----)");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\  /      \\  /");
            Console.SetCursorPosition(x, y++);
            Console.Write("      ==        ==");
            Console.WriteLine("\n\n");
        }

        /// <summary>
        /// *******************************************************
        /// This method will draw an image of a Stone on the console
        /// *******************************************************
        /// </summary>
        public static void DrawStone(int x, int y)
        {
            Console.SetCursorPosition(x, y++);   //Set start position then increment y to move down
            Console.Write("                 ___---___     ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              .--         --.    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           ./   ()       .-. \\.   ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           /   o    .   (   )  \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          / .            '-'    \\  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         /     ()   ()           \\ ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |    o           ()       | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("        |      .--.           O   | ");
            Console.SetCursorPosition(x, y++);
            Console.Write("         \\ .  |    |              |  ");
            Console.SetCursorPosition(x, y++);
            Console.Write("          \\   `.__.'     o   .   /    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("           `\\  o    ()         /'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("              `--___    ___--'    ");
            Console.SetCursorPosition(x, y++);
            Console.Write("                     ---         ");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// This method will draw an image of Paper on the console
        /// *******************************************************
        /// </summary>
        public static void DrawPaper(int x, int y)
        {
            Console.SetCursorPosition(x, y++);    //Set start position then increment y to move down
            Console.Write("      .--.------------------.");
            Console.SetCursorPosition(x, y++);
            Console.Write("     /      \\  \\ \\ \\ \\ \\ \\ \\ \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("    /   OOO  \\                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   || A N D R E X | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("   |   OOOO   |                |");
            Console.SetCursorPosition(x, y++);
            Console.Write("    \\   OOO   /                /");
            Console.SetCursorPosition(x, y++);
            Console.Write("     \\      // / / / / / / / //");
            Console.SetCursorPosition(x, y++);
            Console.Write("       `--'-|| | | | | | | | |");
            Console.SetCursorPosition(x, y++);
            Console.Write("             \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("              \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("               \\                \\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                \\ \\ \\ \\ \\ \\ \\ \\ \\\\");
            Console.SetCursorPosition(x, y++);
            Console.Write("                 \\________________\\");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// This method will draw an image of a Smile on the console
        /// *******************************************************
        /// </summary>
        public static void DrawSmile()
        {
            Console.WriteLine("\n                    .-\"\"\"\"-.-\"\"\"\"-. ");
            Console.WriteLine("               _.'`               `'._   ");
            Console.WriteLine("            .-'  __..,.___.___.,..__  '-.   ");
            Console.WriteLine("           '-.-;` |  |    |    |  | `;-.-'   ");
            Console.WriteLine("            \\'-\\_/\\__|    |    |__/\\_/-'/   ");
            Console.WriteLine("             \\, _     '---'---'     _ ,/   ");
            Console.WriteLine("              \\'./`'.--.--.--,--.'`\\.'/   ");
            Console.WriteLine("               \\ `'-;__|__|__|__;-'` /   ");
            Console.WriteLine("                '.                 .'   ");
            Console.WriteLine("                 `'-....---....-'`    ");
        }

        /// <summary>
        /// *******************************************************
        /// This method will draw an image of ThumbsUp on the console
        /// *******************************************************
        /// </summary>
        public static void DrawThumbsUp()
        {
            Console.WriteLine();
            Console.WriteLine("       _ ");
            Console.WriteLine("      ( ((  ");
            Console.WriteLine("       \\ =\\   ");
            Console.WriteLine("      __\\_ `-\\   ");
            Console.WriteLine("     (____))(  \\-----  ");
            Console.WriteLine("     (____)) _    ");
            Console.WriteLine("     (____))   ");
            Console.WriteLine("     (____))____/-----  ");
            Console.WriteLine();
        }

        /// <summary>
        /// *******************************************************
        /// This method will draw an image of ThumbsDown on the console
        /// *******************************************************
        /// </summary>
        public static void DrawThumbsDown()
        {
            Console.WriteLine();
            Console.WriteLine("       ______ ");
            Console.WriteLine("     ((____  \\-----  ");
            Console.WriteLine("     ((_____         ");
            Console.WriteLine("     ((_____      ");
            Console.WriteLine("     ((____   -----   ");
            Console.WriteLine("          /  /    ");
            Console.WriteLine("         (_((     ");
            Console.WriteLine();
        }
    }
}