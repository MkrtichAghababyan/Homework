using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson5
{
    internal class Program
    {
        public static int Meth()
        {
            return 1;
        }
        public static int Meth(int n,int m)
        {
            return n+m;
        }
        public static int Meth(int a,int b,int c )
        {
            return a+b+c;
        }
        public static double Meth(double x,double y)
        {
            return x*y;
        }
        static void Main(string[] args)
        {
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //double d = double.Parse(Console.ReadLine());
            //double e = double.Parse(Console.ReadLine());
            //Meth();
            //Meth(c,b);
            //Meth(a, b, c);
            //Meth(b,e);
            //Console.WriteLine(Meth());
            //Console.WriteLine(Meth(c, b));
            //Console.WriteLine(Meth(a, b, c));
            //Console.WriteLine(Meth(b, e));



            //hetqrqir xndir
            //string al = " abcdefghijklmnopqrstuvwxyz";
            //int[] counts = new int[al.Length];
            //string s = "aabcaddaa";
            //int count = 0;
            //for(int i = 0; i < al.Length; i++)
            //{
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        if (al[i] == s[j])
            //        {
            //            count++;
            //        }
            //    }
            //    counts[i] = count;
            //    count = 0;
            //}
            //int max = counts[0];
            //for (int i = 1; i < counts.Length; i++)
            //{
            //    if (counts[i] > max)
            //    {
            //        max = counts[i];
            //    }
            //}
            //Console.WriteLine(max);
            //string s = Console.ReadLine();
            //int count = 0;
            //int maxcount = 0;
            //int index = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        if (s[i] == s[j])
            //        {
            //            count++;
            //        }
            //        if(maxcount<count)
            //        {
            //            maxcount = count;
            //            index = i;
            //        }
            //    }
            //    count= 0;
            //}
            //Console.WriteLine($"Maxcount = {maxcount};\n" +
            //                  $"Index = {index};\n"+
            //                  $"Letter = {s[index]};");


            //stringbuilder
            //StringBuilder s  = new StringBuilder();
            //s.AppendLine("asdasd");
            //string s1 = "asfas";
            //s.Insert(s.Length, "asfasf"); Console.WriteLine(s);
            //Console.WriteLine(s.GetType());
            //Console.WriteLine(s1.GetType());
            //string s2 = s1 + s;
            //Console.WriteLine(s2);

            int j = 0;
            int[] arr = new int[] { };
            for (int i = 0; i < arr.Length; i++,j++)
            {
                arr = new int[j];
                arr[i] = i;
                Console.WriteLine(arr[i]);
            }
            



            Console.ReadKey();
        }
    }
}
