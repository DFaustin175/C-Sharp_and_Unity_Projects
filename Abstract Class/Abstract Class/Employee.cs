﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    internal class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string FullName = FirstName + " " + LastName;
            Console.WriteLine("Name:" + FullName);
        }

        public override void Quit()
        {
            Console.WriteLine("Quit");
        }
    }
}
