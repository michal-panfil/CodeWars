using System;
using NUnit.Framework;
using CodeWars.AreTheSame;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test
{
    [TestFixture]
    public class AreTheySameTest
    {

        [Test]
        public void CheckIfArrayAreTheSame()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.comp(a, b); 
            Assert.AreEqual(true, r);
        }
    }
}
