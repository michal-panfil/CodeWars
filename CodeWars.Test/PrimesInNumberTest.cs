using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CodeWars.Primes_In_Numbers;

namespace CodeWars.Test
{
    class PrimesInNumberTest
    {
        [Test]
        public void Test1()
        {

            int lst = 7775460;
            Assert.AreEqual("(2**2)(3**3)(5)(7)(11**2)(17)", PrimesInNumber.factors(lst));
        }
    }
}
