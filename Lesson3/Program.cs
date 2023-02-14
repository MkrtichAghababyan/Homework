using System;
using System.Xml;

namespace Lesson3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //21
            //Console.WriteLine(21);
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int c = int.Parse(Console.ReadLine());
            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine(b);
            //}
            //else {
            //    Console.WriteLine(c);
            //}
            ////22
            //Console.WriteLine();
            //Console.WriteLine(22);
            //if (a < b && a < c)
            //{
            //    Console.WriteLine(a);
            //}
            //else if (b  <a && b < c)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //}
            ////23
            //Console.WriteLine();
            //Console.WriteLine(23);
            //if (a ==1 && b!=1 && c!=1)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (c == 1 && b != 1 && a != 1)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (b == 1 && c != 1 && a != 1)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            ////24
            //Console.WriteLine( );
            //Console.WriteLine(24);
            //if (a == 2 && b == 2 && c != 2)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (c == 2 && b == 2 && a != 2)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (b == 1 && c == 2 && a != 2)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            ////25
            //Console.WriteLine();
            //Console.WriteLine(25);
            //int y;
            //if (Math.Pow(a,2)+Math.Pow(b,2)==Math.Pow(c,2))
            //{
            //    y = 1;
            //}
            //else {
            //    y = 2; 
            //}
            //Console.WriteLine(y);
            ////26
            //Console.WriteLine( );
            //Console.WriteLine(26);
            //if (a%2==0 || b%2==0 || c%2==0)
            //{
            //    Console.WriteLine(1);
            //}
            //else
            //{
            //    Console.WriteLine(2);
            //}
            ////27
            //Console.WriteLine();
            //Console.WriteLine(27);
            //if (c-b==b-a)
            //{
            //    Console.WriteLine(true);
            //}
            //else { 
            //    Console.WriteLine(false);
            //}
            ////28
            //Console.WriteLine();
            //Console.WriteLine(28);
            //if (Math.Sqrt(a*b) == c)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            ////29
            //Console.WriteLine();
            //Console.WriteLine(29);
            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //    if (b > c)
            //    {
            //        Console.WriteLine(b);
            //        Console.WriteLine(c);
            //    }
            //    else{
            //        Console.WriteLine(c);
            //        Console.WriteLine(b);
            //    }
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine(b);
            //    if (a > c)
            //    {
            //        Console.WriteLine(a);
            //        Console.WriteLine(c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c);
            //        Console.WriteLine(a);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //    if (a>b)
            //    {
            //        Console.WriteLine(a);
            //        Console.WriteLine(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b);
            //        Console.WriteLine(a);
            //    }
            //}
            ////30
            //Console.WriteLine();
            //Console.WriteLine(30);
            //Console.WriteLine();
            //Console.WriteLine(56);
            ////34
            //Console.WriteLine();
            //Console.WriteLine(35);
            //if (a == b && a == c || b == a && b == c || c == b && c == a)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            ////35
            //Console.WriteLine();
            //Console.WriteLine(35);
            //if(a==b+c || b==a+c || c == a + c)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            ////36
            //Console.WriteLine();
            //Console.WriteLine(36);
            //if (a % 2 == 1 && b % 2 == 1 || c % 2 == 1 && b % 2 == 1 || a % 2 == 1 && c % 2 == 1)
            //{
            //    Console.WriteLine(true);
            //}
            //else
            //{
            //    Console.WriteLine(false);
            //}
            ////51
            ////123%100=23
            ////123%10=3
            ////(d-d%100)/100
            ////d-d%100=100
            ////((d-(d-d%100))-d%10)/10
            //Console.WriteLine();
            //Console.WriteLine(51);
            //bool t=true;
            //int d = int.Parse(Console.ReadLine());
            //if (d % 10 == (d - d % 100) / 100+ ((d - (d - d % 100)) - d % 10) / 10)
            //{
            //    Console.WriteLine(t);
            //}
            //else
            //{
            //    t= false;
            //    Console.WriteLine(t);
            //}
            ////52
            //Console.WriteLine();
            //Console.WriteLine(52);
            //if(d%10== (d - d % 100) / 100 || 
            //    (d - d % 100) / 100== ((d - (d - d % 100)) - d % 10) / 10 || 
            //    d%10== ((d - (d - d % 100)) - d % 10) / 10)
            //{
            //    Console.WriteLine(t);
            //}
            //else
            //{
            //    t = false;
            //    Console.WriteLine(t);
            //}
            ////53
            //Console.WriteLine();
            //Console.WriteLine(53);
            //int k = int.Parse(Console.ReadLine());
            //double e;
            //if (d > k)
            //{
            //    e = (double)d / d % 10 + (d - d % 100) / 100 + ((d - (d - d % 100)) - d % 10) / 10; ;
            //    Console.WriteLine(e);
            //}
            //else
            //{
            //  e = (double)(d % 10 + (d - d % 100) / 100 + ((d - (d - d % 100)) - d % 10) / 10)/d;
            //    Console.WriteLine(e);
            //}
            ////54
            //Console.WriteLine();
            //Console.WriteLine(54);
            //int d1 = d % 10;
            //int d2 = ((d - (d - d % 100)) - d % 10) / 10;
            //int d3 = (d-(d%100))/100;
            //if ( d1> d2 && d1 > d3)
            //{
            //    Console.WriteLine(d1);
            //}
            //else if (d2 > d1 && d2 > d3)
            //{
            //    Console.WriteLine(d2);
            //}
            //else
            //{
            //    Console.WriteLine(d3);
            //}
            ////55
            //Console.WriteLine();
            //Console.WriteLine(55);
            //if (d1 < d2 && d1 < d3)
            //{
            //    Console.WriteLine(d1);
            //}
            //else if (d2 < d1 && d2< d3)
            //{
            //    Console.WriteLine(d2);
            //}
            //else
            //{
            //    Console.WriteLine(d3);
            //}
            ////56
            //Console.WriteLine();
            //Console.WriteLine(56);
            //if (d1 > d2)
            //{
            //    e = (double)(d1+d2+d3)/d;
            //    Console.WriteLine(e);
            //}
            //else
            //{
            //    Console.WriteLine(d);
            //}
            ////57
            //Console.WriteLine();
            //Console.WriteLine(57);
            //if (d > 300)
            //{
            //    Console.WriteLine((double)d2/d1);
            //}
            //else
            //{
            //    Console.WriteLine((double)d3/d1);
            //}
            ////58
            //Console.WriteLine();
            //Console.WriteLine(58);
            //char f = 'a';
            //if (d1 + d2 + d3 < 5)
            //{
            //    Console.WriteLine(f);
            //}
            //else
            //{
            //    f = 'b';
            //    Console.WriteLine(f);
            //}
            ////59
            //Console.WriteLine();
            //Console.WriteLine(59);
            //if (d1 > d2 && d1 > d3)
            //{
            //    Console.WriteLine(d1);
            //    if (d2 > d3)
            //    {
            //        Console.WriteLine(d2);
            //        Console.WriteLine(d3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(d3);
            //        Console.WriteLine(d2);
            //    }
            //}
            //else if (d2 > d1 && d2 > d3)
            //{
            //    Console.WriteLine(d2);
            //    if (d1 > d3)
            //    {
            //        Console.WriteLine(d1);
            //        Console.WriteLine(d3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(d3);
            //        Console.WriteLine(d1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(d3);
            //    if (d1 > d2)
            //    {
            //        Console.WriteLine(d1);
            //        Console.WriteLine(d2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(d2);
            //        Console.WriteLine(d1);
            //    }
            //}
            ////60
            //Console.WriteLine();
            //Console.WriteLine(60);
            //if (a > b && a > c)
            //{
            //    Console.WriteLine(a);
            //    if (b > c)
            //    {
            //        Console.WriteLine(b);
            //        Console.WriteLine(c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c);
            //        Console.WriteLine(b);
            //    }
            //}
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine(b);
            //    if (a > c)
            //    {
            //        Console.WriteLine(a);
            //        Console.WriteLine(c);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c);
            //        Console.WriteLine(a);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //    if (a > b)
            //    {
            //        Console.WriteLine(a);
            //        Console.WriteLine(b);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b);
            //        Console.WriteLine(a);
            //    }
            //}
            //if (d1 < d2 && d1 < d3)
            //{
            //    Console.WriteLine(d1);
            //    if (d2 < d3)
            //    {
            //        Console.WriteLine(d2);
            //        Console.WriteLine(d3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(d3);
            //        Console.WriteLine(d2);
            //    }
            //}
            //else if (d2 < d1 && d2 < d3)
            //{
            //    Console.WriteLine(d2);
            //    if (d1 < d3)
            //    {
            //        Console.WriteLine(d1);
            //        Console.WriteLine(d3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(d3);
            //        Console.WriteLine(d1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(d3);
            //    if (d1 < d2)
            //    {
            //        Console.WriteLine(d1);
            //        Console.WriteLine(d2);
            //    }
            //    else
            //    {
            //        Console.WriteLine(d2);
            //        Console.WriteLine(d1);
            //    }
            //}
            //61
            //(d-(d%100))/100
            /*Console.WriteLine();
            Console.WriteLine(61);
            int q = int.Parse(Console.ReadLine());
            int q1 = q % 10;
            int q2 = ((q - (q - q % 100)) - q % 10) / 10;
            int q3_5 = q - (q - (q % 1000));
            int q3 = (q3_5 - (q3_5 % 100)) / 100;
            int q4 = (q-(q % 1000))/1000;
            if (q1 + q1 == q3 + q4){
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            //62
            Console.WriteLine();
            Console.WriteLine(62);
            if (q < 5000)
            {
                Console.WriteLine((double)q/(q1+q3));
            }
            else
            {
                Console.WriteLine((double)q/(q2+q4));
            }
            //63
            Console.WriteLine();
            Console.WriteLine(63);
            if(q1==1 || q2 == 1 || q3==1 || q4==1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }
            //64
            Console.WriteLine();
            Console.WriteLine(64);
            if (q1 + q2 == 5)
            {
                Console.WriteLine('s');
            }
            else
            {
                Console.WriteLine('d');
            }
            //65
            Console.WriteLine();
            Console.WriteLine(65);
            if (q1 * q2 == 12)
            {
                Console.WriteLine("y=12");
            }
            else
            {
                Console.WriteLine("y=0");
            }
            //66
            Console.WriteLine();
            Console.WriteLine(66);
            if(q1==4 && q4 == 4)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //67
            Console.WriteLine();
            Console.WriteLine(67);
            if(q==Math.Pow(q1,2)+ Math.Pow(q2, 2) + Math.Pow(q3, 2) + Math.Pow(q4, 2))
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            //68
            Console.WriteLine();
            Console.WriteLine(68);
            if (q1 > q2)
            {
                Console.WriteLine(q1*q3);
            }
            else
            {
                Console.WriteLine(1);
            }
            //69
            Console.WriteLine();
            Console.WriteLine(69);
            if (q1 + q2 + q3 + q4 > 20) 
            {
                Console.WriteLine(1);            
            }
            else
            {
                Console.WriteLine(0);
            }
            //70
            Console.WriteLine();
            Console.WriteLine(70);
            if (q1 * q2 * q3 * q4 > 200)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(0);
            }*/
            //151
            //Console.WriteLine();
            //Console.WriteLine(151);
            //int x = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            //double sum = 0;
            //double mult = 1;
            //int fact = 1;
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= i;
            //    sum += ((Math.Pow(Math.Log10(3), i))/fact)*x;
            //}
            //Console.WriteLine(sum);
            ////152
            //Console.WriteLine();
            //Console.WriteLine(152);
            //for (int i = 1; i <n; i++)
            //{
            //    fact *= 2*i;
            //    sum += Math.Pow(x, 2 * i) / fact;
            //}
            //Console.WriteLine(sum);
            ////153
            //Console.WriteLine();
            //Console.WriteLine(153);
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= 2*i+1;
            //    sum += Math.Pow(x, 2 * i + 1)/fact;
            //}
            //Console.WriteLine(sum);
            ////154
            //Console.WriteLine();
            //Console.WriteLine(154);
            //double fact1 = 1;
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= 2 * i;
            //    fact1 *= i ^ 2;
            //    sum += (fact+Math.Abs(x))/ fact1;
            //}
            //Console.WriteLine(sum);
            ////155
            //Console.WriteLine();
            //Console.WriteLine(155);
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= i;
            //    sum += Math.Pow(i,i)*(Math.Pow(x, 2*i) / fact;
            //}
            //Console.WriteLine(sum);
            ////156
            //Console.WriteLine();
            //Console.WriteLine(156);
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= i;
            //    sum += Math.Pow(-1,i)*Math.Pow(x,i) / fact;
            //}
            //Console.WriteLine(sum);
            ////157
            //Console.WriteLine();
            //Console.WriteLine(153);
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= i;
            //    mult *= Math.Pow(-1,i)/(Math.Pow(2*x+1,i)* fact);
            //}
            //Console.WriteLine(mult);
            ////158
            //Console.WriteLine();
            //Console.WriteLine(158);
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= i;
            //    sum += (1 / fact) + (Math.Sin(i + x) / Math.Pow(x, i));
            //}
            //Console.WriteLine(sum);
            ////159
            //Console.WriteLine();
            //Console.WriteLine(159);
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= i;
            //    mult += (fact/(i+1))-Math.Pow(Math.Cos(Math.Abs(x)),i);
            //}
            //Console.WriteLine(mult);
            ////160
            //Console.WriteLine();
            //Console.WriteLine(160);
            //for (int i = 1; i < n; i++)
            //{
            //    fact *= i;
            //    mult += (x+Math.Cos(i*x))/Math.Pow(2,i)*fact;
            //}
            //Console.WriteLine(mult);
            //161
            Console.WriteLine();
            Console.WriteLine(161);
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int mult1 = 1;
            for (int i = 1; i < n1; i++)
            {
                if (i % n2 == 0)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine(sum1);
            //162
            Console.WriteLine();
            Console.WriteLine(162);
            for (int i = 1; i < n1; i++)
            {
                if (i % n2 == 0)
                {
                    mult1 *= i;
                }
            }
            Console.WriteLine(mult1);
            //163
            Console.WriteLine();
            Console.WriteLine(163);
            for (int i = 1; i < n1; i++)
            {
                if (i % n2 == 2)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine(sum1);
            //164
            Console.WriteLine();
            Console.WriteLine(164);
            for (int i = 1; i < n1; i++)
            {
                if (i % n2 == 3)
                {
                    mult1 *= i;
                }
            }
            Console.WriteLine(mult1);
            //165
            Console.WriteLine();
            Console.WriteLine(165);
            for (int i = 100; i < 99; i++)
            {
                if (i % 3 == 0)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine(sum1);
            //166
            Console.WriteLine();
            Console.WriteLine(166);
            for (int i = 100; i < n1; i++)
            {
                if (i % n2 == 0)
                {
                    mult1 *= i;
                }
            }
            Console.WriteLine(mult1);
            //167
            Console.WriteLine();
            Console.WriteLine(167);
            for (int i = 100; i < 99; i++)
            {
                if (i % 3 == 0 && i%5==0)
                {
                    mult1 *= i;
                }
            }
            Console.WriteLine(mult1);
            //168
            Console.WriteLine();
            Console.WriteLine(168);
            for (int i = 100; i < 999; i++)
            {
                if (i % 5 != 0)
                {
                    sum1 += i;
                }
            }
            Console.WriteLine(sum1);
            //169
            Console.WriteLine();
            Console.WriteLine(169);
            for (int i = 1000; i < 999; i++)
            {
                if (i % 2 != 0 && i%3!=0)
                {
                    mult1 *= i;
                }
            }
            Console.WriteLine(mult1);
            //170
            Console.WriteLine();
            Console.WriteLine(170);
            for (int i = 1000; i < 9999; i++)
            {
                if (i % 3 == 1 && i%4==2)
                {
                    mult1 *= i;
                }
            }
            Console.WriteLine(mult1);
            //171
            Console.WriteLine();
            Console.WriteLine(171);
            for (int i = 100; i < 999; i++)
            {
                if (Math.Sqrt(16*i)%1==0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            //172
            Console.WriteLine();
            Console.WriteLine(172);
            for (int i = 1000; i < 9999; i++)
            {
                if (Math.Sqrt(26 * i) % 1 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            //173
            int keep =0;
            Console.WriteLine();
            Console.WriteLine(173);
            for (int i = 1000; i < 9999; i++)
            {
                if (Math.Sqrt(14 * i) % 1 == 0)
                {
                    keep = i;
                }
            }
            Console.WriteLine(keep);
            //174
            Console.WriteLine();
            Console.WriteLine(171);
            for (int i = 100; i < 999; i++)
            {
                if (Math.Sqrt(18 * i) % 1 == 0)
                {
                    keep = i;
                }
            }
            Console.WriteLine(keep);
            //175







            //176
            Console.WriteLine();
            Console.WriteLine(176);
            if (Math.Log(n2, 3) % 1 == 0)
                {
                    Console.WriteLine(true);
                }
            else
            {
                Console.WriteLine(false);
            }
            //177
            Console.WriteLine();
            Console.WriteLine(176);
            if (Math.Log(n2, 4) % 1 != 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }
        }
    }
}