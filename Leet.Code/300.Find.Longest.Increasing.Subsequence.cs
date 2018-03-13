using System;
using System.Collections.Generic;
using System.Linq;

namespace Everyday.Programming
{
    class _300FindLongestIncreasingSubsequenece
    {

        public static void Answer()
        {
            var inputs = new List<int> { 10, 9, 2, 5, 3, 7, 101, 18 };
            var output = FindLongestIncreasingSubsequenece(inputs);
        }

        /// <summary>
        /// Space Complexity: O(n^2)
        /// Time Complexity: O(n)
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int FindLongestIncreasingSubsequenece(List<int> inputs)
        {
            if (inputs.Count == 0) return 0;
            var dynamicProgramming = new int[inputs.Count];
            dynamicProgramming[0] = 1;
            var max = 1;
            for (var i = 1; i < dynamicProgramming.Count(); i++)
            {
                var curr = 0;
                for (var j = 0; j < i; j++)
                {
                    if (inputs[i] > inputs[j]) curr = Math.Max(curr, dynamicProgramming[j]);
                }
                dynamicProgramming[i] = curr + 1;
                max = Math.Max(max, dynamicProgramming[i]);
            }
            return max;
        }
    }
}
