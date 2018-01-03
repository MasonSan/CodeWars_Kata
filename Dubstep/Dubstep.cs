using System;
using NUnit.Framework;
using System;

namespace Dubstep
{
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            // Your code...
        }
    }

    
  [TestFixture]
    public class DubstepTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABC", Dubstep.SongDecoder("WUBWUBABCWUB"));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("R L", Dubstep.SongDecoder("RWUBWUBWUBLWUB"));
        }
    }
}
