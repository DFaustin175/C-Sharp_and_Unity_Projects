using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Calling
{
    internal class Class1
    {
        public static int Add(int a)
        {
           int a1 = a + 1;
            return a1;
        }

        public static int Div(decimal b)
        {
            int b1 = Convert.ToInt32(b) / 2;
            return b1;

        }

        public static int Sub(string c)
        {
             int c1 = Convert.ToInt32(c) - 5;
            return c1;
        }
    }
}
