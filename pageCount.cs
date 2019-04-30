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
        static int pageCount(int n, int p)
        {
            /*
             * Write your code here.
             */
            int numberofPagesTurned = 0;
            bool lastPageSingle = false;
            if(n%2==0)
            {
                lastPageSingle = true;
            }
            if(lastPageSingle==true)
            {
                int answer = 0;
                
                if (p == 1)
                {
                    answer = 0;
                }
                else
                {
                    int p1 = 2;
                    int p2 = 3;
                    answer = 1;
                    while(p!=p1 && p!=p2)
                    {
                        answer = answer + 1;
                        p1 = p1 + 2;
                        p2 = p2 + 2;
                    }
                }

                int answer2 = 0;
                if(p==n)
                {
                    answer2 = 0;
                }
                else
                {
                    int p1_r = n - 1;
                    int p2_r = n - 2;
                    answer2 = 1;
                    //int currPage = n;
                    while(p!=p1_r && p != p2_r)
                    {
                        answer2 = answer2 + 1;
                        p1_r = p1_r - 2;
                        p2_r = p2_r - 2;
                        

                    }

                }

                if (answer > answer2)
                {
                    numberofPagesTurned = answer2;
                }
                else
                {
                    numberofPagesTurned = answer;
                }
            }
            else
            {
                int answer = 0;
                if(p==1)
                {
                    return answer;
                }
                else
                {
                    int p1 = 2;
                    int p2 = 3;
                    answer = 1;
                    while (p != p1 && p != p2)
                    {
                        answer = answer + 1;
                        p1 = p1 + 2;
                        p2 = p2 + 2;
                    }
                }

                int answer2 = 0;
                if (p == n)
                {
                    return answer2;
                }
                else
                {
                    int p1_r = n;
                    int p2_r = n - 1;
                    
                    //int currPage = n;
                    while (p != p1_r && p != p2_r)
                    {
                        answer2 = answer2 + 1;
                        p1_r = p1_r - 2;
                        p2_r = p2_r - 2;


                    }

                }

                if (answer > answer2)
                {
                    numberofPagesTurned = answer2;
                }
                else
                {
                    numberofPagesTurned = answer;
                }




            }

            return numberofPagesTurned;
        }

        static void Main(string[] args)
        {
            int t1 = pageCount(5, 4);
            Console.WriteLine(t1);

        }
    }
}
