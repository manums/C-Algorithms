using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Trees.BinaryTrees
{
    public class BinaryTrees
    {
        public static bool CheckIfTwoTreesAreIdentical(TreeNode<int> root1, TreeNode<int> root2)
        {
            if (root1 == null && root2 == null)
                return true;
            else if (root1 == null || root2 == null)
                return false;
            else
                return (root1.Data == root2.Data) && CheckIfTwoTreesAreIdentical(root1.Left, root2.Left)
                    && CheckIfTwoTreesAreIdentical(root1.Right, root2.Right);
        }

        /// <summary>
        /// The idea is based on the fact that inorder and preorder/postorder uniquely identify a binary tree.
        /// </summary>
        /// <param name="mainRoot"></param>
        /// <param name="subRoot"></param>
        /// <returns></returns>
        public static bool IsSubtreeOofN(TreeNode<char> mainRoot, TreeNode<char> subRoot)
        {

            /*Following are detailed steps.

                1) Find inorder and preorder traversals of T, store them in two auxiliary arrays inT[] and preT[].

                2) Find inorder and preorder traversals of S, store them in two auxiliary arrays inS[] and preS[].

                3) If inS[] is a subarray of inT[] and preS[] is a subarray preT[], then S is a subtree of T. Else not.
            */

            List<char> inOrderMain = new List<char>();
            GetInOrder<char>(mainRoot, inOrderMain);

            List<char> inOrderSubtree = new List<char>();
            GetInOrder<char>(subRoot, inOrderSubtree);

            List<char> preOrderMain = new List<char>();
            GetPreOrder<char>(mainRoot, preOrderMain);

            List<char> preOrderSub = new List<char>();
            GetPreOrder<char>(subRoot, preOrderSub);

            string inOrderM = string.Concat(inOrderMain);
            string inOrderS = string.Concat(inOrderSubtree);

            if (inOrderM.Contains(inOrderS))
            {
                string preOrderM = string.Concat(preOrderMain);
                string preOrderS = string.Concat(preOrderSub);

                if (preOrderM.Contains(preOrderS))
                    return true;
            }
                    
            return false;
        }

        public static void GetInOrder<T>(TreeNode<T> root, List<T> inOrder)
        {
            if (root == null)
                return;
            GetInOrder(root.Left, inOrder);
            if (root != null)
                inOrder.Add(root.Data);
            GetInOrder(root.Right, inOrder);
        }

        public static void GetPreOrder<T>(TreeNode<T> root, List<T> preOrder)
        {
            if (root == null)
                return;

            if (root != null)
                preOrder.Add(root.Data);
            GetPreOrder(root.Left, preOrder);            
            GetPreOrder(root.Right, preOrder);
        }

        public static void GetPostOrder<T>(TreeNode<T> root, List<T> postOrder)
        {
            if (root == null)
                return;

            GetPostOrder(root.Left, postOrder);
            GetPostOrder(root.Right, postOrder);
            if (root != null)
                postOrder.Add(root.Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainRoot"></param>
        /// <param name="subRoot"></param>
        /// <returns></returns>
        public static bool IsSubtreeOofNSquare(TreeNode<int> mainRoot, TreeNode<int> subRoot)
        {
            if (subRoot == null) return true;
            if (mainRoot == null) return false;

            if (CheckIfTwoTreesAreIdentical(mainRoot, subRoot)) return true;

            return CheckIfTwoTreesAreIdentical(mainRoot.Left, subRoot) || CheckIfTwoTreesAreIdentical(mainRoot.Right, subRoot);
        }
    }
}
