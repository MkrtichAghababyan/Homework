using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculetor
{
    internal class Program
    {
        public static int Sum(int a,int b)
        {
            return a+b; 
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static int Min(int a, int b)
        {
            return a - b;
        }
        public static double Min(double a, double b)
        {
            return a - b;
        }
        public static long Mult(int a, int b)
        {
            return a * b;
        }
        public static double Mult(double a, double b)
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            return a/b;
        }
        static void Main(string[] args)
        {
            //hatuk irar tak u irar kpac grelu hamar
            bool bl = true;
            string s1 = Console.ReadLine();
            string s;
            double a;
            double b;
            if (s1 == "")
            {
                a = double.Parse(Console.ReadLine());
                s = Console.ReadLine();
                b = double.Parse(Console.ReadLine());
                while (bl == true)
                {
                    switch (s)
                    {
                        case "+":
                            Console.WriteLine(Sum(a, b));
                            bl = false;
                            break;
                        case "-":
                            Console.WriteLine(Min(a, b));
                            bl = false;
                            break;
                        case "*":
                            Console.WriteLine(Mult(a, b));
                            bl = false;
                            break;
                        case "/":
                            Console.WriteLine(Div(a, b));
                            bl = false;
                            break;
                        default:
                            Console.WriteLine("Nermucvac nshany sxal e xndrum enq porcel noric");
                            break;
                    }
                }
            }
            else
            {
                string s2 = s1[0].ToString();
                string s3 = s1[2].ToString();
                double a1 = Convert.ToDouble(s2);
                double b1 = Convert.ToDouble(s3);
                while (bl == true)
                {
                    switch (s1[1])
                    {
                        case '+':
                            Console.WriteLine(Sum(a1, b1));
                            bl = false;
                            break;
                        case '-':
                            Console.WriteLine(Min(a1, b1));
                            bl = false;
                            break;
                        case '*':
                            Console.WriteLine(Mult(a1, b1));
                            bl = false;
                            break;
                        case '/':
                            Console.WriteLine(Div(a1, b1));
                            bl = false;
                            break;
                        default:
                            Console.WriteLine("Nermucvac nshany sxal e xndrum enq porcel noric");
                            break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
