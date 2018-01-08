using System;
using System.Text;
using NUnit.Framework;

namespace IP_Validation
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void TestCases()
        {
            Assert.AreEqual(Kata.is_valid_IP("12.255.56.1"), true);
            Assert.AreEqual(Kata.is_valid_IP(""), false);
            Assert.AreEqual(Kata.is_valid_IP("abc.def.ghi.jkl"), false);
            Assert.AreEqual(Kata.is_valid_IP("123.456.789.0"), false);
            Assert.AreEqual(Kata.is_valid_IP("12.34.56"), false);
            Assert.AreEqual(Kata.is_valid_IP("12.34.56 .1"), false);
            Assert.AreEqual(Kata.is_valid_IP("12.34.56.-1"), false);
            Assert.AreEqual(Kata.is_valid_IP("123.045.067.089"), false);
        }
    }

    class Kata
    {
        public static bool is_valid_IP(string IpAddres)
        {
            //Code here

        }
    }
}
