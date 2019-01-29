using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_AppProgramming.Unit4
{
    /// <summary>
    /// 
    /// </summary>
    class TestDistanceConverter
    {
        private static double miles;
        private static double feet;
        
        /// <summary>
        /// This method will ask the user to enter the number of miles
        /// and it will convert that value to feet and display the
        /// result to the user
        /// </summary>
        public static void TestMilesToFeet()
        {
            UserLib.WriteTitle("Task 4.1 Miles -> Feet");
            miles = UserLib.GetDouble("Please enter the number of miles > ");
            feet = DistanceConverter.MilesToFeet(miles);
            Console.WriteLine("The number of feet = " + feet.ToString("#.##"));
        }

        /// <summary>
        /// 
        /// </summary>
        public static void TestFeetToMiles()
        {
            UserLib.WriteTitle("Task 4.1 Feet -> Miles");
            feet = UserLib.GetDouble("Please enter the number of feet > ");
            miles = DistanceConverter.FeetToMiles(feet);
            Console.WriteLine("The number of miles = " + miles.ToString("#.##"));
        }
    }
}
