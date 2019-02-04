using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerDotNet.Problems
{
    public class Problems1_10
    {
        /// <summary>
        /// Multiples of 3 and 5
        /// </summary>
        /// <param name="limit">The set max integer limit</param>
        /// <returns>The sum of all natural numbers that are the multiples of 3 or 5 to the limit</returns>
        public int Problem1 (int limit)
        {
            List<int> mults = new List<int>();
            int answer = 0;
            for(int i = 0; i < limit; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    answer += i;
                }
            }
            return answer;
        }
        /// <summary>
        /// Even Fibonacci numbers
        /// </summary>
        /// <param name="limit">Maximum fibonacci number to evaluate</param>
        /// <returns>The sum of even valued fibonacci numbers</returns>
        public long Problem2(long limit)
        {
            long answer = 0;
            int i = 1;
            while(true)
            {
                long fib = Fibonacci(i);
                if (fib > limit)
                    break;
                if (fib % 2 == 0)
                    answer += fib;
                i++;
            }
            return answer;
        }
        /// <summary>
        /// Largest prime factor
        /// </summary>
        /// <param name="num">Number to evaluate</param>
        /// <returns>The largest prime factor of the provided number</returns>
        public long Problem3(long num)
        {
            List<long> primes = new List<long>();
            if(num % 2 == 0)
            {
                primes.Add(2);
                num /= 2;
            }
            for(long i = 3; i*i <= num; i = i + 2)
            {
                while(num % i == 0)
                {
                    primes.Add(i);
                    num /= i;
                }
            }
            if(num > 2)
            {
                primes.Add(num);
            }
            return primes[primes.Count - 1];
        }
        /// <summary>
        /// Recursive Fibonacci sequence
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private long Fibonacci(long num)
        {
            if ((num == 0) || (num == 1))
            {
                return num;
            }
            return Fibonacci(num - 1) + Fibonacci(num - 2);
        }
    }
}
