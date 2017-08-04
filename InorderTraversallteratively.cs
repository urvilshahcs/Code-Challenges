
  public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }
 
public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        List<int> nodes = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode cur = root;
        if (root == null)
        {
            return nodes;
        }
        while (cur != null || stack.Count != 0)
        {
            while (cur != null)
            {
                stack.Push(cur);
                cur = cur.left;
            }
            cur = stack.Pop();
            nodes.Add(cur.val);
            cur = cur.right;
        }

        return nodes;
    }
}