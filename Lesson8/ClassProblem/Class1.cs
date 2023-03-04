using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProblem
{
    class Milk
    {
        public string MakeSmetan(int qanak,int qopox,string s)
        {
            const int smetan = 500;
            if (qopox < smetan * qanak)
            {
                return $"dzer gumaty bavakan che dzer harmakvor e {smetan * qanak - qopox}";
            }
            else
            {
                Console.WriteLine($"duq uzum eq gnel {qanak} hat smentan dra ginn e {smetan * qanak}");
                if (s == "ayo")
                {
                    return $"dzer zdachin {qopox-smetan*qanak}";
                }
                else
                {
                    return "ctesutyun";
                }
            }
        }
        public string MakeMatzoon(int qanak,int qopox,string s)
        {
            const int matzoon = 300;
            if (qopox < matzoon * qanak)
            {
                return $"dzer gumaty bavakan che dzer harmakvor e {matzoon * qanak - qopox}";
            }
            else
            {
                Console.WriteLine($"duq uzum eq gnel {qanak} hat smentan dra ginn e {matzoon * qanak}");
                if (s == "ayo")
                {
                    return $"dzer zdachin {qopox - matzoon * qanak}";
                }
                else
                {
                    return "ctesutyun";
                }
            }
        }
        public string MakeTvarog(int qanak,int qopox,string s)
        {
            const int tvarog = 250;
            if (qopox < tvarog * qanak)
            {
                return $"dzer gumaty bavakan che dzer harmakvor e {tvarog * qanak - qopox}";
            }
            else
            {
                Console.WriteLine($"duq uzum eq gnel {qanak} hat smentan dra ginn e {tvarog * qanak}");
                if (s == "ayo")
                {
                    return $"dzer zdachin {qopox - tvarog * qanak}";
                }
                else
                {
                    return "ctesutyun";
                }
            }
        }
    }



    internal class Class1
    {
    }
}
