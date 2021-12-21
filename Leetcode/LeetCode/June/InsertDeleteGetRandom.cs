using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.June
{
    //With Hash
    public class RandomizedSet3
    {
        Dictionary<int, int> dict;
        HashSet<int> hset;
        Random rand;
        /** Initialize your data structure here. */
        public RandomizedSet3()
        {
            hset = new HashSet<int>();
            rand = new Random();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (!hset.Contains(val))
            {
                hset.Add(val);
                return true;
            }
            return false;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (hset.Contains(val))
            {
                hset.Remove(val);
                return true;
            }
            return false;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            return 0;//ToDo
        }
    }

    //With List & Dictionary
    public class RandomizedSet
    {
        Dictionary<int, int> dict;
        List<int> list;
        Random rand;
        /** Initialize your data structure here. */
        public RandomizedSet()
        {
            dict = new Dictionary<int, int>();
            list = new List<int>();
            rand = new Random();
        }

        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (!dict.ContainsKey(val))
            {
                dict.Add(val, list.Count);
                list.Add(val);
                return true;
            }
            return false;
        }

        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val)
        {
            if (dict.ContainsKey(val))
            {
                var last = list[list.Count - 1];
                list[dict[val]] = last;
                list.RemoveAt(list.Count - 1);
                dict[last] = dict[val];
                dict.Remove(val);
                return true;
            }
            return false;
        }

        /** Get a random element from the set. */
        public int GetRandom()
        {
            return list[rand.Next(0, list.Count)];
        }
    }

    public class InsertDeleteGetRandom
	{
        public void Test()
        {
            var val = 10;
            RandomizedSet obj = new RandomizedSet();
            bool param_1 = obj.Insert(val);
            bool param_4 = obj.Insert(20);
            bool param_2 = obj.Remove(val);
            int param_3 = obj.GetRandom();
        }
	}
}
