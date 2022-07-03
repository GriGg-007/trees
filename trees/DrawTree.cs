using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trees
{
    public partial class DrawTree : Form
    {
        TreeNode fst;
        int hght;
        Pen mp;
        Font fnt;

        int sw;

        Graphics g;
        public DrawTree(TreeNode node, int i)
        {
            fst = node;
            hght = GetHeight(node);
            mp = new Pen(Color.Black, 4);
            fnt = new Font("Calibri", 20);

            sw = i;

            InitializeComponent();
            this.Width = (int)(Math.Pow(2, hght) * 90);
            this.Height = hght * 200;
        }

        private void DrawTree_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();

            LinkedList<TreeNode> l = new LinkedList<TreeNode>();

            g.Clear(Color.White);

            l.AddLast(fst);

            int hg = this.Size.Height / (hght + 1);

            Draw(g, l, 1, hg);

            if (sw == 41)
            {
                TreeNode.DelLeaves(fst);

                DrawTree dt = new DrawTree(fst, 0);
                dt.ShowDialog();
                this.Close();
            }
        }

        void Draw(Graphics g, LinkedList<TreeNode> tnl, int gen, int h) 
        { 

            int key = 0;

            int dist = this.Size.Width / (tnl.Count + 1);
            int curdist = dist;

            int Ldist = this.Size.Width / (tnl.Count*2 + 1);
            int Lcurdist = Ldist;

            LinkedList<TreeNode> newtnl = new LinkedList<TreeNode>();

            foreach (TreeNode tn in tnl)
            {
                if (tn != null)
                {
                    newtnl.AddLast(tn.l);
                    newtnl.AddLast(tn.r);

                    if (tn.l != null)
                    {
                        key++;
                    }
                    if (tn.r != null)
                    {
                        key++;
                    }
                }
                else
                {
                    TreeNode n = null;
                    newtnl.AddLast(n);
                    newtnl.AddLast(n);
                }
            }


            foreach (TreeNode tn in tnl)
            {
                if (tn != null)
                {
                    if (tn.l != null)
                    {
                        g.DrawLine(mp, curdist - 10, gen * h - 20, Lcurdist - 10, (gen+1) * h - 20);
                    }
                    Lcurdist += Ldist;
                    if (tn.r != null)
                    {
                        g.DrawLine(mp, curdist - 10, gen * h - 20, Lcurdist - 10, (gen + 1) * h - 20);
                    }
                    Lcurdist += Ldist;


                    g.FillEllipse(Brushes.Beige, curdist - 40, gen * h - 40, 80, 80);
                    g.DrawEllipse(mp, curdist - 40, gen * h - 40, 80, 80);
                    g.DrawString(tn.Data.ToString(), fnt, Brushes.Black, new Point(curdist - 15, gen * h - 20));
                }
                else
                {
                    Lcurdist += 2*Ldist;
                }
                curdist += dist;
            }

            gen++;

            if (key != 0)
            {
                Draw(g, newtnl, gen, h);
            }

        }

        static int GetHeight(TreeNode node)
        {
            if (node.r == null && node.l == null)
            {
                return 1;
            }
            else if(node.r != null && node.l == null)
            {
                return (GetHeight(node.r) + 1);
            }
            else if (node.r == null && node.l != null)
            {
                return (GetHeight(node.l) + 1);
            }
            else
            {
                return Math.Max((GetHeight(node.r) + 1), (GetHeight(node.l) + 1));
            }
        }

    }
}