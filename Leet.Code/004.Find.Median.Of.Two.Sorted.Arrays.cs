namespace Leet.Code
{

    public class _004FindMedianOfTwoSortedArrays
    {

        public static void Answer()
        {
            
        }

        public static double FindMedianOfTwoSortedArrays(int[] input1, int[] input2)
        {
            var m = input1.Length;
            var n = input2.Length;
            if ((m + n) % 2 != 0) return FindCth(input1, input2, (m + n) / 2, 0, m - 1, 0, n - 1);
            return (FindCth(input1, input2, (m + n) / 2, 0, m - 1, 0, n - 1) +
                    FindCth(input1, input2, (m + n) / 2 - 1, 0, m - 1, 0, n - 1)) * 0.5;

        }

        public static double FindCth(int[] input1, int[] input2, int c, int i, int j, int k, int l)
        {

            var input1L = j - i + 1;
            var input2L = l - k + 1;

            // Handle special cases
            if (input1L == 0) return input2[k + c];
            if (input2L == 0) return input1[i + c];
            if (c == 0) return input1[i] < input2[k] ? input1[i] : input2[k];

            var input1M = input1L * c / (input1L + input2L); // a's middle count
            var input2M = c - input1M - 1; // b's middle count

            // make aMid and bMid to be array index
            input1M = input1M + i;
            input2M = input2M + k;

            if (input1[input1M] > input2[input2M])
            {
                c = c - (input2M - c + 1);
                j = input1M;
                k = input2M + 1;
            }
            else
            {
                c = c - (input1M - i + 1);
                l = input2M;
                i = input1M + 1;
            }

            return FindCth(input1, input2, c, i, j, k, l);

        }

        //private static double FindMedian(int[] input1, int[] input2, int n)
        //{
        //    if (n <= 0) return -1;
        //    if (n == 1) return (input1[0] + input2[0]) / 2;
        //    if (n == 2) return (Math.Max(input1[0], input2[0]) + Math.Min(input1[1], input2[1])) / 2;
        //    var m1 = FindMedian(input1, n);
        //    var m2 = FindMedian(input2, n);
        //    if (m1 == m2) return m1;
    //if (m1 < m2)
    //{
    //    if (n % 2 == 0)
    //        return getMedian(ar1 + n/2 - 1, ar2, n - n/2 +1);
    //    return getMedian(ar1 + n/2, ar2, n - n/2);
    //}
 
    ///* if m1 > m2 then median must exist in ar1[....m1] and
    //    ar2[m2...] */
    //if (n % 2 == 0)
    //    return getMedian(ar2 + n/2 - 1, ar1, n - n/2 + 1);
    //return getMedian(ar2 + n/2, ar1, n - n/2);

        //}

        //private static double FindMedian(int[] input, int n)
        //{
        //    if (n % 2 == 0) return (input[n / 2] + input[n / 2 - 1]) / 2;
        //    return input[n / 2];
        //}

    }

}
