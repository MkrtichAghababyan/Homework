using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Classtry
{
    class Meth
    {
        public int res;//default 0;
        public Meth(int a)
        {

        }
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public  Meth(int a, int b)
        {
           res = Sum(a, b);
        }
        public void Print()
        {
            Console.WriteLine(res);
        }
    }
}
