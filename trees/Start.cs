using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trees
{
    public partial class Start : Form
    {

        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task32 ts32 = new task32();
            ts32.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            TreeNode fst = new TreeNode();

            int N = rand.Next(2, 11);

            int[] Ns = new int[N];

            for (int i = 0; i < N; i++)
            {
                Ns[i] = rand.Next(-10, 11);
            }

            TreeNode.BuildRandomTree(fst, Ns);

            DrawTree dt = new DrawTree(fst, 41);
            dt.ShowDialog();
        }
    }
}
