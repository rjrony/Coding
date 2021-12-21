using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.June
{
    public class RandomizedCollection
    {
        Dictionary<int, HashSet<int>> dict;
        List<int> list;
        Random rand;

        /** Initialize your data structure here. */
        public RandomizedCollection()
        {
            dict = new Dictionary<int, HashSet<int>>();
            list = new List<int>();
            rand = new Random();
        }

        /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
        public bool Insert(int val)
        {
            if (dict.ContainsKey(val))
            {
                dict[val].Add(list.Count);
                list.Add(val);
                return false;
            }
            else
            {
                dict.Add(val, new HashSet<int>() { list.Count });
                list.Add(val);
                return true;
            }   
        }

        /** Removes a value from the collection. Returns true if the collection contained the specified element. */
        public bool Remove(int val)
        {
            if (dict.ContainsKey(val))
            {
                var valFirstIndex = dict[val].First();
                if (dict[val].Count > 1)
                {
                    dict[val].Remove(valFirstIndex);
                }
                else
                {
                    dict.Remove(val);
                }

                if (valFirstIndex < (list.Count - 1))
                {
                    var last = list[list.Count - 1];
                    list[valFirstIndex] = last;
                    dict[last].Remove(list.Count - 1);
                    dict[last].Add(valFirstIndex);
                }
                list.RemoveAt(list.Count - 1);

                return true;
            }
            return false;
        }

        /** Get a random element from the collection. */
        public int GetRandom()
        {
            return list[rand.Next(list.Count)];
        }
    }

    public class InsertDeleteGetRandomO_1__DuplicatesAllowed
	{
        public void Test()
        {
            RandomizedCollection obj = new RandomizedCollection();
            //bool param_1 = obj.Insert(9);
            //param_1 = obj.Insert(9);
            //param_1 = obj.Insert(1);
            //param_1 = obj.Insert(1);
            //param_1 = obj.Insert(2);
            //param_1 = obj.Insert(1);
            //param_1 = obj.Remove(2);
            //param_1 = obj.Remove(1);

            //bool param_1 = obj.Insert(1);
            //param_1 = obj.Insert(1);
            //param_1 = obj.Insert(2);
            //int param_3 = obj.GetRandom();
            //Console.WriteLine(param_3);
            //param_1 = obj.Remove(1);
            //param_3 = obj.GetRandom();
            //Console.WriteLine(param_3);

            //bool param_1 = obj.Insert(0);
            //param_1 = obj.Insert(1);
            //param_1 = obj.Remove(0);
            //param_1 = obj.Insert(2);
            //param_1 = obj.Remove(1);
            //int param_3 = obj.GetRandom();
            //Console.WriteLine(param_3);

            bool param_1 = obj.Insert(4);
            param_1 = obj.Insert(3);
            param_1 = obj.Insert(4);
            param_1 = obj.Insert(2);
            param_1 = obj.Insert(4);

            param_1 = obj.Remove(4);
            param_1 = obj.Remove(3);
            param_1 = obj.Remove(4);
            param_1 = obj.Remove(4);
            //int param_3 = obj.GetRandom();
            //Console.WriteLine(param_3);

            //bool param_1 = obj.Insert(1);
            //param_1 = obj.Insert(1);
            //param_1 = obj.Insert(2);
            //param_1 = obj.Insert(2);
            //param_1 = obj.Insert(2);
            //param_1 = obj.Remove(1);
            //param_1 = obj.Remove(1);
            //param_1 = obj.Remove(2);
            //param_1 = obj.Insert(1);
            //param_1 = obj.Remove(2);
            //int param_3 = obj.GetRandom();           
            //param_3 = obj.GetRandom();
        }
    }
}
