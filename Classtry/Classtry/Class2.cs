using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Classtry
{
    public enum Errors
    {
        SymbolError,
        NumberError,
    }
    class MyException : ApplicationException
    {   
        public void NumberException()
        {
            Console.WriteLine($"You have {((Errors)1)}");
        }
        public void SymbolException()
        {
            Console.WriteLine($"You have {((Errors)0)}");
        }
    }
    public class Humen 
    {
        public bool tr1 = true;
        public bool tr2 = true;
        public string s=" ";
        public void Validation(string name)
        {
            try
            {
                string symbols = "~!@#$%^&*()_+-=/,.?';:'";
                string number = "0123456789";
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < symbols.Length; j++)
                    { 
                        if (name[i] == symbols[j])
                        {
                            tr1 = false;
                            s = "";
                            s = "symbol";
                            throw new MyException();
                        }
                    }
                }
                for (int i = 0; i < name.Length; i++)
                {
                    for (int j = 0; j < number.Length; j++)
                    {
                        if (name[i] == number[j])
                        {
                            tr2 = false;
                            s = " ";
                            s = "number";
                            throw new MyException();
                        }
                    }
                }
            }
            catch(MyException e)
            {
                while (true)
                {
                    if (s == "symbol")
                    {
                        e.SymbolException();
                        break;
                    }
                    else if (s == "number")
                    {
                        e.NumberException();
                        break;
                    }
                }
            }
        }
        public void CheckMaxCount(string s)
        {
            int count = 0;
            int maxcount = 0;
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                    }
                    if (maxcount < count)
                    {
                        maxcount = count;
                        index = i;
                    }
                }
                count = 0;
            }
            Console.WriteLine($"Maxcount = {maxcount};\n" +
                              $"Letter = {s[index]};");
        }

    }
    
}
