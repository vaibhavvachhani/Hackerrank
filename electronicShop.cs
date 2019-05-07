using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */
            int answer = -1;
            int keyMax = keyboards.Max();
            int driveMax = drives.Max();
            int keyMin = keyboards.Min();
            int driveMin = drives.Min();
            List<int> money = new List<int>();
            if (b <= keyMin || b <= driveMin)
            {
                return answer;
            }
            else
            {
                for (int i = 0; i < keyboards.GetLength(0); i++)
                {
                    for (int j = 0; j < drives.GetLength(0); j++)
                    {
                        int p1 = keyboards[i];
                        int p2 = drives[j];
                        int total = p1 + p2;
                        if (total <= b)
                        {

                            money.Add(total);
                        }
                    }
                }
                answer = money.Max();
            }
            
            return answer;
        }




        static void Main(string[] args)
        {
            int[] key = {4};
            int[] drives = {5};
            int b = 5;
            int t1 = getMoneySpent(key, drives, b);
            Console.WriteLine(t1);

        }

    }

}
