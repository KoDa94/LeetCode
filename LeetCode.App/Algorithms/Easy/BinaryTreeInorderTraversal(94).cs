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
}

public class Solution94Easy 
{
    public IList<int> InorderTraversal (TreeNode root)
    {
        IList<int> result = new List<int>();
        var currentNode = root;

        while (currentNode != null)
        {
            if (currentNode.left == null)
            {
                result.Add(currentNode.val);
                currentNode = currentNode.right;
            }
            else
            {
                var nextNode = currentNode.left;

                while (nextNode.right != null && nextNode.right != currentNode)
                {
                    nextNode = nextNode.right;
                }

                if (nextNode.right == null)
                {
                    nextNode.right = currentNode;
                    currentNode = currentNode.left;
                }
                else
                {
                    nextNode.right = null;
                    result.Add(currentNode.val);
                    currentNode = currentNode.right;
                }
            }
        }

        return result;
    }
}