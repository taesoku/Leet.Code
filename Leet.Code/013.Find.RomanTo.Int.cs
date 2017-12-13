using System.Collections.Generic;

namespace Leet.Code
{

    public class _0013FindRomanToInt
    {

        public static void Answer()
        {
            var output = FindRomanToInt("MM");
        }

        public static Dictionary<char, int> dictionary = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static int FindRomanToInt(string input)
        {
            var output = 0;
            for (var i = 0; i < input.Length; i++)
            {
                if (i + 1 < input.Length && dictionary[input[i]] < dictionary[input[i + 1]])
                    output -= dictionary[input[i]];
                else output += dictionary[input[i]];
            }
            return output;
        }

    }

}
