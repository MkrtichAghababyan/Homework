using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classtry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Humen h = new Humen();
            Console.Write("Enter Your Name Please:");
            string name = Console.ReadLine();
            h.Validation(name);
            Console.Write("Enter Your Surname Please:");
            string surname = Console.ReadLine();
            h.Validation(surname);
            Console.WriteLine("<------------------------------------->");
            Console.Write($"Your Name {name}\nMax Lertter Count;\n");
            h.CheckMaxCount(name);
            Console.Write($"Your Name {surname}\nMax Lertter Count;\n");
            h.CheckMaxCount(surname);
            Console.WriteLine("<------------------------------------->");
            switch (h.tr1 && h.tr2)
            {
                case true:
                    Console.WriteLine($"You Are {name} {surname}");
                    break;
                case false:
                    Console.WriteLine($"Study How To Write");
                    break;
            }
            Console.ReadKey();
        }
    }
}
