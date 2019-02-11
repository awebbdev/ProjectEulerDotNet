﻿using System;
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
        public void Prime_Factor_Test()
        {
            Dictionary<long, int> factors = new Dictionary<long, int>();
            factors.Add(2, 2);
            factors.Add(7, 2);
            Assert.Equal(factors, _p_11_19.PrimeFactors(196));
        }
        [Fact]
        public void Num_Factors_Test()
        {
            Dictionary<long, int> factors = new Dictionary<long, int>();
            factors.Add(2, 2);
            factors.Add(7, 2);
            Assert.Equal(9, _p_11_19.NumFactors(factors));
        }

        [Fact]
        public void Problem12_Test()
        {
            Assert.Equal(28, _p_11_19.Problem12(5));
        }
    }
}
