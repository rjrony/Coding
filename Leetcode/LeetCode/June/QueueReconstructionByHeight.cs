using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.June
{
	public class QueueReconstructionByHeight
	{
        //short
        public int[][] ReconstructQueue(int[][] people)
        {
            List<int[]> res = new List<int[]>();

            var sortedPeople = people.ToList().OrderByDescending(x => x[0]).ThenBy(x => x[1]);
            foreach (var p in sortedPeople)
                res.Insert(p[1], p);

            return res.ToArray();
        }

        //details explanation
        //Input: [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
        //Output: [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]
        public int[][] ReconstructQueue2(int[][] people)
        {
            var n = people.Length;

            var result = new List<int[]>();

            // Sort [[7,0], [4,4], [7,1], [5,0], [6,1], [5,2]]
            // To   [[7,0], [7,1], [6,1], [5,0], [5,2], [4,4]]
            Array.Sort(people, (a, b) => a[0] != b[0] ? b[0] - a[0] : a[1] - b[1]);

            foreach (var person in people)
            {
                //var height = person[0];
                var index = person[1];

                result.Insert(index, person);
            }
            //result:
            //[7,0] => [[7,0]]
            //[7,1] => [[7,0], [7,1]]
            //[6,1] => [[7,0], [6,1], [7,1]]
            //[5,0] => [[5,0], [7,0], [6,1], [7,1]]
            //[5,2] => [[5,0], [7,0], [5,2], [6,1], [7,1]]
            //[4,4] => [[5,0], [7,0], [5,2], [6,1], [4,4], [7,1]]

            return result.ToArray();
        }
    }
}
