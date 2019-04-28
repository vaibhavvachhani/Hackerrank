using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int numberOfPairs = 0;
            List<int> explored = new List<int>();
            for (int i = 0; i < ar.Count(); i++)
            {
                if (explored.Contains(ar[i]))
                {
                    
                }
                else
                {
                    explored.Add(ar[i]);

                    int numOfCurrentSocks = 1;
                    for (int j = 0; j < ar.Count(); j++)
                    {
                        if (ar[i] == ar[j] && i != j)
                        {
                            numOfCurrentSocks = numOfCurrentSocks + 1;
                        }
                    }
                    int numOfPairCurrentSocks = (int)Math.Floor(numOfCurrentSocks / 2.0);
                    numberOfPairs = numberOfPairs + numOfPairCurrentSocks;
                    numOfPairCurrentSocks = 0;

                }
                
            }

            return numberOfPairs;

        }

        static void Main(string[] args)
        {
            int[] socks = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int t1 = sockMerchant( 9, socks);
            Console.WriteLine(t1);

        }
    }
}
