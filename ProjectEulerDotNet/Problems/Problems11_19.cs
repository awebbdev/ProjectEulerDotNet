using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;
using System.Numerics;

namespace ProjectEulerDotNet.Problems
{
    public class Problems11_19
    {
        public long Problem11()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Repositories\awebbdev\ProjectEulerDotNet\ProjectEulerDotNet\DataSources\Problem11.txt");
            List<List<long>> grid = new List<List<long>>();
            foreach (string line in lines)
            {
                List<long> nums = line.Split(" ").Select(n => Convert.ToInt64(n)).ToList();
                grid.Add(nums);
            }
            long answerRight = MultRight(grid);
            long answerDown = MultDown(grid);
            long answerRightDiag = MultRightDiag(grid);
            long answerLeftDiag = MultLeftDiag(grid);
            Console.WriteLine("Right: " + answerRight + ", Down: " + answerDown + ", Right Diag: " + answerRightDiag + ", Left Diag: " + answerLeftDiag);
            return Math.Max(Math.Max(Math.Max(answerDown, answerRight), answerLeftDiag), answerRightDiag);
        }

        public long MultRight(List<List<long>> grid)
        {
            long answer = 0;
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid[i].Count - 3; j++)
                {
                    long result = grid[i][j] * grid[i][j + 1] * grid[i][j + 2] * grid[i][j + 3];
                    if (result > answer)
                        answer = result;
                }
            }
            return answer;
        }

        public long MultDown(List<List<long>> grid)
        {
            long answer = 0;
            for (int i = 0; i < grid.Count - 3; i++)
            {
                for (int j = 0; j < grid[i].Count; j++)
                {
                    long result = grid[i][j] * grid[i + 1][j] * grid[i + 2][j] * grid[i + 3][j];
                    if (result > answer)
                        answer = result;
                }
            }
            return answer;
        }

        public long MultRightDiag(List<List<long>> grid)
        {
            long answer = 0;
            for (int i = 0; i < grid.Count - 3; i++)
            {
                for (int j = 0; j < grid[i].Count - 3; j++)
                {
                    long result = grid[i][j] * grid[i + 1][j + 1] * grid[i + 2][j + 2] * grid[i + 3][j + 3];
                    if (result > answer)
                        answer = result;
                }
            }
            return answer;
        }

        public long MultLeftDiag(List<List<long>> grid)
        {
            long answer = 0;
            for (int i = 0; i < grid.Count - 3; i++)
            {
                for (int j = 3; j < grid[i].Count; j++)
                {
                    long result = grid[i][j] * grid[i + 1][j - 1] * grid[i + 2][j - 2] * grid[i + 3][j - 3];
                    if (result > answer)
                        answer = result;
                }
            }
            return answer;
        }

        public long Problem12(int div)
        {
            int i = 1;
            Dictionary<long, int> factors = new Dictionary<long, int>();
            long tri;
            while (true)
            {
                tri = CalculateTriangle(i);
                factors = PrimeFactors(tri);
                int facts = NumFactors(factors);
                if (facts >= div)
                {
                    return tri;
                }
                i++;
            }
        }

        public long CalculateTriangle(int nth)
        {
            long answer = 0;
            for (int i = 1; i <= nth; i++)
            {
                answer += i;
            }
            return answer;
        }

        public Dictionary<long, int> PrimeFactors(long num)
        {
            long a;
            Dictionary<long, int> retVal = new Dictionary<long, int>();
            for (a = 2; num > 1; a++)
            {
                int x = 0;
                while (num % a == 0)
                {
                    num /= a;
                    x++;
                }
                if (x > 0)
                    retVal.Add(a, x);
            }
            return retVal;
        }
        public int NumFactors(Dictionary<long, int> primes)
        {
            int retVal = 1;
            foreach (var item in primes)
            {
                retVal *= item.Value + 1;
            }
            return retVal;
        }


        public string Problem13()
        {
            return System.IO.File.ReadAllLines(@"C:\Repositories\awebbdev\ProjectEulerDotNet\ProjectEulerDotNet\DataSources\Problem13.txt")
                                    .Select(System.Numerics.BigInteger.Parse)
                                    .Aggregate((i1, i2) => i1 + i2)
                                    .ToString()
                                    .Substring(0, 10);
        }

        public long Problem14()
        {
            long x = 500000;
            long y = 0;
            long count = 0;
            while(x < 1000000)
            {
                long c = CollatzCount(x);
                if(count < c)
                {
                    count = c;
                    y = x;
                }
                x++;
            }
            return y;
        }

        public long CollatzSequence(long x)
        {
            if(x % 2 == 0)
            {
                return x / 2;
            }
            else
            {
                return 3 * x + 1;
            }
        }

        public long CollatzCount(long num)
        {
            long count = 1;
            while (num != 1)
            {
                count++;
                num = CollatzSequence(num);
            }
            return count;
        }

        public long Problem15(int grid)
        {
            long paths = 1;
            for(int i = 0; i < grid; i++)
            {
                paths *= (2 * grid) - i;
                paths /= i + 1;
            }
            return paths;
        }
        public long Problem16(int num, int pow)
        {
            BigInteger result = (BigInteger)Math.Pow(num, pow);
            long answer = 0;
            while(result >= 1)
            {
                answer += (long)(result % 10);
                result /= 10;
            }
            return answer;
        }
        public long Problem17(int limit)
        {
            for(int x = 1; x <= limit; x++)
            {
                string word = IntToString(x);
            }
            return 0;
        }

        public string IntToString(int num)
        {
            string place = "";
            string numWord = "";
            bool isDone = false;
            if(num > 0)
            {
                int numDigits = 0;
                int pos = 0;
                int tNum = num;
                while(tNum >= 1)
                {
                    numDigits++;
                    tNum /= 10;
                }
                switch (numDigits)
                {
                    case 1:
                        numWord = ones(num);
                        isDone = true;
                        break;
                    case 2:
                        numWord = tens(num);
                        isDone = true;
                        break;
                    case 3:
                        pos = (numDigits % 3) + 1;
                        place = " hundred ";
                        break;
                    case 4:
                        pos = (numDigits % 4) + 1;
                        place = " thousand ";
                        break;
                    default:
                        isDone = true;
                        break;
                }
                if (!isDone)
                {
                    return numWord;
                }
                return numWord;
            }
            return numWord;
        }
        public string ones(int num)
        {
            string name = "";
            switch (num)
            {
                case 1:
                    name = "one";
                    break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
            }
            return name;
        }
        public string tens(int num)
        {
            string name = null;
            switch (num)
            {
                case 10:
                    name = "ten";
                    break;
                case 11:
                    name = "eleven";
                    break;
                case 12:
                    name = "twelve";
                    break;
                case 13:
                    name = "thirteen";
                    break;
                case 14:
                    name = "fourteen";
                    break;
                case 15:
                    name = "fifteen";
                    break;
                case 16:
                    name = "sixteen";
                    break;
                case 17:
                    name = "seventeen";
                    break;
                case 18:
                    name = "eighteen";
                    break;
                case 19:
                    name = "nineteen";
                    break;
                case 20:
                    name = "twenty";
                    break;
                case 30:
                    name = "thirty";
                    break;
                case 40:
                    name = "fourty";
                    break;
                case 50:
                    name = "fifty";
                    break;
                case 60:
                    name = "sixty";
                    break;
                case 70:
                    name = "seventy";
                    break;
                case 80:
                    name = "eighty";
                    break;
                case 90:
                    name = "ninety";
                    break;
                default:
                    if (num > 0)
                    {
                        name = tens(num - (num%10)) + " " + ones(num);
                    }
                    break;
            }
            return name;
        }
    }
}
