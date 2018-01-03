using System;
using System.Linq;
using NUnit.Framework;

namespace Which_are_in
{
    [TestFixture]
    public class WhichAreInTests
    {
        [Test]
        public void Which_are_in_Test1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }

        [Test]
        public void Which_are_in_Test2()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar", "pillow", "bed", "phht" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong", "codewars" };
            string[] r = new string[] { "cod", "code", "ewar", "wars" };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }

        [Test]
        public void Which_are_in_Test3()
        {
            string[] a1 = new string[] { "cod", "code", "wars", "ewar", "ar" };
            string[] a2 = new string[] {  };
            string[] r = new string[] {  };
            Assert.AreEqual(r, WhichAreIn.inArray(a1, a2));
        }
    }

    public class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            // your code
            return array1.Where(a1 => (array2.Any(a2 => a2.Contains(a1)))).OrderBy(o => o).ToArray();
        }
    }
}
