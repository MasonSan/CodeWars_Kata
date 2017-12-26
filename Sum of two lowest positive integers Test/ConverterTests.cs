using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sum_of_two_lowest_positive_integers;

namespace Sum_of_two_lowest_positive_integers_Test
{
    [TestClass]
    public class ConverterTests
    {
        [TestMethod]
        public void Test1()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Kata.sumTwoSmallestNumbers(numbers));
        }
    }
}
