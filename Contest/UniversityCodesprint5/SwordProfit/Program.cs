using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordProfit
{
    class Program
    {
        // Complete the solve function below.
        static int solve(List<List<long>> swordShops)
        {
            long finalSum = 0;
            
            int length = swordShops.Count;
            for (int i = 0; i < length; i++)
            {
                long sum = 0;
                long q = swordShops[i][0];
                long a = swordShops[i][1];
                long b = swordShops[i][2];
                //long r = swordShops[i][3];
                long d = swordShops[i][4];
                for (int j = i; j < length; j++)
                {
                    //long q2 = swordShops[j][0];
                    //long a2 = swordShops[j][1];
                    //long b2 = swordShops[j][2];
                    long r2 = swordShops[j][3];
                    //long d2 = swordShops[j][4];
                    long maxBenefit = 0;
                    
                    long nowQ = q - (j - i) * d;
                    long benefit = 0;
                    long salePrice = 0;
                    if (nowQ > r2)
                    {
                        salePrice = nowQ - r2;
                    }
                    else
                    {
                        continue;
                    }

                    long k = 0;
                    while (true)
                    {
                        ++k;                      
                        long cost = a * k + b * (k) * (k + 1) / 2;
                        benefit = k*salePrice - cost;
                        if (benefit > maxBenefit)
                        {
                            maxBenefit = benefit;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (maxBenefit > sum)
                    {
                        sum = maxBenefit;
                    }
                }
                //Console.WriteLine(i+1 + ": " + sum);
                finalSum += sum;
                finalSum %= 1000000007;
            }

            return (int)finalSum;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<long>> swords = new List<List<long>>();

            for (int i = 0; i < n; i++)
            {
                swords.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(swordsTemp => Convert.ToInt64(swordsTemp)).ToList());
            }

            int result = solve(swords);
            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
