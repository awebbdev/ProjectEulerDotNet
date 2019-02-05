using NUnit.Framework;
using ProjectEulerDotNet.Problems;

namespace ProjectEulerDotNet.UnitTests
{
    public class Tests
    {
        [TestFixture]
        public class ProblemOne_TenTests
        {
            private readonly Problems1_10 _problem1_10;

            public ProblemOne_TenTests()
            {
                _problem1_10 = new Problems1_10();
            }

            [Test]
            public void Find_Sum_Of_Three_Five_Multi_For_10 ()
            {
                var result = _problem1_10.Problem1(10);
                Assert.AreEqual(23, result);
            }

            [Test]
            public void Problem2()
            {
                var result = _problem1_10.Problem2(100);
                Assert.AreEqual(44, result);
            }

            [Test]
            public void Problem3()
            {
                var result = _problem1_10.Problem3(13195);
                Assert.AreEqual(29, result);
            }
            [Test]
            public void Problem4()
            {
                var result = _problem1_10.Problem4(2);
                Assert.AreEqual(9009, result);
            }
            [Test]
            public void Problem5()
            {
                var result = _problem1_10.Problem5(10);
                Assert.AreEqual(2520, result);
            }
            [Test]
            public void Problem6()
            {
                var result = _problem1_10.Problem6(10);
                Assert.AreEqual(2640, result);
            }
            [Test]
            public void Problem7()
            {
                var result = _problem1_10.Problem7(6);
                Assert.AreEqual(13, result);
            }
        }
    }
}