using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string input1, input2;
            int answer;

            input1 = valueOne.Text;
            input2 = valueTwo.Text;

            answer = int.Parse(input1 + input2);

            label1.Text = answer.ToString();
            

        }
    }
}
