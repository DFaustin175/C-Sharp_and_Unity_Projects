using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    internal class Employee<T> : Person
    {
        public int Id;

        public int Length { get; internal set; }

        public void things(T input) { }
        

       public static bool operator==(Employee<T> employee, Employee<T> employee2)
        {
            if (employee.Id == employee2.Id)
                return true;
            else 
                return false;
        }

        public static bool operator !=(Employee<T> employee, Employee<T> employee2)
        {
            if (employee.Id != employee2.Id)
                return false;
            else
                return true;
        }



    }
}
