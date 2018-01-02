//Bob is preparing to pass IQ test.The most frequent task in this test is to find out which one of the given numbers differs from the others. Bob observed that one number usually differs from the others in evenness.Help Bob — to check his answers, he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.

//! Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)

using System;
using NUnit.Framework;

namespace IQ_Test
{
    public class IQ
    {
        public static int Test(string numbers)
        {
            //Your code is here...
            throw new NotImplementedException();
        }
    }

    [TestFixture]
    public class Kata
    {
        [Test]
        public void IQTest_Test1()
        {
            Assert.AreEqual(3, IQ.Test("2 4 7 8 10"));
        }

        [Test]
        public void IQTest_Test2()
        {
            Assert.AreEqual(1, IQ.Test("1 2 2"));
        }
    }
}
