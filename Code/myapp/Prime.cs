using System;
using System.Collections.Generic;

namespace myapp
{
    class Prime
    {
        public int Calculate(int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            var primeNumbers = new List<int>();
            int counter = 1;
            Boolean isPrime = true;
            while (primeNumbers.Count < n)
            {
                isPrime = true;
                counter = counter +1;
                foreach (int prime in primeNumbers)
                {
                    if (counter % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primeNumbers.Add(counter);
                }
            }
            return (primeNumbers[primeNumbers.Count - 1]);
        }
    }
}