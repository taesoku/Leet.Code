using System;
using System.Collections;

namespace Leet.Code
{

    public class _003FindLengthOfLongestSubstring
    {

        public static void Answer()
        {
            var output = FindLengthOfLongestSubstring("abcabcbb");
        }

        public static int FindLengthOfLongestSubstring(string input)
        {
            var hashtable = new Hashtable();
            var max = 0;
            var n = input.Length;
            for (int i = 0, j = 0; j < n; j++)
            {
                if (hashtable.ContainsKey(input[j]))
                    i = Math.Max((int)hashtable[input[j]], i);
                max = Math.Max(max, j - i + 1);
                hashtable[input[j]] = j + 1;
            }
            return max;
        }

    }

}
