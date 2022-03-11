using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;

        public void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name:" + FullName);
        }
    }
}
