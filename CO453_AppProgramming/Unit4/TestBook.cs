using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_AppProgramming.Unit4
{
    class TestBook
    {
        public static void Test()
        {
            ///new sintax to initialise values of the properties
            Book myBook = new Book()
            {
                Author = "Ana",
                Title = "My Horror Story",
                Weapon = "Cross Bow",
                Name = "Lucia",
                Gender = GenderTypes.FEMALE
            };

            myBook.GetDetails();
            myBook.WriteChapter(1);
        }
        
    }
}
