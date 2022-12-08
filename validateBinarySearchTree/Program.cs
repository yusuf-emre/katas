public class Program
{
    static void Main(string[] args)
    {
        var node = new TreeNode();
        // node.IsValidBST();
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
    public bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, null, null);
    }

    private bool IsValidBST(TreeNode node, int? min, int? max)
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