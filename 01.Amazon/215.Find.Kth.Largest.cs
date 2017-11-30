using System.Collections.Generic;

namespace Leet.Code
{
    class _215FindKthLargest
    {

        public static void Answer()
        {
            var inputs = new [] {3, 2, 1, 5, 6, 4};
            var output = FindKthLargest(inputs, 2);
        }

        /// <summary>
        /// Sort and Get the index O(NlogN) + O(1)
        /// </summary>
        /// <param name="inputs">input</param>
        /// <param name="k">kth largest</param>
        public static int FindKthLargest(int[] inputs, int k)
        {
            inputs = MergeList(inputs);
            return inputs[k - 1];
        }


        public static int[] MergeList(int[] inputs)
        {
            var length = inputs.Length;
            if (length == 1) return inputs;
            var mid = inputs.Length / 2;
            var left = new int[mid];
            var right = new int[length - mid];
            for (int i = 0; i < mid; i++) left[i] = inputs[i];
            for (int i = 0; i < length - mid; i++) right[i] = inputs[mid + i];
            left = MergeList(left);
            right = MergeList(right);
            return MergeSort(left, right);
        }

        public static int[] MergeSort(int[] left, int[] right)
        {
            var leftLength = left.Length;
            var rightLength = right.Length;
            var temps = new int[leftLength + rightLength];
            var i = 0;
            var j = 0;
            var k = 0;
            while (i < leftLength && j < rightLength)
            {
                if (left[i] > right[j])
                {
                    temps[k] = left[i];
                    i++;
                }
                else
                {
                    temps[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < leftLength)
            {
                temps[k] = left[i];
                i++;
                k++;
            }
            while (j < rightLength)
            {
                temps[k] = right[j];
                j++;
                k++;
            }
            return temps;
        }

    }
}
