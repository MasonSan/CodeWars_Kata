//You are given an array strarr of strings and an integer k.Your task is to return the first longest string consisting of k consecutive strings taken in the array.

//#Example: longest_consec(["zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail"], 2) --> "abigailtheta"

//n being the length of the string array, if n = 0 or k > n or k <= 0 return "".

using System;
using System.Linq;
using NUnit.Framework;

namespace Consecutive_strings
{
    public class LongestConsecutives
    {

        public static String LongestConsec(string[] strarr, int k)
        {
            var result = string.Empty;

            if (strarr.Length == 0 || k > strarr.Length || k <= 0)
                return string.Empty;
            else
            {
                return Enumerable.Range(0, strarr.Length - k + 1)
                         .Select(x => string.Join("", strarr.Skip(x).Take(k)))
                         .OrderByDescending(x => x.Length)
                         .First();

                //var currentIndex = 0;
                //var longestIndex = 0;
                //var maxLength = 0;
                //var tmpLength = 0;

                //while ((currentIndex + k) <= strarr.Length )
                //{
                //    tmpLength = string.Join(string.Empty, strarr.Skip(currentIndex).Take(k)).Length;

                //    if (tmpLength > maxLength)
                //    {
                //        maxLength = tmpLength;
                //        longestIndex = currentIndex;
                //    }

                //    currentIndex++;
                //}

                //return string.Join(string.Empty, strarr.Skip(longestIndex).Take(k));
            }
        }
    }

    [TestFixture]
    public static class LongestConsecutivesTests
    {
        private static void testing(string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void LongestConsecutives_test1()
        {
            Console.WriteLine("Basic Tests");
            //testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2), "abigailtheta");
            //testing(LongestConsecutives.LongestConsec(new String[] { "ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh" }, 1), "oocccffuucccjjjkkkjyyyeehh");
            //testing(LongestConsecutives.LongestConsec(new String[] { }, 3), "");
            testing(LongestConsecutives.LongestConsec(new String[] { "itvayloxrp", "wkppqsztdkmvcuwvereiupccauycnjutlv", "vweqilsfytihvrzlaodfixoyxvyuyvgpck" }, 2), "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck");
            //testing(LongestConsecutives.LongestConsec(new String[] { "wlwsasphmxx", "owiaxujylentrklctozmymu", "wpgozvxxiu" }, 2), "wlwsasphmxxowiaxujylentrklctozmymu");
            //testing(LongestConsecutives.LongestConsec(new String[] { "zone", "abigail", "theta", "form", "libe", "zas" }, -2), "");
            //testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 3), "ixoyx3452zzzzzzzzzzzz");
            //testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 15), "");
            //testing(LongestConsecutives.LongestConsec(new String[] { "it", "wkppv", "ixoyx", "3452", "zzzzzzzzzzzz" }, 0), "");
        }
    }

}
