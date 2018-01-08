
using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;

namespace Double_Cola
{
    [TestFixture]
    public class ListTests
    {

        [Test]
        public void Line_Test1()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 1;
            Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
        }

        [Test]
        public void Line_Test2()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Sheldon", Line.WhoIsNext(names, n));
        }
    }

    public class Line
    {
        public static string WhoIsNext(string[] names, long n)
        {
            // Your code is here :)
            var lenght = names.Length;
            return n <= lenght ? names[n - 1] : WhoIsNext(names, (n - lenght + 1) / 2);
        }
    }
}
