using System;

namespace Leson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            int y = 8;
            bool z = x > y;
            bool f = x >= y;
            bool d = x <= y;
            bool e = x == y;
            bool j = x != y;
            bool q = x < y;
            double d1 = 9.1212414;
            double d2 = 9.123414;
            double res = d1 / d2;
            Console.WriteLine(res);
            Console.WriteLine(z);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(j);
            Console.WriteLine(q);
            if (x > y && d1>d2)
            {
                Console.WriteLine(x+d1);
            }
            else
            {
                Console.WriteLine(y+d2);
            }
        }
    }
}
