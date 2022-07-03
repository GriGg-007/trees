using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trees
{
    public partial class task32 : Form
    {
        int N;
        int[] Ns;

        public task32()
        {
            InitializeComponent();
        }

        private void Nsbutt_Click(object sender, EventArgs e)
        {
            int i;

            if (Nstext.Text.Length == 0)
            {
                hey.Text = "Эй! Напиши что-нибудь!";
            }
            else
            {
                try
                {
                    string[] s = (Nstext.Text).Split(" ");

                    if (s.Length != N)
                    {
                        throw new Exception();
                    }

                    for (i = 0; i < N; i++)
                    {
                        Ns[i] = int.Parse(s[i]);
                    }

                    hey.Text = "";
                    numver.Text = "";

                    Nsbutt.Visible = false;
                    Nstext.Visible = false;

                    TreeNode fst = new TreeNode();
                    TreeNode.Build(fst, 0, N - 1, Ns);

                    DrawTree dt = new DrawTree(fst, 32);
                    dt.ShowDialog();
                    this.Close();
                }
                catch
                {
                    hey.Text = "Нужен набор из " + N + " целых чисел\n    писать через пробел";
                    Nsbutt.Visible = false;
                    Nstext.Visible = false;

                    numver.Text = "Число вершин:";
                    Nbut.Visible = true;
                    Ntext.Visible = true;
                }
            }
        }

        private void Nbut_Click(object sender, EventArgs e)
        {
            int i;

            if (Ntext.Text.Length == 0)
            {
                hey.Text = "Эй! Напиши что-нибудь!";
            }
            else if (!int.TryParse(Ntext.Text, out i))
            {
                hey.Text = "Нужно целое число\n       большее нуля.";
            }
            else
            {
                N = int.Parse(Ntext.Text);
                Ns = new int[N];
                hey.Text = "";

                Nsbutt.Visible = true;
                Nstext.Visible = true;

                numver.Text = "Набор чисел:";
                Nbut.Visible = false;
                Ntext.Visible = false;
            }
        }
    }
}
