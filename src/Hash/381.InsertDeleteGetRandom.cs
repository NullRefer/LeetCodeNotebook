using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #381
    /// </summary>
    public class InsertDeleteGetRandom : IExecute
    {
        public void Execute()
        {
            RandomizedCollection obj = new RandomizedCollection();
            bool param1 = obj.Insert(2);
            bool param12 = obj.Insert(2);
            bool param13 = obj.Insert(3);
            bool param14 = obj.Insert(1);
            bool param2 = obj.Remove(2);
            int param3 = obj.GetRandom();
        }

        class RandomizedCollection
        {
            public RandomizedCollection()
            {

            }

            private Dictionary<int, HashSet<int>> num2Index { get; set; }
            private List<int> collection = new List<int>();
            private Random rand = new Random();

            public bool Insert(int val)
            {
                int index = collection.Count;
                collection.Add(val);
                if (num2Index.ContainsKey(val))
                {
                    num2Index[val].Add(index);
                }
                else
                {
                    num2Index.Add(val, new HashSet<int>() { index });
                }
                return true;
            }

            public bool Remove(int val)
            {
                if (!num2Index.ContainsKey(val))
                {
                    return false;
                }

                var indices = num2Index[val];
                var index = indices.First();
                if (indices.Count == 1)
                {
                    num2Index.Remove(val);
                }
                else
                {
                    indices.Remove(index);
                }
                int lastIndex = collection.Count - 1;
                if (index != lastIndex)
                {
                    int lastVal = collection[lastIndex];
                    num2Index[lastVal].Remove(lastIndex);
                    num2Index[lastVal].Add(index);
                    collection[index] = lastVal;
                }
                collection.RemoveAt(lastIndex);
                return true;
            }

            public int GetRandom()
            {
                return collection[rand.Next(collection.Count)];
            }
        }
    }
}