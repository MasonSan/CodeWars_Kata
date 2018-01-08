//Once upon a time, on a way through the old wild west,…
//… a man was given directions to go from one point to another.The directions were "NORTH", "SOUTH", "WEST", "EAST". Clearly "NORTH" and "SOUTH" are opposite, "WEST" and "EAST" too.Going to one direction and coming back the opposite direction is a needless effort.Since this is the wild west, with dreadfull weather and not much water, it's important to save yourself some energy, otherwise you might die of thirst!
//How I crossed the desert the smart way.

using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Directions_Reduction
{
    [TestFixture]
    public class DirReduction
    {
        [Test]
        public void Directions_Reduction_Test1()
        {
            string[] a = new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            string[] b = new string[] { "WEST" };
            Assert.AreEqual(b, DirReduction.dirReduc(a));
        }

        [Test]
        public void Directions_Reduction_Test2()
        {
            string[] a = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            string[] b = new string[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Assert.AreEqual(b, DirReduction.dirReduc(a));
        }

        public static string[] dirReduc(String[] arr)
        {
            var list = new List<string>(arr);
            var result = new string[] { };
            var oppo = new Dictionary<string, string> { };

            oppo.Add("WEST", "EAST");
            oppo.Add("NORTH", "SOUTH");
            oppo.Add("SOUTH", "NORTH");
            oppo.Add("EAST", "WEST");

            for (var index = 0; index < arr.Length; index++)
            {
                if (index + 1 == arr.Length)
                    break;

                if (arr[index + 1] == oppo[arr[index]])
                {
                    list.RemoveAt(index);
                    list.RemoveAt(index);
                    arr = dirReduc(list.ToArray());
                }
            }

            return arr;
        }
    }
}