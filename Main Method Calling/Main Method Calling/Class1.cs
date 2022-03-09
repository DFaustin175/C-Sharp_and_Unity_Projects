using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Calling
{
    internal class Class1
    {
        public static void Add(int a)
        {
            int a1 = a + 1;
            Console.WriteLine(a1);
        }

        public static void Div(float b)
        {
            int b1 = Convert.ToInt32(b) / 2;
            Console.WriteLine(b1);
        }

        public static void Sub(string c)
        {
            int c1 = Convert.ToInt32(c) - 5;
            Console.WriteLine(c1);
        }
    }
}
