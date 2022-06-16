﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensyu
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {
                vx = 10;
            }

            if(label1.Top < 0)
            {
                vy = 10;
            }

            if (label1.Right > ClientSize.Width)
            {
                vx = -10;
            }

            if (label1.Bottom > ClientSize.Height)
            {
                vy = -10;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = -5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           vx = -5;
           vy = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           vx = 0;
           vy = 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vx = 5;
            vy = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("荒川　龍");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vx = -vx;
        }
    }
}
