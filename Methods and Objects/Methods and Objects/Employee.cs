using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    internal class Employee : Person
    {
        public int Id;

       public static bool operator==(Employee employee, Employee employee2)
        {
            if (employee.Id == employee2.Id)
                return true;
            else 
                return false;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            if (employee.Id != employee2.Id)
                return false;
            else
                return true;
        }



    }
}
