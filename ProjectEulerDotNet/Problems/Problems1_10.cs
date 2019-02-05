using System;
using System.Collections.Generic;
using System.Linq;
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
        /// Largest Palindrome Product
        /// Find the largest palindrome made from the product of two N-digit numbers
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public long Problem4(int N)
        {
            long num1 = 0;
            List<long> Palindromes = new List<long>();
            for(int i = 0; i < N; i++)
            {
                num1 += (9 * (long)(Math.Pow(10, i)));
            }
            while(num1 > 0)
            {
                long num2 = num1;
                while(num2 > 0)
                {
                    if (IsPalindrome(num1 * num2))
                        Palindromes.Add(num1*num2);
                    num2--;
                }
                num1--;
            }
            return Palindromes.Max();
        }
        /// <summary>
        /// Smallest Multiple
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public long Problem5(int limit)
        {
            long num = 1;
            while (true)
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (num % i != 0)
                        break;
                    if (i == limit)
                        return num;
                }
                num++;
            }
        }
        /// <summary>
        /// Sum Square Difference
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public long Problem6(long nums)
        {
            long sumsquare = 0, squaresum = 0;
            for(long i = 1; i <= nums; i++)
            {
                sumsquare += i * i;
                squaresum += i;
            }
            squaresum *= squaresum;
            return squaresum - sumsquare;
        }
        /// <summary>
        /// Nth Prime
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public long Problem7(long N)
        {
            long x = 2;
            while(N > 0)
            {
                bool isPrime = true;
                x++;
                for (long i = x - 1; i > 1; i--)
                {
                    if(x % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    N--;
                if (N == 1)
                    return x;
            }
            return 0;
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
        /// <summary>
        /// Checks if number is a palindrome number
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private bool IsPalindrome(long num)
        {
            long[] numbers;
            if (num == 0)
                return false;
            else
                numbers = ConvertToNumList(num).ToArray();
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != numbers[numbers.Length - (i + 1)])
                    return false;
            }
            return true;
        }
        /// <summary>
        /// Takes a long and converts it to a long Stack
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private Stack<long> ConvertToNumList(long num)
        {
            if (num == 0) return new Stack<long>();
            var numbers = ConvertToNumList(num / 10);
            numbers.Push(num % 10);
            return numbers;
        }
    }
}
