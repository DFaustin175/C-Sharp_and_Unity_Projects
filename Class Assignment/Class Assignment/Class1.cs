using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Assignment
{
    internal class Class1
    {
        public void Div(int a)
        {
            float a1 = a / 2;
            Console.WriteLine(a1);
        }

        public void Out(out int num)
        {
            num = 25;
        }

        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Add(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }
    }

    internal static class Class2
    {

    }
}
