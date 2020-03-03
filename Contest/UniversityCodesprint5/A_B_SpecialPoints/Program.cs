using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_B_SpecialPoints
{
    class Program
    {
        // Complete the solve function below.
        static int solve(int n, List<List<int>> edges, int a, int b)
        {
            int count = 0;
            if (a == b) return 0;
            int[] adjCount = new int[n+1];
            for (int i = 1; i <= n; i++)
            {
                adjCount[i] = 0;
            }

            foreach (List<int> edge in edges)
            {
                adjCount[edge[0]]++;
                adjCount[edge[1]]++;
            }

            foreach (List<int> edge in edges)
            {
                if ((adjCount[edge[0]] * a <= adjCount[edge[1]]) &&
                    (adjCount[edge[1]] <= adjCount[edge[0]] * b))
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] nmab = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nmab[0]);

            int m = Convert.ToInt32(nmab[1]);

            int a = Convert.ToInt32(nmab[2]);

            int b = Convert.ToInt32(nmab[3]);

            List<List<int>> edges = new List<List<int>>();

            for (int i = 0; i < m; i++)
            {
                edges.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(edgesTemp => Convert.ToInt32(edgesTemp)).ToList());
            }

            int result = solve(n, edges, a, b);
            Console.WriteLine(result);
            Console.ReadKey();
            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
