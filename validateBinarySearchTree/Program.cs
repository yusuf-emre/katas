public class Program
{
    static void Main(string[] args)
    {
        var node1R = new TreeNode(3, null);
        var node1L = new TreeNode(1, null);
        var node1 = new TreeNode(2, node1L, node1R);

        var node2RR = new TreeNode(6, null, null);
        var node2RL = new TreeNode(3, null, null);
        var node2R = new TreeNode(4, node2RL, node2RR);
        var node2L = new TreeNode(1, null, null);
        var node2 = new TreeNode(5, node2L, node2R);

        Console.WriteLine(TreeNode.IsValidBST(node1));
        Console.WriteLine(TreeNode.IsValidBST(node2));
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
    public static bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, null, null);
    }

    public static bool IsValidBST(TreeNode node, int? min, int? max)
    {
        if (node == null)
        {
            return true;
        }
        if (min != null && node.val <= min || max != null && node.val >= max)
        {
            return false;
        }
        return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
    }
}