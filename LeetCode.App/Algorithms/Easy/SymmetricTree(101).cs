using System.Collections;
using System.Security.AccessControl;

public class Solution101Easy
{
    public bool IsSymetric(TreeNode root)
    {
        Queue<TreeNode> rightTreePart = new Queue<TreeNode>();
        Queue<TreeNode> leftTreePart = new Queue<TreeNode>();

        rightTreePart.Enqueue(root.right);
        leftTreePart.Enqueue(root.left);

        while (rightTreePart.Count > 0 && leftTreePart.Count > 0)
        {
            var rightNode = rightTreePart.Dequeue();
            var leftNode = leftTreePart.Dequeue();

            if (rightNode == null && leftNode == null)
            {
                continue;
            }

            if ((rightNode != null && leftNode == null) ||
                (rightNode == null && leftNode != null))
            {
                return false;
            }

            if (rightNode.val != leftNode.val)
            {
                return false;
            }
            else
            {
                rightTreePart.Enqueue(rightNode.right);
                rightTreePart.Enqueue(rightNode.left);
                leftTreePart.Enqueue(leftNode.left);
                leftTreePart.Enqueue(leftNode.right);
            }
        }

        return true;
    }
}