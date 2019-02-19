using Microsoft.VisualStudio.TestTools.UnitTesting;
using CO453_AppProgramming;

namespace AppTesting
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestPlayerChoice()
        {
            Game.PlayerChoice = Game.PAPER;

            Assert.AreEqual(Game.PAPER, Game.PlayerChoice);
        }

        [TestMethod]
        public void TestComputerChoice()
        {
            Game.GetComputerChoice();
            string choice = Game.ComputerChoice;

            StringAssert.Contains(Game.PAPER + Game.SCISSORS + Game.STONE, choice);
        }

        /// <summary>
        /// This method will test that when the player chooses
        /// PAPER and the computer chooses STONE then the player
        /// is the winner
        /// </summary>
        [TestMethod]
        public void TestPaperStone()
        {
            Game.Start();

            Game.PlayerChoice = Game.PAPER;

            Game.ComputerChoice = Game.STONE;

            Game.WorkoutWinner();

            Assert.AreEqual(Game.Winner, Game.PlayerName);
        }

        /// <summary>
        /// This method will test that when the player chooses
        /// STONE and the computer chooses PAPER then the player
        /// is the winner
        /// </summary>
        [TestMethod]
        public void TestStonePaper()
        {
            Game.Start();

            Game.PlayerChoice = Game.STONE;

            Game.ComputerChoice = Game.PAPER;

            Game.WorkoutWinner();

            Assert.AreEqual(Game.Winner, Game.ComputerName);
        }

        /// <summary>
        /// This method will test that when the player chooses
        /// PAPER and the computer chooses SCISSORS then the player
        /// is the winner
        /// </summary>
        [TestMethod]
        public void TestPaperScissors()
        {
            Game.Start();

            Game.PlayerChoice = Game.PAPER;

            Game.ComputerChoice = Game.SCISSORS;

            Game.WorkoutWinner();

            Assert.AreEqual(Game.Winner, Game.ComputerName);
        }

        /// <summary>
        /// This method will test that when the player chooses
        /// SCISSORS and the computer chooses PAPER then the player
        /// is the winner
        /// </summary>
        [TestMethod]
        public void TestScissorsPaper()
        {
            Game.Start();

            Game.PlayerChoice = Game.SCISSORS;

            Game.ComputerChoice = Game.PAPER;

            Game.WorkoutWinner();

            Assert.AreEqual(Game.Winner, Game.PlayerName);
        }

        /// <summary>
        /// This method will test that when the player chooses
        /// STONE and the computer chooses SCISSORS then the player
        /// is the winner
        /// </summary>
        [TestMethod]
        public void TestStoneScissors()
        {
            Game.Start();

            Game.PlayerChoice = Game.STONE;

            Game.ComputerChoice = Game.SCISSORS;

            Game.WorkoutWinner();

            Assert.AreEqual(Game.Winner, Game.PlayerName);
        }

        /// <summary>
        /// This method will test that when the player chooses
        /// SCISSORS and the computer chooses STONE then the player
        /// is the winner
        /// </summary>
        [TestMethod]
        public void TestScissorsStone()
        {
            Game.Start();

            Game.PlayerChoice = Game.SCISSORS;

            Game.ComputerChoice = Game.STONE;

            Game.WorkoutWinner();

            Assert.AreEqual(Game.Winner, Game.ComputerName);
        }
    }
}