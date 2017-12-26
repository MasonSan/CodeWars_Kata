//You are going to be given a word.Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.

//#Examples:
//runBF("test") should return "es"
//runBF("testing") should return "t"
//runBF("middle") should return "dd"
//runBF("A") should return "A"

using System.Linq;

namespace Get_the_Middle_Character
{
    public class Kata
    {
        public static string GetMiddle(string s)
        {
            //Code goes here!
            var skipCount = (s.Length - 1) / 2;
            var takeCount = 0;
            if (s.Length % 2 == 0)
            {
                //odd
                takeCount = 2;
                return string.Join(string.Empty, s.Skip(skipCount).Take(takeCount));
            }
            else
            {
                //even
                takeCount = 1;

                return string.Join(string.Empty, s.Skip(skipCount).Take(takeCount));
            }

            //Solution上的最佳解
            //用了5捨6入的概念，可以避免要判斷單雙數的差別
            //return string.IsNullOrEmpty(s)
            //? s
            //: s.Substring((s.Length - 1) / 2, 2 - s.Length % 2);
        }
    }
}