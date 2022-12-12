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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(richTextBox1.Text), i;
            richTextBox1.Clear();
            richTextBox2.Clear();
            for(i=1; i<=n; i++)
            {
                if (i % 3 == 0)
                    richTextBox2.AppendText(i + " Hello\n");
                else if(i % 5 == 0)
                    richTextBox2.AppendText(i + " Welcome\n");
                else
                    richTextBox2.AppendText(i + "\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Task2 = new Form3();
            Task2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 Task4 = new Form4();
            Task4.Show();
        }
    }
}
