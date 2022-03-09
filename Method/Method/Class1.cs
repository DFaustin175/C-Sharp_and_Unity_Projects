using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Class1
    {
        public static void DoubleInt(string a, string b)
        {
            if(b == Console.ReadLine())
            {
                int a1 = Convert.ToInt32(a) + 15;
                Console.WriteLine(a1);
            }
            else if (b != null)
            {
                int a1 = Convert.ToInt32(a) + Convert.ToInt32(b);
                Console.WriteLine(a1);
            }
        }
    }
}
