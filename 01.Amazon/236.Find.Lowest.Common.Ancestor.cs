namespace Leet.Code
{
    class _236FindLowestCommonAncestor
    {

        public class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode() { }

            public TreeNode(int x)
            {
                Value = x;
                Left = new TreeNode();
                Right = new TreeNode();
            }
        }

        public static void Answer()
        {

            var input = new TreeNode(3);
            input.Left = new TreeNode(5);

            input.Left.Left = new TreeNode(6);
            input.Left.Right = new TreeNode(2);

            input.Left.Right.Left = new TreeNode(7);
            input.Left.Right.Right = new TreeNode(4);

            input.Right = new TreeNode(1);

            input.Right.Left = new TreeNode(0);
            input.Right.Right = new TreeNode(8);

            var a =FindLowestCommonAncestor(input, input.Left.Right, input.Right);

        }

        public static TreeNode FindLowestCommonAncestor(TreeNode input, TreeNode p, TreeNode q)
        {
            if (input == null || input == p || input == q) return input;
            TreeNode left = FindLowestCommonAncestor(input.Left, p, q);
            TreeNode right = FindLowestCommonAncestor(input.Right, p, q);
            return left == null ? right : right == null ? left : input;
        }

    }
}
