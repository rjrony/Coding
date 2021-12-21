using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.May
{
    public class Trie
    {
        static readonly int ALPHABET_SIZE = 26;
        //trie node
        class TrieNode
        {
            public TrieNode[] Children = new TrieNode[ALPHABET_SIZE];
            public bool IsEndOfWord;

            public TrieNode()
            {
                IsEndOfWord = false;
                //for (int i = 0; i < ALPHABET_SIZE; i++)
                //    Children[i] = null;
            }
        }


        /** Initialize your data structure here. */
        private TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode pCrawl = root;
            for (int i = 0; i < word.Length; i++)
            {
                var index = word[i] - 'a';
                if (pCrawl.Children[index]==null)
                {
                    pCrawl.Children[index] = new TrieNode();
                }
                pCrawl = pCrawl.Children[index];
            }
            pCrawl.IsEndOfWord = true;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode pCrawl = root;
            for (int i = 0; i < word.Length; i++)
            {
                var index = word[i] - 'a';
                if (pCrawl.Children[index] == null)
                {
                    return false;
                }
                pCrawl = pCrawl.Children[index];
            }
            return pCrawl!=null && pCrawl.IsEndOfWord;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode pCrawl = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                var index = prefix[i] - 'a';
                if (pCrawl.Children[index] == null)
                {
                    return false;
                }
                pCrawl = pCrawl.Children[index];
            }
            return pCrawl != null;
        }
    }
    
    public class ImplementTrie_PrefixTree
	{
        public void Test()
        {
            var word = "apple";
            Trie obj = new Trie();
            obj.Insert(word);
            obj.Insert("book");
            bool param_2 = obj.Search(word);
            bool param_3 = obj.StartsWith("app");
        }
	}
}
