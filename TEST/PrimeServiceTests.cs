using static testDemp.PrimeService;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TEST
{
    public class PrimeServiceTests
    {

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        public void Primes_should_return_true(int n)
        {
            Assert.True(IsPrime(n));
            IsPrime(n).Should().BeTrue();
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(4)]
       
        public void NonPrimes_should_return_false(int n)
        {
            Assert.False(IsPrime(n));
            IsPrime(n).Should().BeFalse();
        }

    }
}
