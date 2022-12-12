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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(richTextBox1.Text),n1, sum = 0, i=0,j;
            int[] arr = new int[100];
            richTextBox1.Clear();
            richTextBox2.Clear();
            while(n>0)
            {
                n1 = n % 10;
                sum = sum + n1;
                n = n / 10;
                arr[i] = n1;
                i++;
            }
            for(j=i-1; j>0; j--)
                richTextBox2.AppendText(arr[j].ToString() + " + ");

            richTextBox2.AppendText(arr[j].ToString() + " = " + sum);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Task1 = new Form2();
            Task1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 Task2 = new Form3();
            Task2.Show();
        }
    }
}
