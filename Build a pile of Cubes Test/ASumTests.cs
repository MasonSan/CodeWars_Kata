using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Build_a_pile_of_Cubes;

namespace Build_a_pile_of_Cubes_Test
{
    [TestClass]
    public class ASumTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2022, ASum.findNb(4183059834009));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(-1, ASum.findNb(24723578342962));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4824, ASum.findNb(135440716410000));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(3568, ASum.findNb(40539911473216));
        }
    }
}
