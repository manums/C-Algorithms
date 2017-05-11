using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class TreeNode<T>
    {
        public T Data { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }
    }
    public class Common
    {

        public static void PrintInOrderOfATree<T>(TreeNode<T> root)
        {
            if (root == null)
                return;
            PrintInOrderOfATree(root.Left);
            if(root!=null)
                Console.Write(root.Data+" - ");
            PrintInOrderOfATree(root.Right);
        }
    }
}
