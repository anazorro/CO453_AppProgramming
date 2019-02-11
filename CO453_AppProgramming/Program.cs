using System;
using CO453_AppProgramming.Unit4;
using CO453_AppProgramming.Unit5;

namespace CO453_AppProgramming
{
    /// <summary>
    /// Author: Ana Zorro
    /// 
    /// This class will run all the console app examples
    /// required for module CO453 Applications Programming
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            TestBook.Test();
            //Could be called scoreList but plural is best for arrays
            Console.ReadKey();
        }

        /// <summary>
        /// Archive tasks
        /// </summary>
        public void archive()
        {
            //unit 5 task car
            Car car = new Car();
            Car jazz = new Car();
            jazz.Model = "Jazz";
            Car bmw = new Car("BMW", "Series 1");
            Car ford = new Car("Ford", "Series 5");

            //TestBook.Test();

            //Task 4.1

            TestDistanceConverter.TestMilesToFeet();
            Console.WriteLine("");
            TestDistanceConverter.TestFeetToMiles();

            DistanceConverter.MilesToFeet(100);

            Console.ReadKey();

            

            //Ana task
            Console.WriteLine("Hello Ana!");

            //classes are used to create objects. ana is an object which is an instance of the Ana class.
            //i can have ana1 and ana2 that are intances of Ana class
            //Create three new objects from the class:

            //Ana ana = new Ana();
            //Ana ana1 = new Ana();
            //Ana ana2 = new Ana();

            //ana1.WriteTitle("My Wonder Application");
            //ana2.WriteTitle("My Wizard Application");

            //look at the two comments below
            //if it is a static, it can be accessed by using the class instead of object (ana, ana1, ana2)
            //so now I can use the class directly

            // //Ana.WriteTitle("My Wonder Application");

            // //Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
