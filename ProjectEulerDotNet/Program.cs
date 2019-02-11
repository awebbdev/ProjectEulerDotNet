using System;
using ProjectEulerDotNet.Problems;

namespace ProjectEulerDotNet.Answers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Problems1_10 p1_10 = new Problems1_10();
            Problems11_19 p11_19 = new Problems11_19();
            //Console.WriteLine("Problem 1: " + p1_10.Problem1(1000));
            //Console.WriteLine("Problem 2: " + p1_10.Problem2(4000000));
            //Console.WriteLine("Problem 3: " + p1_10.Problem3(600851475143));
            //Console.WriteLine("Problem 4: " + p1_10.Problem4(3));
            ////Console.WriteLine("Problem 5: " + p1_10.Problem5(20));
            //Console.WriteLine("Problem 6: " + p1_10.Problem6(100));
            ////Console.WriteLine("Problem 7: " + p1_10.Problem7(10001));
            //Console.WriteLine("Problem 8: " + p1_10.Problem8(13));
            //Console.WriteLine("Problem 10: " + p1_10.Problem10(2000000));
            Console.WriteLine("Problem 11: " + p11_19.Problem11());
            Console.WriteLine("Problem 12: " + p11_19.Problem12(500));

            Console.ReadLine();
        }
    }
}
