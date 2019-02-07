using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Linq;

namespace ProjectEulerDotNet.Problems
{
    public class Problems11_19
    {
        public long Problem11()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Repositories\awebbdev\ProjectEulerDotNet\ProjectEulerDotNet\DataSources\Problem11.txt");
            List<List<long>> grid = new List<List<long>>();
            foreach(string line in lines)
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
            for(int i = 0; i < grid.Count; i++)
            {
                for(int j = 0; j < grid[i].Count - 3; j++)
                {
                    long result = grid[i][j] * grid[i][j+1] * grid[i][j+2] * grid[i][j+3];
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

        public List<long> GetFactors(long num)
        {
            List<long> factors = new List<long>();
            for(long i = 1; i <= num; i++)
            {
                if (num % i == 0)
                    factors.Add(i);
            }
            return factors;
        }

        public long CalculateTriangle(int nth)
        {
            long answer = 0;
            for(int i = 1; i <= nth; i++)
            {
                answer += i;
            }
            return answer;
        }
    }
}
