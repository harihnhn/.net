using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_14_project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(richTextBox1.Text), i = 1, n1=n;
            long fact = 1;
            richTextBox1.Clear();
            richTextBox2.Clear();
            while(i<=n)
            {
                fact = fact * i;
                i++;
            }
            richTextBox2.AppendText(n1 + "! = " + fact.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Task1 = new Form2();
            Task1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Task3 = new Form4();
            Task3.Show();
        }
    }
}