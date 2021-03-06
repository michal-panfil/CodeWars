﻿using System;
using NUnit.Framework;
using CodeWars.WhichAreIn;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Test
{



[TestFixture]
    public class WhichAreInTests
    {

        [Test]
        public void Test1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, WhichAreIn.WhichAreIn.inArray(a1, a2));
        }
    }
}

