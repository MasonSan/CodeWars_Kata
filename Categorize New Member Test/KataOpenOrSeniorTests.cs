using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Categorize_New_Member;
using System.Linq;

namespace Categorize_New_Member_Test
{
    [TestClass]
    public class KataOpenOrSeniorTests
    {
        [TestMethod]
        public void SampleTest()
        {
            CollectionAssert.AreEqual(new[] { "Open", "Senior", "Open", "Senior" }, Kata.OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }).ToArray());
            CollectionAssert.AreEqual(new[] { "Open", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }).ToArray());
            CollectionAssert.AreEqual(new[] { "Senior", "Open", "Open", "Open" }, Kata.OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }).ToArray());
        }
    }
}
