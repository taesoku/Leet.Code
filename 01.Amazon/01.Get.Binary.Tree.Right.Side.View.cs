using System.Collections.Generic;

namespace _01.Amazon
{

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class _01GetBinaryTreeRightSideView
    {

        public static void Answer()
        {
            var root = new TreeNode(1);
            root.right = new TreeNode(2);
            var output = RightSideView(root);
        }

        private static List<int> RightSideView(TreeNode root, List<int> outputs = null, int depth = 0)
        {
            if (outputs == null) outputs = new List<int>();
            if (root == null) return outputs;
            if (depth == outputs.Count)
                outputs.Add(root.val);
            RightSideView(root.right, outputs, depth + 1);
            RightSideView(root.left, outputs, depth + 1);
            return outputs;
        }
    }

}
