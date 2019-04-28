using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string dayOfProgrammer(int year)
        {
            //if 
            if (year == 1918)
            {
                return ("26.09.1918");
            }
            else if ( year < 1918)
            {
                if (year % 4 == 0)
                {
                    return ("12.09." + year.ToString());
                }
                else
                {
                    return ("13.09." + year.ToString());
                }
            }
            else
            {
                if(year%400==0 ||  (year % 4 == 0 && year % 100 != 0))
                {
                   
                    {
                        return ("12.09." + year.ToString());
                    }
                }
                else
                {
                    return ("13.09." + year.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            string y1 = dayOfProgrammer(2016);
            Console.WriteLine(y1);
        }
    }
}
