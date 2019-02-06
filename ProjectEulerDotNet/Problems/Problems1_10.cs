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

        public long Problem8(int adjNums)
        {
            string numString = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            List<int> numSequence = new List<int>();
            long LargestMult = 0;
            foreach (char c in numString.ToCharArray())
            {
                numSequence.Add(Convert.ToInt32(c.ToString()));
            }
            for(int i = 0; i < (numSequence.Count - adjNums); i++)
            {
                long tempMult = numSequence[i];
                for(int j = 1; j < adjNums; j++)
                {
                    tempMult *= numSequence[i + j];
                }
                if (tempMult > LargestMult)
                    LargestMult = tempMult;
            }
            return LargestMult;
        }


        /// <summary>
        /// Recursive Fibonacci sequence
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public long Fibonacci(long num)
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
        public bool IsPalindrome(long num)
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
        public Stack<long> ConvertToNumList(long num)
        {
            if (num == 0) return new Stack<long>();
            var numbers = ConvertToNumList(num / 10);
            numbers.Push(num % 10);
            return numbers;
        }
    }
}
