using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Calling
{
    internal class Class1
    {
        public static void Add(int x)
        {
            int A = x + 100;
            Console.WriteLine(A);
        }

        public static void Mult(int z)
        {
            int B = z * 100;
            Console.WriteLine(B);
        }

        public static void Sub(int c)
        {
            int C = 100 - c;
            Console.WriteLine(C);
        }
    }
}
