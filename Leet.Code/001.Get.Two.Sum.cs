namespace Leet.Code
{

    public class _001GetTwoSum
    {

        public static void Answer()
        {
            var output = GetTwoSum(new [] {3, 2, 4}, 6);
        }

        private static int[] GetTwoSum(int[] nums, int target)
        {
            var output = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;
                    }
                }
            }
            return output;
        }

    }

}
