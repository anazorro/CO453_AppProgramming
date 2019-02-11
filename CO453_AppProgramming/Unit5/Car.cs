using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CO453_AppProgramming.Unit5
{
    public class Car
    {
        //attribute
        private string make = "Honda";

        //(prop tab tab) this is a property
        public string Model { get; set; }

        public Car()
        {
            Model = "Jazz";
        }

        public Car(string make, string model)
        {
            //this.make is the private make . equals the other make.
            this.make = make;
            this.Model = Model;
        }

        //Method
        public void Drive()
        {

        }
    }
}
