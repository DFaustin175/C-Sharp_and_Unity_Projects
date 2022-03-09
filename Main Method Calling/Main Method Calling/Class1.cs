using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Calling
{
    internal class Class1
    {
        public static int a1;
        public static int b1;
        public static int c1;
        public static void Add(int a)
        {
            a1 = a + 1;
        }

        public static void Div(decimal b)
        {
            b1 = Convert.ToInt32(b) / 2;

        }

        public static void Sub(string c)
        {
            c1 = Convert.ToInt32(c) - 5;
        }
    }
}
