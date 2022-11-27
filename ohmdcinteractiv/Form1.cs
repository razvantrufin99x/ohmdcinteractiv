using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ohmdcinteractiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float text2float(TextBox t)
        {
            try
            {
                return float.Parse(t.Text);
            }
            catch { }

            return -1;
        }

        void float2text(float x, TextBox t)
        {
            try
            {
                t.Text = x.ToString();
            }
            catch { }
                       
        }

        float U = 0, I = 0, R = 0, T = 0, W = 0, P = 0;

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            R = text2float(txtR);
            trackBar1.Value = (int)R;
        }

        private void txtU_TextChanged(object sender, EventArgs e)
        {
            U = text2float(txtU);
            trackBar2.Value = (int)U;
        }

        private void txtI_TextChanged(object sender, EventArgs e)
        {
            I = text2float(txtI);
            trackBar3.Value = (int)I;
        }

        private void txtP_TextChanged(object sender, EventArgs e)
        {
            P = text2float(txtP);
            trackBar4.Value = (int)P;
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {
            T = text2float(txtT);
            trackBar5.Value = (int)T;
        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {
            W = text2float(txtW);
            trackBar6.Value = (int)W;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            R = U / I;
            float2text(R, txtR);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            U = R * I;
            float2text(U, txtU);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            I = U / R;
            float2text(I, txtI);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            P =  U * I;
            float2text(P, txtP);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            T = P / W;
            float2text(T, txtT);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            W = P * T;
            float2text(W, txtW);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txtR.Text = trackBar1.Value.ToString();
            I = U / R;
            float2text(I, txtI);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtU.Text = trackBar2.Value.ToString();
            I = U / R;
            float2text(I, txtI);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtI.Text = trackBar3.Value.ToString();
            R = U / I;
            float2text(R, txtR);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            txtP.Text = trackBar4.Value.ToString();
            W = P * T;
            float2text(W, txtW);
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            txtT.Text = trackBar5.Value.ToString();
            W = P * T;
            float2text(W, txtW);
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            txtW.Text = trackBar6.Value.ToString();
            P = text2float(txtP);
            trackBar4.Value = (int)P;

        }
    }
}
