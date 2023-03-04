using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace fact
{
    class Exchange
    {
        public const decimal Dolar = 388.17M;//dram
        public const decimal Euro = 412.35M;
        public const decimal Dolare = 1.06M;
        public const decimal Eurod = 0.94M;
        public Exchange(out decimal value,out string first,out string second)
        {
            bool b = true;
            string s = " ";
            value= 0;
            first = " ";
            second = " ";
            while (b== true) 
            {
                Console.Write("Enter Amount Of Money: ");
                value = int.Parse(Console.ReadLine());
                Console.Write("Enter The Type Of Money: ");
                first = Console.ReadLine();
                Console.Write("Enter The Type Of Exchange Money: ");
                second = Console.ReadLine();
                if (first == "dram" && second == "dolar")
                {
                Console.WriteLine(DramDolar(value));
                    Console.WriteLine("Wanna try again?");
                    s = Console.ReadLine();
                    if (s == "yes")
                    {
                        b = true;
                    }
                    else if (s == "no")
                    {
                        b = false;
                    }
                }
                else if (first == "dolar" && second == "dram")
                {
                    Console.WriteLine(DolarDram(value));
                    Console.WriteLine("Wanna try again?");
                    s = Console.ReadLine();
                    if (s == "yes")
                    {
                        b = true;
                    }
                    else if (s == "no")
                    {
                        b = false;
                    }
                }
                else if (first == "dram" && second == "evro")
                {
                    Console.WriteLine(DramEuro(value));
                    Console.WriteLine("Wanna try again?");
                    s = Console.ReadLine();
                    if (s == "yes")
                    {
                        b = true;
                    }
                    else if (s == "no")
                    {
                        b = false;
                    }
                }
                else if (first == "evro" && second == "dram")
                {
                    Console.WriteLine(EuroDram(value));
                    Console.WriteLine("Wanna try again?");
                    s = Console.ReadLine();
                    if (s == "yes")
                    {
                        b = true;
                    }
                    else if (s == "no")
                    {
                        b = false;
                    }
                }
                else if(first == "evro" && second == "dolar")
                {
                    Console.WriteLine(EuroDolar(value));
                    Console.WriteLine("Wanna try again?");
                    s = Console.ReadLine();
                    if (s == "yes")
                    {
                        b = true;
                    }
                    else if (s == "no")
                    {
                        b = false;
                    }
                }
                else if (first=="dolar" && second=="evro")
                {
                    Console.WriteLine(DolarEuro(value));
                    Console.WriteLine("Wanna try again?");
                    s = Console.ReadLine();
                    if (s == "yes")
                    {
                        b = true;
                    }
                    else if (s == "no")
                    {
                        b = false;
                    }
                }
                else
                {
                    Console.WriteLine("One Of Entered Options Are/Is Wrong Try Again");
                }
            }
        }
        public decimal DolarDram(decimal d) 
        {
            return d * Dolar;
        }
        public decimal DramDolar(decimal d)
        {
            return d/Dolar;
        }
        public decimal EuroDram(decimal d)
        {
            return d * Euro;
        }
        public decimal DramEuro(decimal d)
        {
            return d/Euro;
        }
        public decimal EuroDolar(decimal d)
        {
            return d*Dolare;
        }
        public decimal DolarEuro(decimal d)
        {
            return d * Eurod;
        }
    }
}
