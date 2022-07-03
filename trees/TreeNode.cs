using System;
using System.Collections.Generic;
using System.Text;

namespace trees
{
    public class TreeNode
    {
        public int Data;

        public TreeNode l;
        public TreeNode r;

        public TreeNode() { }

        public static void Build(TreeNode node, int L, int R, int[] mas)
        {

            if (L != R)
            {
                int mid = (L + R) / 2;

                node.Data = mas[mid];

                if (mid != L)
                {
                    TreeNode Left = new TreeNode();
                    node.l = Left;
                    Build(Left, L, mid - 1, mas);
                }
                else
                {
                    node.l = null;
                }

                if (mid != R)
                {
                    TreeNode Right = new TreeNode();
                    node.r = Right;
                    Build(Right, mid + 1, R, mas);
                }
                else
                {
                    node.r = null;
                }
            }
            else
            {
                node.Data = mas[L];
                node.l = null;
                node.r = null;
            }

        }

        public static void BuildRandomTree(TreeNode node, int[] mas)
        {
            node.Data = mas[0];

            for (int i = 1; i < mas.Length; i++)
            {
                TreeNode temp = node;

                TreeNode parent = null;

                while (temp != null)
                {
                    parent = temp;
                    if (mas[i] < temp.Data)
                    {
                        temp = temp.l;
                    }
                    else
                    {
                        temp = temp.r;
                    }
                }

                TreeNode Newnode = new TreeNode();
                Newnode.Data = mas[i];
                Newnode.l = null;
                Newnode.r = null;

                if (mas[i] < parent.Data)
                    parent.l = Newnode;
                else
                    parent.r = Newnode;
            }
        }

        public static void DelLeaves(TreeNode node)
        {
            if (node.l != null)
            {
                if (node.l.l != null || node.l.r != null)
                {
                    DelLeaves(node.l);
                }
                else
                {
                    node.l = null;

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }

            if (node.r != null)
            {
                if (node.r.l != null || node.r.r != null)
                {
                    DelLeaves(node.r);
                }
                else
                {
                    node.r = null;

                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }
        }
    }
}
