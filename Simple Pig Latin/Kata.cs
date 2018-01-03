//Move the first letter of each word to the end of it, then add "ay" to the end of the word.Leave punctuation marks untouched.
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Simple_Pig_Latin
{
    [TestFixture]
    public class Kata
    {
        [Test]
        public void Simple_Pig_Latin_KataTests()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", Kata.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay !", Kata.PigIt("This is my string !"));
        }

        public static string PigIt(string str)
        {
            var result = new List<string>();
            var addStr = "ay";

            Regex regax = new Regex("[a-zA-Z0-9]+");

            var array = str.Split(' ');

            foreach (var s in array)
            {
                if (regax.Match(s).Success)
                {
                    var add = s.Substring(1) + s[0] + addStr;
                    result.Add(string.Join(string.Empty, add));
                }
                else
                    result.Add(s);
            }

            return string.Join(" ", result);
        }
    }
}