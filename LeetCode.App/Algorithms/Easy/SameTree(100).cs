using System.Formats.Asn1;

public class Solution100Easy
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        Queue<TreeNode> pTree = new Queue<TreeNode>();
        Queue<TreeNode> qTree = new Queue<TreeNode>();

        pTree.Enqueue(p);
        qTree.Enqueue(q);

        while (pTree.Count > 0 && qTree.Count > 0)
        {
            var visitedPNode = pTree.Dequeue();
            var visitedQNode = qTree.Dequeue();

            if (visitedPNode == null && visitedQNode == null)
            {
                continue;
            }

            if ((visitedPNode != null && visitedQNode == null) ||
                (visitedPNode == null && visitedQNode != null))
            {
                return false;
            }

            if (visitedPNode.val != visitedQNode.val)
            {
                return false;
            }
            else
            {
                pTree.Enqueue(visitedPNode.left);
                pTree.Enqueue(visitedPNode.right);
                qTree.Enqueue(visitedQNode.left);
                qTree.Enqueue(visitedQNode.right);
            }
        }
        
        return true;
    }
}