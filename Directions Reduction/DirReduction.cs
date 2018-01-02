//Once upon a time, on a way through the old wild west,…
//… a man was given directions to go from one point to another.The directions were "NORTH", "SOUTH", "WEST", "EAST". Clearly "NORTH" and "SOUTH" are opposite, "WEST" and "EAST" too.Going to one direction and coming back the opposite direction is a needless effort.Since this is the wild west, with dreadfull weather and not much water, it's important to save yourself some energy, otherwise you might die of thirst!
//How I crossed the desert the smart way.

using System;
using NUnit.Framework;

namespace Directions_Reduction
{
    [TestFixture]
    public class DirReduction
    {
        [Test]
        public void Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            Assert.AreEqual(b, DirReduction.dirReduc(a));
        }
        [Test]
        public void Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Assert.AreEqual(b, DirReduction.dirReduc(a));
        }

        public static string[] dirReduc(String[] arr)
        {
            throw new NotImplementedException();
        }
    }
}
