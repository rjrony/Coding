using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class LRUCache
    {
        private readonly Dictionary<int, int> cacheMap = new Dictionary<int, int>();
        private readonly LinkedList<int> lruList = new LinkedList<int>();
        private readonly int capacity;
        public LRUCache(int capacity)
        {
            this.capacity = capacity;
        }

        public int Get(int key)
        {
            int value;
            if (this.cacheMap.TryGetValue(key, out value))
            {
                this.lruList.Remove(key);
                this.lruList.AddLast(key);
                return value;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            if (this.cacheMap.ContainsKey(key))
            {
                this.lruList.Remove(key);
                this.lruList.AddLast(key);
                this.cacheMap[key] = value;
                return;
            }
            if (this.cacheMap.Count >= this.capacity) this.RemoveFirst();

            LinkedListNode<int> node = new LinkedListNode<int>(key);
            this.lruList.AddLast(node);
            this.cacheMap.Add(key, value);
        }

        private void RemoveFirst()
        {
            LinkedListNode<int> node = this.lruList.First;
            this.lruList.RemoveFirst();
            this.cacheMap.Remove(node.Value);
        }
    }

    public class LRUCacheTest
    {
        LRUCache cache = new LRUCache(2 /* capacity */ );

        public void Test()
        {
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Put(2, 1);
            Console.WriteLine(cache.Get(1));       // returns 1
            cache.Put(3, 3);    // evicts key 2
            Console.WriteLine(cache.Get(2));       // returns -1 (not found)
            cache.Put(4, 4);    // evicts key 1
            Console.WriteLine(cache.Get(1));       // returns -1 (not found)
            Console.WriteLine(cache.Get(3));       // returns 3
            Console.WriteLine(cache.Get(4));       // returns 4
        }
    }
}
