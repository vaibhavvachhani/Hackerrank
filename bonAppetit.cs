using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        // Complete the bonAppetit function below.
        static void bonAppetit(List<int> bill, int k, int b)
        {
            int actualCost = 0;
            for (int i = 0; i < bill.Count(); i++)
            {
                if(i!=k)
                {
                    actualCost = bill[i] + actualCost;
                }
                
            }
            int billPerPerson = actualCost / 2;
            if (b == billPerPerson)
            {
                Console.WriteLine("Bon Appetit");
            }
            else
            {
                Console.WriteLine(Math.Abs(b - billPerPerson).ToString());
            }

        }

        static void Main(string[] args)
        {
            
        }
    }
}
