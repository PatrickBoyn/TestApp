﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        double input1, input2;
        double answer;


        private void button1_Click(object sender, EventArgs e)
        {
            addition();   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subtraction();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            multiplacation();
        }

        private void addition()
        {
            input1 = double.Parse(valueOne.Text);
            input2 = double.Parse(valueTwo.Text);

            answer = input1 + input2;

            label1.Text = answer.ToString();
        }

        private void subtraction()
        {
            input1 = double.Parse(valueOne.Text);
            input2 = double.Parse(valueTwo.Text);

            answer = input1 - input2;

            label1.Text = answer.ToString();
        }
        private void multiplacation()
        {
            input1 = double.Parse(valueOne.Text);
            input2 = double.Parse(valueTwo.Text);

            answer = input1 * input2;

            label1.Text = answer.ToString();
        }
    }
}
