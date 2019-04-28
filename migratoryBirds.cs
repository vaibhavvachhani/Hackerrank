using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int migratoryBirds(List<int> arr)

        {
            arr.Sort();
            int answer = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Count(); i++)
            {
                int currentNum = arr[i];
                if (dict.ContainsKey(currentNum))
                {
                    int q = 0;
                    dict.TryGetValue(currentNum, out q);
                    dict.Remove(currentNum);
                    dict.Add(currentNum, q + 1);
                }
                else
                {
                    dict.Add(currentNum, 1);
                }

            }
            List<int> nums = new List<int>();
            List<int> quans = new List<int>();
            foreach (KeyValuePair<int, int> kvp in dict)
            {
                nums.Add(kvp.Key);
                quans.Add(kvp.Value);

            }
            int maxQuantity = quans.Max();
            answer = nums[quans.IndexOf(maxQuantity)];
            return answer;


        }

        static void Main(string[] args)
        {
            List<int> ar =  new List<int>{ 1, 2, 3, 4, 5, 4, 3 ,2 ,1, 3, 4 };
            int t1 = migratoryBirds(ar);
            Console.WriteLine(" ");
            Console.WriteLine(t1);
        }
    }
}
