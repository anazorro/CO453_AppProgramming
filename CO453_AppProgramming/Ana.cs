using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_AppProgramming
{
    /// <summary>
    /// Author: Ana Zorro
    /// 
    /// This class is just used to try things out!
    /// </summary>
    public static class Ana
    {
        private static string name;

        /// <summary>
        /// Thus initialises the Ana Class and is used
        /// for creating object
        /// </summary>
        //public Ana()
       //{
            //Above is a constructor
            //name = "Ana";
            //initialising name stored inside the class looks like this:

       //}
        /// <summary>
        /// This method writes out a title for an application
        /// </summary>
        /// <param name="title">This is the Application Title</param>
        public static void WriteTitle(string title)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("Ana's " + title);
            Console.WriteLine("==================================================");
        }
    }
}
