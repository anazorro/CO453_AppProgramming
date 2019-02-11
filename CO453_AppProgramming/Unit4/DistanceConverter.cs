namespace CO453_AppProgramming.Unit4
{
    //This class will convert miles to feet and feet to miles
    class DistanceConverter
    {
        public const int NO_FEET_PER_MILE = 1760 * 3;

        public static double MilesToFeet(double miles)
        {
            return miles * NO_FEET_PER_MILE;
        }

        public static double FeetToMiles(double feet)
        {
            return feet / NO_FEET_PER_MILE;
        }
    }
}