using System;
using Xunit;
using ProjectEulerDotNet.Problems;

namespace ProjectEulerDotNet.Test
{
    public class Problems1_10_Test
    {
        Problems1_10 _p1_10 = new Problems1_10();

        [Fact]
        public void Problem1()
        {
            Assert.Equal(23, _p1_10.Problem1(10));
        }
        [Fact]
        public void Problem2()
        {
            Assert.Equal(44, _p1_10.Problem2(100));
        }
        [Fact]
        public void Problem3()
        {
            Assert.Equal(29, _p1_10.Problem3(13195));
        }
        [Fact]
        public void Problem4()
        {
            Assert.Equal(9009, _p1_10.Problem4(2));
        }
        [Fact]
        public void Problem5()
        {
            Assert.Equal(2520, _p1_10.Problem5(10));
        }
        [Fact]
        public void Problem6()
        {
            Assert.Equal(2640, _p1_10.Problem6(10));
        }
        [Fact]
        public void Problem7()
        {
            Assert.Equal(13, _p1_10.Problem7(6));
        }
        [Fact]
        public void Problem8()
        {
            Assert.Equal(5832, _p1_10.Problem8(4));
        }
        [Fact]
        public void Problem9()
        {
            Assert.Equal(31875000, _p1_10.Problem9(1000));
        }
        [Fact]
        public void Problem10()
        {
            Assert.Equal(17, _p1_10.Problem10(10));
        }

    }
}
