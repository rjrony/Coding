using System;
using System.Collections.Generic;
using System.Text;

namespace Leetcode.Algo
{
    /// <summary>
    /// https://leetcode.com/problems/find-median-from-data-stream/
    /// https://leetcode.com/problems/find-median-from-data-stream/discuss/692987/C-fastest-PriorityQueue
    /// https://leetcode.com/problems/find-median-from-data-stream/discuss/998827/C-Solution-TLE-Help
    /// </summary>
	public class MedianFinder
	{
        private readonly List<int> store;

        public MedianFinder()
        {
            store = new List<int>();
        }

        public void AddNum(int num)
        {
            int index = store.BinarySearch(num);
            // If value is not found and value is less than one or more elements in array,
            // the negative number returned is the bitwise complement of the index of the first element that is larger than value.
            index = index >= 0 ? index : ~index;
            store.Insert(index, num);
        }

        public double FindMedian()
        {
            int count = store.Count;
            return count % 2 != 0 ?
                store[count / 2] :
                ((double)(store[count / 2 - 1] + store[count / 2])) / 2;
        }

        public void Test()
		{
            MedianFinder obj = new MedianFinder();
            obj.AddNum(1);
            obj.AddNum(20);
            obj.AddNum(30);
            obj.AddNum(40);
            obj.AddNum(50);
            obj.AddNum(35);
            double param_2 = obj.FindMedian();
            Console.WriteLine(param_2);
        }
    }
}
