﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = (Form3.arrayresult2d[0,0]).ToString();
            label2.Text = (Form3.arrayresult2d[0, 1]).ToString();
            label3.Text = (Form3.arrayresult2d[0, 2]).ToString();
            label4.Text = (Form3.arrayresult2d[1, 0]).ToString();
            label5.Text = (Form3.arrayresult2d[1, 1]).ToString();
            label6.Text = (Form3.arrayresult2d[1, 2]).ToString();
            label7.Text = (Form3.arrayresult2d[2, 0]).ToString();
            label8.Text = (Form3.arrayresult2d[2, 1]).ToString();
            label9.Text = (Form3.arrayresult2d[2, 2]).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
