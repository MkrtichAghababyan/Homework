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
            Console.WriteLine(z);
            Console.WriteLine(f);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(j);
            Console.WriteLine(q);
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(y);
            }
        }
    }
}
