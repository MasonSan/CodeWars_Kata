using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Get_the_Middle_Character_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GenericTests()
        {
            Assert.AreEqual("es", Kata.GetMiddle("test"));
            Assert.AreEqual("t", Kata.GetMiddle("testing"));
            Assert.AreEqual("dd", Kata.GetMiddle("middle"));
            Assert.AreEqual("A", Kata.GetMiddle("A"));
        }
    }
}
