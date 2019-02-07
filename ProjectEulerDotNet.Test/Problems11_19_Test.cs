using System;
using Xunit;
using ProjectEulerDotNet.Problems;
using System.Collections.Generic;

namespace ProjectEulerDotNet.Test
{
    public class Problems11_19_Test
    {
        Problems11_19 _p_11_19 = new Problems11_19();

        [Fact]
        public void CalculateTriangle_Test()
        {
            Assert.Equal(28, _p_11_19.CalculateTriangle(7));
        }

        [Fact]
        public void Factors_Test()
        {
            List<long> factors = new List<long> { 1, 2, 4, 7, 14, 28 };
            Assert.Same(factors, _p_11_19.GetFactors(28));
        }
    }
}
