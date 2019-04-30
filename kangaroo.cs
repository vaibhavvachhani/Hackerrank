using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        // Complete the kangaroo function below.
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string answer = "NO";
            if (x2 > x1 && v2 > v1)
            {
                return answer;
            }
            else
            {
                int k1 = x1;
                int k2 = x2;
                int s1 = v1;
                int s2 = v2;
                if (k1 > k2)
                {
                    do
                    {
                        k1 = k1 + s1;
                        k2 = k2 + s2;
                        if (k1 == k2)
                        {
                            return "YES";
                            //break;
                        }
                    }
                    while (k1 > k2);
                }

                else if (k2 > k1)
                {
                    do
                    {
                        k1 = k1 + s1;
                        k2 = k2 + s2;
                        if (k1 == k2)
                        {
                            return "YES";
                            //break;
                        }
                    }
                    while (k2 > k1);
                }
                else
                {
                    if (s1 == s2)
                    {
                        return "YES";
                    }
                    else
                    {
                        return answer;
                    }
                }
            }
            return answer;


        }

        static void Main(string[] args)
        {
            String t1 = kangaroo(5, 4, 3, 1);
            Console.WriteLine(t1);

        }

    }

}
