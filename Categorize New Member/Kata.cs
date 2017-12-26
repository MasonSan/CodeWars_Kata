﻿//The Western Suburbs Croquet Club has two categories of membership, Senior and Open.They would like your help with an application form that will tell prospective members which category they will be placed.

//To be a senior, a member must be at least 55 years old and have a handicap greater than 7.
//In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.

//Input
//Input will consist of a list of lists containing two items each. Each list contains information for a single potential member. Information consists of an integer for the person's age and an integer for the person's handicap.

//Note for F#: The input will be of (int list list) which is a List>

using System.Collections.Generic;

namespace Categorize_New_Member
{
    public class Kata
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            //your code here
            List<string> result = new List<string>();

            foreach (int[] m in data)
            {
                if (m[0] >= 55 && m[1] > 7)
                    result.Add("Senior");
                else
                    result.Add("Open");
            }

            return result;
        }
    }
}