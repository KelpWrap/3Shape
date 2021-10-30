using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
namespace myapp
{
    class WordCount
    {
        public void Count(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("No file found at this path");
                return;
            }
            else
            {
                String readText = File.ReadAllText(path);
                string stripped = StripPunctuation(readText);
                var wordMap = new Dictionary<string, int>();
                foreach (string word in stripped.Split(' '))
                {
                    if (!wordMap.ContainsKey(word))
                    {
                        wordMap[word] = 1;
                    }
                    else
                    {
                        wordMap[word] = wordMap[word] + 1;
                    }
                }
                foreach (var wordCountPair in wordMap)
                {
                    Console.WriteLine(String.Format("{0}: {1}", wordCountPair.Key, wordCountPair.Value));
                }
            }
        }
        private string StripPunctuation(string s)
        {
            var sb = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }
    }
}