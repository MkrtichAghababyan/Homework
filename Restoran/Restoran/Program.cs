using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qanak = int.Parse(Console.ReadLine());
            int pox = int.Parse(Console.ReadLine());
            Restoran r = new Restoran(ref qanak,ref pox);
            //r.MakeHotDog(qanak, ref pox);
            //r.MakeBurger(qanak, ref pox);
            //r.MakeSushi(qanak, ref pox);
            r.Reserve(out int s);




            Console.ReadKey();
        }
    }
}
