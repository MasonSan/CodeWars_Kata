//Move the first letter of each word to the end of it, then add "ay" to the end of the word.Leave punctuation marks untouched.
using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Simple_Pig_Latin
{
    [TestFixture]
    public class Kata
    {
        [Test]
        public void KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", Kata.PigIt("This is my string"));
        }

        public static string PigIt(string str)
        {
            return str;
        }
    }
}