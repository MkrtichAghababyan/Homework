using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ashhashvark
{
    internal class HowToLoseMoney
    {
        public static int Kextot(out int s)
        {
            s = int.Parse(Console.ReadLine());
            return s;
        }
        public static int Maqur(ref int s)
        {
            //karj asac chgitem vonca linum bayc motavorapes 20-ic 30% haves chka hashvelu 
            /*int ek = s * 20 / 100;
            int soc = s* 5 / 100;
            int zinpox = 0;
            if (s < 100000)
            {
                zinpox = 1500;
            }
            else if (s > 100000)
            {
                zinpox= 3000;
            }
            int kut = s* 4/ 100;
            s=s-ek-soc-zinpox-kut;*/
            s -= s * 30 / 100;
            return s;
        }
        static void Main(string[] args)
        {
            //esa 
            //ekamtahark
            //socvtar
            //zinvori pox <100000=1500 >3000
            //kutakayin 
            //nermucvoxy out en poxancumy refov
            int kext = Kextot(out int a);
            Maqur(ref kext);
            Console.WriteLine(kext);
            Console.ReadKey();
        }
    }
}
