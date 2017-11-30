namespace Leet.Code
{

    public class _526GetBeautifulArrangement
    {

        public static void Answer()
        {
            var output = GetBeautifulArrangement(1);
        }

        static int count = 0;

        public static int GetBeautifulArrangement(int n)
        {
            count = 0;
            var nums = new int[n];
            for (var i = 1; i <= n; i++) nums[i - 1] = i;
            Permute(nums, 0);
            return count;
        }

        internal static void Permute(int[] nums, int l, bool final = false)
        {
            if (l == nums.Length)
            {
                if (nums[l - 1] % l != 0 && l % nums[l - 1] != 0) return;
                count++;
                return;
            }
            if (l != 0 && nums[l - 1] % l != 0 && l % nums[l - 1] != 0) return;
            for (var i = l; i < nums.Length; i++)
            {
                Swap(nums, i, l);
                Permute(nums, l + 1);
                Swap(nums, i, l);
            }
        }

        internal static void Swap(int[] nums, int x, int y)
        {
            var temp = nums[x];
            nums[x] = nums[y];
            nums[y] = temp;
        }

    }

}
