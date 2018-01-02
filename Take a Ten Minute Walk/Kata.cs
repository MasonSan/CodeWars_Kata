//You live in the city of Cartesia where all roads are laid out in a perfect grid.You arrived ten minutes too early to an appointment, so you decided to take the opportunity to go for a short walk.The city provides its citizens with a Walk Generating App on their phones -- everytime you press the button it sends you an array of one-letter strings representing directions to walk (eg. ['n', 's', 'w', 'e']). You know it takes you one minute to traverse one city block, so create a function that will return true if the walk the app gives you will take you exactly ten minutes(you don't want to be early or late!) and will, of course, return you to your starting point. Return false otherwise.
//Note: you will always receive a valid array containing a random assortment of direction letters ('n', 's', 'e', or 'w' only). It will never give you an empty array(that's not a walk, that's standing still!).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_a_Ten_Minute_Walk
{
    public class Kata
    {
        public static bool IsValidWalk(string[] walk)
        {
            if (walk.Length != 10)
                return false;

            var groups = walk.GroupBy(o => o);
            var ns = 0;
            var we = 0;

            foreach (var group in groups)
            {
                if (group.Key == "n")
                    ns = ns + group.Count();
                if (group.Key == "s")
                    ns = ns - group.Count();
                if (group.Key == "w")
                    we = we + group.Count();
                if (group.Key == "e")
                    we = we - group.Count();
            }

            return ns == 0 && we == 0;
        }
    }
}
