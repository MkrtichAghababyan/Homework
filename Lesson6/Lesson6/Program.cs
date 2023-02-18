using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Lesson6
{
    internal class Program
    {     
        public static int Fib(int n)
        {
            if(n==0 ||n==1)
                return n;
            else
                return Fib(n-1)+Fib(n-2);
        }
        public static BigInteger Fact(int n)
        {
            //max value = 25 ==long
            //max valiue = ? = biginteger
            //ete nerqevi codey activa kara mincehv 60>n<70;
            if (n == 1 || n == 0)
                return 1;
            else
                return n*Fact(n - 1); 
        }
    
        static void Main(string[] args)
        {

            //int[] arr = new int[] { 1,20,3,4,5,6,7,8,9,1,20,4,7,10,};
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i]+ " ");
            //}
            //Console.WriteLine();
            //int max = arr[0];
            //int index = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] >= max)
            //    {
            //        max = arr[i];
            //        index = i;
            //    }
            //}
            //Console.WriteLine(index);
            //Console.WriteLine(max);
            /*
             int c = 0;
             c=c++;
             Console.WriteLine(c);
             c=c++;
             Console.WriteLine(c);
             c= ++c;
             Console.WriteLine(c);
             c=c++;
             Console.WriteLine(c);
             c=c--;
             Console.WriteLine(c);
             c=++c;
             //Console.WriteLine(index+max);
             Console.WriteLine(c);
            */
            //0,1,1,2,3
            //c=a+b=1 a=b+c=2 c=a+b=3 a = a+c=5
            /*int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
           /* int a = 0;
            Console.WriteLine(a);
            int b = 1;
            Console.WriteLine(b);
            int c;
            /*for (int i = 0; i < n; i++)
            {
                c= a + b;
                Console.WriteLine(c);//1,5
                a = c + b;
                Console.WriteLine(a);//2,8
                b = a + c;
                Console.WriteLine(b);//3,13
            }
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 0; i < arr.Length-2; i++)
            {
                arr[i+2] = arr[i]+arr[i+1];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }*/
            //factoriali hamar 
            /*int n = int.Parse(Console.ReadLine());
            if (Fact(n) < 0)
            {
                Console.WriteLine(-1*Fact(n));
            }
            else
            Console.WriteLine(Fact(n));*/
            Console.WriteLine(Fact(100));










            Console.ReadKey();
        }
    }
}
