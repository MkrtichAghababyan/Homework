using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    internal class Program
    {
      /*  public static decimal? Mult(decimal? a, decimal? b, decimal? c, decimal? d)
        {
            return a * b * c * d;
        }
        public static long Fact(int fact)
        {
            if(fact == 0 || fact ==1) 
                return 1;
            else 
                return Fact(fact-1)*fact;
        }*/
        static void Main(string[] args)
        {
            /* int fact = 20;
             int a= int.Parse(Console.ReadLine());
             int b= int.Parse(Console.ReadLine());
             int c= int.Parse(Console.ReadLine());
             int d= int.Parse(Console.ReadLine());
             Console.WriteLine(Mult(a, b, c, d));
             Console.WriteLine(Fact(fact));*/
            Exchange ex = new Exchange(out decimal value, out string first, out string second);
            Console.ReadKey();
        }
    }
}
