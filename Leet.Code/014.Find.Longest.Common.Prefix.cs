using System.Linq;

namespace Leet.Code
{

    public class _0014FindLongestCommonPrefix
    {

        public static void Answer()
        {
            var inputs = new[] {"abcdefg", "abcdefghij", "abcdefghijk", "abcef"};
            var inputs2 = new[] {"", "b"};
            var inputs3 = new[] {"aa", "aa"};
            var output2 = FindLongestCommonPrefix(inputs2);
            var output3 = FindLongestCommonPrefix(inputs3);
        }

        public static string FindLongestCommonPrefix(string[] inputs)
        {
            var count = inputs.Length;
            var result = string.Empty;
            if (count == 0) return result;
            if (count == 1) return inputs.First();
            var index = 0;
            var minSize = 0;
            for (var i = 0; i < count; i++)
            {
                var size = inputs[i].Length;
                if (size < minSize || minSize == 0)
                {
                    minSize = size;
                    index = i;
                }
            }
            for (var i = minSize; i >= 0; i--)
            {
                result = inputs[index].Substring(0, i);
                var j = 0;
                for (; j < count; j++)
                {
                    if (j == index) continue;
                    if (inputs[j].Length == 0) return string.Empty;
                    var temp = inputs[j].Substring(0, i);
                    if (result != temp) break;
                }
                if (j == count) return result;
            }
            return result;
        }

    }

}
