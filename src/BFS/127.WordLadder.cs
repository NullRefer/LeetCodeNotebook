using System.Collections.Generic;

namespace LeetCodeNotebook
{
    /// <summary>
    /// LeetCode #127
    /// BFS
    /// </summary>
    public class WordLadder : IExecute
    {
        public void Execute()
        {
            var beginWord = "hit";
            var endWord = "cog";
            var wordList = new List<string>() { "hot", "dog", "dog", "lot", "log", "cog" };
            var res = LadderLength(beginWord, endWord, wordList);
            PrintResult(res);
        }

        void PrintResult(int res)
        {
            System.Console.WriteLine("Leetcode #127:");
            System.Console.WriteLine(res);
        }

        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (!wordList.Contains(endWord)) return 0;

            int Len = beginWord.Length;

            var dic = new Dictionary<string, List<string>>(wordList.Count);

            foreach (var item in wordList)
            {
                for (int i = 0; i < Len; ++i)
                {

                    string ch = $"{item.Substring(0, i)}*{item.Substring(i + 1)}";

                    if (dic.ContainsKey(ch)) dic[ch].Add(item);
                    else dic.Add(ch, new List<string> { item });
                }
            }

            Queue<KeyValuePair<string, int>> queue = new Queue<KeyValuePair<string, int>>(wordList.Count);
            queue.Enqueue(new KeyValuePair<string, int>(beginWord, 1));

            while (queue.Count != 0)
            {
                var point = queue.Dequeue();
                string word = point.Key;
                int count = point.Value;

                for (int i = 0; i < Len; ++i)
                {

                    string ch = $"{word.Substring(0, i)}*{word.Substring(i + 1, Len - i - 1)}";

                    if (dic.ContainsKey(ch))
                    {
                        foreach (var item in dic[ch])
                        {
                            if (item == endWord) return ++count;
                            queue.Enqueue(new KeyValuePair<string, int>(item, count + 1));
                        }
                        dic.Remove(ch);
                    }
                }
            }

            return 0;
        }
    }
}