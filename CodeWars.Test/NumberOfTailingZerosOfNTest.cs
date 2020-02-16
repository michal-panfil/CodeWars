using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using CodeWars.Number_of_trailing_zeros_of_N;

namespace CodeWars.Test
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestFixture]
    public class NumberOfTailingZerosOfNTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(1, NumberOfTrailingZerosOfN.TrailingZeros(5));
            Assert.AreEqual(6, NumberOfTrailingZerosOfN.TrailingZeros(25));
            Assert.AreEqual(131, NumberOfTrailingZerosOfN.TrailingZeros(531));
        }
    }
        
}
