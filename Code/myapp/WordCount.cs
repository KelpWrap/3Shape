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
                    string wordLC = word.ToLower();
                    if (!wordMap.ContainsKey(wordLC))
                    {
                        wordMap[wordLC] = 1;
                    }
                    else
                    {
                        wordMap[wordLC] = wordMap[wordLC] + 1;
                    }
                }
                string outputPath = path.Insert(path.IndexOf(".txt"), "out");
                using (StreamWriter sw = File.CreateText(outputPath))
                {
                    foreach (var wordCountPair in wordMap)
                    {
                        sw.WriteLine(String.Format("{0}: {1}", wordCountPair.Key, wordCountPair.Value));
                    }

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