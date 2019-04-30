using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        
        

        static void Main(string[] args)
        {
           int numTestCases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numTestCases; i++)
            {
                string s = Convert.ToString(Console.ReadLine());
                s.ToCharArray();
                string s_even = "";
                string s_odd = "";
                for (int j = 0; j < s.Count(); j++)
                {
                    if(j%2==0 || j==0)
                    {
                        s_even = s_even + s[j];
                    }
                    else
                    {
                        s_odd = s_odd + s[j];
                    }
                }
                Console.WriteLine(s_even + " " + s_odd);
            }

        }

    }

}
