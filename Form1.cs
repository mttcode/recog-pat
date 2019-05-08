using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RecogPat
{
    public partial class Form1 : Form
    {
        const double eta = 0.2;
        const int maxCells = 16;
        const int weightAct = 16;

        int[] inputs;
        double[,] weights;
        double[] outputs;
        int[] map;
        Button[,] grid_A;
        Button[,] grid_B;

        public Form1()
        {
            InitializeComponent();

            inputs = new int[16];
            weights = new double[16,16];
            outputs = new double[16];
            map = new int[16];
            grid_A = new Button[4, 4];
            grid_B = new Button[4, 4];

            grid_A[0, 0] = button1;
            grid_A[0, 1] = button2;
            grid_A[0, 2] = button3;
            grid_A[0, 3] = button4;

            grid_A[1, 0] = button20;
            grid_A[1, 1] = button19;
            grid_A[1, 2] = button18;
            grid_A[1, 3] = button17;

            grid_A[2, 0] = button30;
            grid_A[2, 1] = button29;
            grid_A[2, 2] = button28;
            grid_A[2, 3] = button27;

            grid_A[3, 0] = button40;
            grid_A[3, 1] = button39;
            grid_A[3, 2] = button38;
            grid_A[3, 3] = button37;

            grid_B[0, 0] = button6;
            grid_B[0, 1] = button7;
            grid_B[0, 2] = button8;
            grid_B[0, 3] = button9;

            grid_B[1, 0] = button10;
            grid_B[1, 1] = button11;
            grid_B[1, 2] = button12;
            grid_B[1, 3] = button13;

            grid_B[2, 0] = button14;
            grid_B[2, 1] = button15;
            grid_B[2, 2] = button16;
            grid_B[2, 3] = button21;

            grid_B[3, 0] = button22;
            grid_B[3, 1] = button23;
            grid_B[3, 2] = button24;
            grid_B[3, 3] = button25;
        }

        void init()
        {
            for (int i = 0; i < maxCells; i++)
            {
                for (int j = 0; j < weightAct; j++)
                {
                    weights[i, j] = 0.0;
                }
            }
        }

        void computeAct()
        {
            int outA;
            int weight;

            for (outA = 0; outA < maxCells; outA++)
            {
                outputs[outA] = 0.0;

                for (weight = 0; weight < weightAct; weight++)
                {
                    outputs[outA] += (weights[outA, weight] * (double)inputs[weight]);
                }

                if (outputs[outA] < 0.0)
                {
                    outputs[outA] = 1.0;
                }
                else
                {
                    outputs[outA] = -1.0;
                }
            }
        }


        void definePat(int[] inp)
        {
            for (int i = 0; i < maxCells; i++)
            {
                inputs[i] = inp[i];
                outputs[i] = (double)inp[i];
            }
        }

        void adjWeights()
        {
            for (int outW = 0; outW < maxCells; outW++)
            {
                for (int weight = 0; weight < weightAct; weight++)
                {
                    weights[outW, weight] += eta * (outputs[outW] * (double)inputs[weight]);
                }
            }
        }


        Color digit(double outp)
        {
            if (outp > 0.0)
            {
                return Color.FromArgb(224, 224, 224);
            }
            else
            {
                return Color.CornflowerBlue;
            }
        }

        public void tabStop()
        {
            #region tabstop

            button1.TabStop = false;
            button2.TabStop = false;
            button3.TabStop = false;
            button4.TabStop = false;
            button6.TabStop = false;
            button7.TabStop = false;
            button8.TabStop = false;
            button9.TabStop = false;
            button10.TabStop = false;
            button11.TabStop = false;
            button12.TabStop = false;
            button13.TabStop = false;
            button14.TabStop = false;
            button15.TabStop = false;
            button16.TabStop = false;
            button17.TabStop = false;
            button18.TabStop = false;
            button19.TabStop = false;
            button20.TabStop = false;
            button21.TabStop = false;
            button22.TabStop = false;
            button23.TabStop = false;
            button24.TabStop = false;
            button25.TabStop = false;
            button27.TabStop = false;
            button28.TabStop = false;
            button29.TabStop = false;
            button30.TabStop = false;
            button37.TabStop = false;
            button38.TabStop = false;
            button39.TabStop = false;
            button40.TabStop = false;
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.FromArgb(224, 224, 224))
            {
                button1.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button1.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.FromArgb(224, 224, 224))
            {
                button2.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button2.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.FromArgb(224, 224, 224))
            {
                button3.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button3.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.FromArgb(224, 224, 224))
            {
                button4.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button4.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.BackColor == Color.FromArgb(224, 224, 224))
            {
                button17.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button17.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (button18.BackColor == Color.FromArgb(224, 224, 224))
            {
                button18.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button18.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (button19.BackColor == Color.FromArgb(224, 224, 224))
            {
                button19.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button19.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.BackColor == Color.FromArgb(224, 224, 224))
            {
                button20.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button20.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (button30.BackColor == Color.FromArgb(224, 224, 224))
            {
                button30.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button30.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (button29.BackColor == Color.FromArgb(224, 224, 224))
            {
                button29.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button29.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (button28.BackColor == Color.FromArgb(224, 224, 224))
            {
                button28.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button28.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (button27.BackColor == Color.FromArgb(224, 224, 224))
            {
                button27.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button27.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (button37.BackColor == Color.FromArgb(224, 224, 224))
            {
                button37.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button37.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (button38.BackColor == Color.FromArgb(224, 224, 224))
            {
                button38.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button38.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (button39.BackColor == Color.FromArgb(224, 224, 224))
            {
                button39.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button39.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (button40.BackColor == Color.FromArgb(224, 224, 224))
            {
                button40.BackColor = Color.CornflowerBlue;
            }
            else
            {
                button40.BackColor = Color.FromArgb(224, 224, 224);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabStop();
            
            init();

            int[] pattern_1 = {-1,1,1,-1,
                                  1,-1,-1,1,
                                  1,-1,-1,1,
                                  -1,1,1,-1
                              };

            definePat(pattern_1);
            adjWeights();

            int[] pattern_2 = { -1,-1,-1,-1,
                                  -1,1,1,-1,
                                  -1,1,1,-1,
                                  -1,-1,-1,-1
                              };

            definePat(pattern_2);
            adjWeights();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int z = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid_A[i, j].BackColor == Color.CornflowerBlue)
                    {
                        map[z] = 1;
                    }
                    else
                    {
                        map[z] = -1;
                    }
                    z++;
                }
            }

            definePat(map);
            computeAct();

            z = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    grid_B[i, j].BackColor = digit(outputs[z]);
                    z++;
                }
            }
        }
    }
}
