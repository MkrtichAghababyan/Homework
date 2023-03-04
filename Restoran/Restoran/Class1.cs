using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    class Restoran
    {
        public const int sushiprice = 2000;
        public const int hotdogprice = 200;
        public const int burgerprice = 700;
        //amen inchic mi mi hat sarquma 
        public Restoran(ref int forall, ref int zdachi)
        {
            if (zdachi - (forall * sushiprice + forall * hotdogprice + forall * burgerprice) >= 0)
            {
                MakeBurger(forall, ref zdachi);
                MakeHotDog(forall, ref zdachi);
                MakeSushi(forall, ref zdachi);
                Console.WriteLine($"Your Money: {zdachi}  Dram");
            }
            else
            {
                Console.WriteLine($"You Dont Have Enough Money To Buy Those All,You Will Need {(forall * sushiprice + forall * hotdogprice + forall * burgerprice)-zdachi} Drams More");
            }
        }
        public Restoran()
        {

        }
        //mi tup xz inch arji 
        public void MakeSushi(in int  qanak,ref int zdachi)
        {
            Console.WriteLine($"You Have Make {qanak} That Will Cost {sushiprice*qanak} Dram");
            if(zdachi - sushiprice * qanak < 0)
            {
                Console.WriteLine($"You Dont Have Enough Money");
            }
            else
            {
                zdachi -= sushiprice * qanak;
            }
        }
        public void MakeHotDog(in int qanak,ref int zdachi)
        {
            Console.WriteLine($"You Have Make {qanak} That Will Cost {hotdogprice * qanak} Dram");
            if (zdachi - hotdogprice * qanak < 0)
            {
                Console.WriteLine($"You Dont Have Enough Money");
            }
            else
            {
                zdachi -= hotdogprice * qanak;
            }
        }
        public void MakeBurger(in int qanak,ref int zdachi)
        {
            Console.WriteLine($"You Have Make {qanak} That Will Cost {burgerprice * qanak}  Dram");
            if (zdachi - burgerprice * qanak < 0)
            {
                Console.WriteLine($"You Dont Have Enough Money");
            }
            else
            {
                zdachi -= burgerprice * qanak;
            }
        }
        public void Reserve(out int qanak)
        {
            qanak = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int r = rnd.Next(0,5);
            if (r==0)
            {
                Console.WriteLine("There Are no More Sits,Please Come Later");
            }
            else if (r >= qanak)
            {
                Console.WriteLine("You Choose a few of those tables");
            }
            else
            {
                Console.WriteLine("There Are Less Sits Then You Want");
            }
        }
    }
}
