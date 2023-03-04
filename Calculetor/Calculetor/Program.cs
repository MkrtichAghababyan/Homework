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
            Console.WriteLine("gorcum e 2 tarberak irar tak grelu ev mi toxi vra grelu ete cankanum eq mi toxi vra apa grum eq hakarak depqum enter ev irar tak enter talov grum");
            string s1 = Console.ReadLine();
            string harc="ayo";
            string s;
            double a;
            double b;
            if (s1 == "")
            {
                a = double.Parse(Console.ReadLine());
                s = Console.ReadLine();
                b = double.Parse(Console.ReadLine());
                while (harc=="ayo")
                {
                    switch (s)
                    {
                        case "+":
                            Console.WriteLine($"patasxan {Sum(a, b)}");
                            break;
                        case "-":
                            Console.WriteLine($"patasxan {Min(a, b)}");
                            break;
                        case "*":
                            Console.WriteLine($"patasxan {Mult(a, b)}");
                            break;
                        case "/":
                            Console.WriteLine($"patasxan {Div(a,b)}");
                            break;
                        default:
                            Console.WriteLine("Nermucvac nshany sxal e xndrum enq porcel noric");
                            break;
                    }
                    Console.WriteLine("sharunakel hamar grel ayo hakarak depqum voch");
                    harc = Console.ReadLine();
                    s = Console.ReadLine();
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                }
            }
            else
            {
                harc = "ayo";
                string s2 = s1[0].ToString();
                string s3 = s1[2].ToString();
                double a1 = Convert.ToDouble(s2);
                double b1 = Convert.ToDouble(s3);
                while (harc=="ayo")
                {
                    switch (s1[1])
                    {
                        case '+':
                            Console.WriteLine($"patasxan {Sum(a1, b1)}");
                            break;
                        case '-':
                            Console.WriteLine($"patasxan {Min(a1, b1)}");
                            break;
                        case '*':
                            Console.WriteLine($"patasxan {Mult(a1, b1)}");
                            break;
                        case '/':
                            Console.WriteLine($"patasxan {Div(a1, b1)}");
                            break;
                        default:
                            Console.WriteLine("Nermucvac nshany kam tvanshany sxal e xndrum enq porcel noric");
                            break;
                    }
                    Console.WriteLine("sharunakel hamar grel ayo hakarak depqum voch");
                    harc = Console.ReadLine();
                    s1 = Console.ReadLine();
                }
            }
            int? x = 6;
            int y = 5;
            if (x > y) { Console.WriteLine(true); }
            Console.ReadKey();
        }
    }
}
