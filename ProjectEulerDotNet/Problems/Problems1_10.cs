using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerDotNet.Problems
{
    public class Problems1_10
    {
        public int Problem1 (int limit)
        {
            List<int> mults = new List<int>();
            int answer = 0;
            for(int i = 0; i < limit; i++)
            {
                if(i%3 == 0 || i%5 == 0)
                {
                    mults.Add(i);
                }
            }
            foreach(int m in mults)
            {
                answer += m;
            }
            return answer;
        }

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
