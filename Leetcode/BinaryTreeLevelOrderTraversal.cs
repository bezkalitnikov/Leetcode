using System.Collections.Generic;

namespace Leetcode
{
    public class BinaryTreeLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root) 
        {
            var rootList = new List<IList<int>>();
            
            if (root != null)
            {
                LevelOrder(rootList, 0, root);
            }

            return rootList;
        }

        public void LevelOrder(IList<IList<int>> root, int index, TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (root.Count == index)
            {
                root.Add(new List<int>());
            }

            root[index].Add(node.val);

            if (node.left != null || node.right != null)
            {
                LevelOrder(root, index + 1, node.left);
                LevelOrder(root, index + 1, node.right);
            }
        }
    }
}