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
            var skipCount = 0;
            if (s.Length % 2 == 0)
            {
                //odd
                skipCount = s.Length / 2 - 1;
                return string.Join(string.Empty, s.Skip(skipCount).Take(2));
            }
            else
            {
                //even
                skipCount = (s.Length - 1) / 2;
                return string.Join(string.Empty, s.Skip(skipCount).Take(1));
            }
        }
    }
}