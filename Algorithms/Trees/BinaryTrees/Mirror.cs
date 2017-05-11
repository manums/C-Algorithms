using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Trees.BinaryTrees
{
    public class Mirror
    {
        public static void ConvertToMirrorTree(TreeNode<int> root)
        {
            if (root == null)
                return;
            ConvertToMirrorTree(root.Left);
            ConvertToMirrorTree(root.Right);

            /*at every node, we need to swap left and right node, then it looks like mirror tree
             *      4
             *    /   \
             * 1        5
             * For above tree if we swap 1 and 5, resulting tree is mirror image of given tree.*/
            var temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;            
        }

        public static bool AreTwoTreesMirrors(TreeNode<int> root1, TreeNode<int> root2)
        {
            if (root1 == null && root2 == null)
                return true;
            else if (root1 == null || root2 == null)
                return false;
            else
                return (root1.Data == root2.Data) && AreTwoTreesMirrors(root1.Left, root2.Right)
                    && AreTwoTreesMirrors(root1.Right, root2.Left);
        }
    }
}
