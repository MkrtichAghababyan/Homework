using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = "foo(bar)oof";
            /*
            List<int> index = new List<int>();
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == '(')
                {
                    index.Add(i);
                    for (int j = i; j < inputString.Length; j++)
                    {
                        if (inputString[j] == ')')
                        {
                            index.Add(j);
                            break;
                        }
                    }
                }
            }
           /* string s = Console.ReadLine();
            for (int i = 0; i < index.Count-1; i++)
            {
                if (index[i] == '(')
                {
                    int end = index[i+1];
                    char c = ' ';
                    for (int j = index[i]; j < end; j++,end--)
                    {
                        if (inputString[j] == '(' || inputString[j] == ')')
                        {
                            continue;
                        }
                        else
                        {
                            c = inputString[j];
                            inputString[j] = inputString[end];
                        }
                    }
                }
            }*/
            Console.ReadKey();
        }
    }
}
