using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace myapp
{
    class ThreeShapeTest{
        public int Fibonacci(int n){
            if (n<=1){
                return n;
            } else {
                return Fibonacci(n-1) + Fibonacci(n-2);
                }
        }

        public int Prime(int n){
            if (n < 1){
                return 0;
            }
            var primeNumbers = new List<int>();
            int counter = 1;
            Boolean isPrime = true;
            while (primeNumbers.Count < n){
                isPrime = true;
                counter++;
                foreach (int prime in primeNumbers){
                    if (counter%prime == 0){
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime){
                    primeNumbers.Add(counter);
                }
            }
            return (primeNumbers[primeNumbers.Count-1]);
        }

        public void WordCount(string s){
            string stripped = StripPunctuation(s);
            var wordMap = new Dictionary<string,int>();
            foreach (string word in stripped.Split(' ')){
                if (!wordMap.ContainsKey(word)){
                    wordMap[word] = 1;
                } else {
                    wordMap[word] = wordMap[word] + 1;
                }
            }
            foreach (var wordCountPair in wordMap){
                Console.WriteLine(String.Format("{0}: {1}", wordCountPair.Key, wordCountPair.Value));
            }
        }


        public int SocialDistance(string s, int k){
            int pos = 0;
            int changes = 0;
            while (pos < s.Length){
                if (s[pos] == '1'){
                    pos +=  k + 1;
                } else if (getSumOfNeighbours(pos, s, k) < 1){
                    changes++;
                    pos +=  k + 1;
                } else {
                    pos++;
                }
            }
            return changes;
        }

        static void Main(string[] args)
        {
            ThreeShapeTest threeShapeTest = new ThreeShapeTest();
            //Console.WriteLine(threeShapeTest.Fibonacci(20));
            //threeShapeTest.WordCount("I do love this dog, do I not?");
            Console.WriteLine(threeShapeTest.SocialDistance("10000100", 2));
        }

        private string StripPunctuation(string s){
            var sb = new StringBuilder();
            foreach (char c in s){
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }

        private int getSumOfNeighbours(int pos, string s, int k)
        {
            int start = pos - k;
            int end = pos + k; 
            if(start < 0) {
                start = 0;
            }
            if(end > s.Length-1){
                end = s.Length-1;
            }
            int stringLength = end-start+1;
            return s.Substring(start, stringLength).Count(x => (x.Equals('1')));
        }
    }
}
