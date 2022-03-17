using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the current day of the week");
            try
            {
                DaysoftheWeek today = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek), Console.ReadLine());
                Console.WriteLine(today.ToString());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter a real day of the week", ex);
                Console.ReadLine();
                return;
            }

        }

        public enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
    }
}
