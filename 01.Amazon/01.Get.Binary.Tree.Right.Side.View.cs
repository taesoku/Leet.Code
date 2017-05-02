using System.Collections.Generic;

namespace _01.Amazon
{

    public class TreeNode
    {
        public int Val;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int x) { Val = x; }
    }

    public class _01GetBinaryTreeRightSideView
    {

        public static void Answer()
        {
            var root = new TreeNode(1);
            root.Right = new TreeNode(2);
            var output = RightSideView(root);
        }

        public static List<int> RightSideView(TreeNode inputs, List<int> outputs = null, int depth = 0)
        {
            if (outputs == null) outputs = new List<int>();
            if (inputs == null) return outputs;
            if (depth == outputs.Count) outputs.Add(inputs.Val);
            RightSideView(inputs.Left, outputs, depth + 1);
            RightSideView(inputs.Right, outputs, depth + 1);
            return outputs;
        }
    }

}
