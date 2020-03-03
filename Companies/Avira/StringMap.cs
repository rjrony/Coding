using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avira
{
    public class StringMap<TValue> : IStringMap<TValue>
        where TValue : class, new()
    {
        private Dictionary<string, TValue> myDictionary;
        public StringMap()
        {
            myDictionary = new Dictionary<string, TValue>();
        }
        /// <summary> Returns number of elements in a map</summary>
        public int Count => myDictionary.Count;

        /// <summary>
        /// If <c>GetValue</c> method is called but a given key is not in a map then <c>DefaultValue</c> is returned.
        /// </summary>
        public TValue DefaultValue
        {
            get => new TValue();
            set => new TValue();
        }

        /// <summary>
        /// Adds a given key and value to a map.
        /// If the given key already exists in a map, then the value associated with this key should be overriden.
        /// </summary>
        /// <returns>true if the value for the key was overriden otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        /// <exception cref="System.ArgumentNullException">If the value is null</exception>
        public bool AddElement(string key, TValue value)
        {
            if (string.IsNullOrEmpty(key))
            {
                return false;
            }
            myDictionary.Add(key, value);
            return true;
        }

        /// <summary>
        /// Removes a given key and associated value from a map.
        /// </summary>
        /// <returns>true if the key was in the map and was removed otherwise false</returns>
        /// <exception cref="System.ArgumentNullException">If the key is null</exception>
        /// <exception cref="System.ArgumentException">If the key is an empty string</exception>
        public bool RemoveElement(string key)
        {
            return myDictionary.Remove(key);
        }

        /// <summary>
        /// Returns the value associated with a given key.
        /// </summary>
        /// <returns>The value associated with a given key or <c>DefaultValue</c> if the key does not exist in a map</returns>
        /// <exception cref="System.ArgumentNullException">If a key is null</exception>
        /// <exception cref="System.ArgumentException">If a key is an empty string</exception>
        public TValue GetValue(string key)
        {
            TValue value;
            if (myDictionary.TryGetValue(key, out value))
            {
                return value;
            }

            return DefaultValue;
        }
    }

    public interface IStringMap<T>
    {
    }
}
