using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lesson7
{
    internal class Program
    {
        //enum
         public enum e1
        {
            error,  //0
            failed, //1
            testing,//2
            left=22,//22
            panding,//23
            generalerror = 666 //666
        }
        static public int Methd1(ref int t)
        {
            int s = t * t;
            return s;
        }
        static public int Methd2(out int t)
        {
            t = int.Parse(Console.ReadLine());
            return t*t;
        }
        static void Main(string[] args)
        {
            //enum
            /*Console.WriteLine(e1.error);
            Console.WriteLine((e1)5);
            Console.WriteLine((int)e1.error);*/
            //aysiqnn refy tanuma qo arjeqy yndex popoxum u du heto karas het stanas
            //out ov karas methodi mej haytararumner anes u iranc ogtagorces
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine(Methd1(ref t));//refov vekaluma 
            Console.WriteLine(t);//senc tenum es vor inqy poxvela 
            Console.WriteLine(Methd2(out int s));














            Console.ReadKey();
        }
    }
}
