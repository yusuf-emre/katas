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
        // Use the in-order traversal method to traverse the tree and check if the values
        // in the tree are in ascending order.
        return IsValidBST(root, null, null);
    }

    private bool IsValidBST(TreeNode node, int? min, int? max)
    {
        // If the current node is null, it is a valid BST.
        if (node == null)
        {
            return true;
        }

        // If the current node's value is less than the minimum value or greater than the maximum value,
        // it is not a valid BST.
        if (min != null && node.val <= min || max != null && node.val >= max)
        {
            return false;
        }

        // Recursively check the left and right subtrees of the current node, using the current node's
        // value as the new minimum or maximum value (depending on which subtree is being checked).
        return IsValidBST(node.left, min, node.val) && IsValidBST(node.right, node.val, max);
    }
}