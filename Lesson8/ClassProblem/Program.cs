using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string c = Console.ReadLine();
            Milk milkproduck = new Milk();
            Console.WriteLine(milkproduck.MakeSmetan(a, b, c));
            Console.WriteLine();
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Console.ReadLine();
            Console.WriteLine(milkproduck.MakeMatzoon(a,b,c));
            Console.WriteLine();
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = Console.ReadLine();
            Console.WriteLine(milkproduck.MakeMatzoon(a,b,c));
            Console.ReadKey();
        }
    }
}
