using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class FirstUnique
    {
        private readonly Dictionary<int, int> map = new Dictionary<int, int>();
        private readonly LinkedList<int> uniqueList = new LinkedList<int>();
        public FirstUnique(int[] nums)
        {
            foreach (var item in nums)
            {
                Add(item);
            }
        }

        public int ShowFirstUnique()
        {
            return uniqueList.Count > 0 ? uniqueList.First.Value : -1;
        }

        public void Add(int value)
        {
            int count;
            if (map.TryGetValue(value, out count))
            {
                if (count == 1)
                {
                    uniqueList.Remove(value);
                }
                map[value] = ++count;
            }
            else
            {
                map.Add(value, 1);
                uniqueList.AddLast(value);
            }
        }
    }

    public class FirstUniqueNumber
	{
        public void Test()
        {
            FirstUnique firstUnique = new FirstUnique(new int[] { 2, 3, 5 });
            Console.WriteLine(firstUnique.ShowFirstUnique()); // return 2
            firstUnique.Add(5);            // the queue is now [2,3,5,5]
            Console.WriteLine(firstUnique.ShowFirstUnique()); // return 2
            firstUnique.Add(2);            // the queue is now [2,3,5,5,2]
            Console.WriteLine(firstUnique.ShowFirstUnique()); // return 3
            firstUnique.Add(3);            // the queue is now [2,3,5,5,2,3]
            Console.WriteLine(firstUnique.ShowFirstUnique()); // return -1
        }
	}
}
