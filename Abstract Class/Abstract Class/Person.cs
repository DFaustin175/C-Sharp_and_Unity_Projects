using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    abstract class Person : IQuittable
    {
        public string FirstName;
        public string LastName;

        public abstract void SayName();

        public abstract void Quit();
    }
}
