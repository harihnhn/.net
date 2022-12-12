using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int i,j;
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] sum_arr = new int[3, 3];

            arr1[0, 0] = int.Parse(textBox1.Text);
            arr1[0, 1] = int.Parse(textBox2.Text);
            arr1[0, 2] = int.Parse(textBox3.Text);
            arr1[1, 0] = int.Parse(textBox6.Text);
            arr1[1, 1] = int.Parse(textBox5.Text);
            arr1[1, 2] = int.Parse(textBox4.Text);
            arr1[2, 0] = int.Parse(textBox18.Text);
            arr1[2, 1] = int.Parse(textBox17.Text);
            arr1[2, 2] = int.Parse(textBox16.Text);

            arr2[0, 0] = int.Parse(textBox12.Text);
            arr2[0, 1] = int.Parse(textBox11.Text);
            arr2[0, 2] = int.Parse(textBox10.Text);
            arr2[1, 0] = int.Parse(textBox9.Text);
            arr2[1, 1] = int.Parse(textBox8.Text);
            arr2[1, 2] = int.Parse(textBox7.Text);
            arr2[2, 0] = int.Parse(textBox15.Text);
            arr2[2, 1] = int.Parse(textBox14.Text);
            arr2[2, 2] = int.Parse(textBox13.Text);

            richTextBox1.AppendText("Sum of two array:\n");
            for (i=0; i<3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum_arr[i,j] = arr1[i,j] + arr2[i,j];
                    richTextBox1.AppendText(sum_arr[i, j] + "\t");                 
                }
                richTextBox1.AppendText("\n\n");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int i, j;
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] sub_arr = new int[3, 3];

            arr1[0, 0] = int.Parse(textBox1.Text);
            arr1[0, 1] = int.Parse(textBox2.Text);
            arr1[0, 2] = int.Parse(textBox3.Text);
            arr1[1, 0] = int.Parse(textBox6.Text);
            arr1[1, 1] = int.Parse(textBox5.Text);
            arr1[1, 2] = int.Parse(textBox4.Text);
            arr1[2, 0] = int.Parse(textBox18.Text);
            arr1[2, 1] = int.Parse(textBox17.Text);
            arr1[2, 2] = int.Parse(textBox16.Text);

            arr2[0, 0] = int.Parse(textBox12.Text);
            arr2[0, 1] = int.Parse(textBox11.Text);
            arr2[0, 2] = int.Parse(textBox10.Text);
            arr2[1, 0] = int.Parse(textBox9.Text);
            arr2[1, 1] = int.Parse(textBox8.Text);
            arr2[1, 2] = int.Parse(textBox7.Text);
            arr2[2, 0] = int.Parse(textBox15.Text);
            arr2[2, 1] = int.Parse(textBox14.Text);
            arr2[2, 2] = int.Parse(textBox13.Text);

            richTextBox1.AppendText("Subtraction of two array:\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sub_arr[i, j] = arr1[i, j] - arr2[i, j];
                    richTextBox1.AppendText(sub_arr[i, j] + "\t");
                }
                richTextBox1.AppendText("\n\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int i, j, k, sum;
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] mul_arr = new int[3, 3];

            arr1[0, 0] = int.Parse(textBox1.Text);
            arr1[0, 1] = int.Parse(textBox2.Text);
            arr1[0, 2] = int.Parse(textBox3.Text);
            arr1[1, 0] = int.Parse(textBox6.Text);
            arr1[1, 1] = int.Parse(textBox5.Text);
            arr1[1, 2] = int.Parse(textBox4.Text);
            arr1[2, 0] = int.Parse(textBox18.Text);
            arr1[2, 1] = int.Parse(textBox17.Text);
            arr1[2, 2] = int.Parse(textBox16.Text);

            arr2[0, 0] = int.Parse(textBox12.Text);
            arr2[0, 1] = int.Parse(textBox11.Text);
            arr2[0, 2] = int.Parse(textBox10.Text);
            arr2[1, 0] = int.Parse(textBox9.Text);
            arr2[1, 1] = int.Parse(textBox8.Text);
            arr2[1, 2] = int.Parse(textBox7.Text);
            arr2[2, 0] = int.Parse(textBox15.Text);
            arr2[2, 1] = int.Parse(textBox14.Text);
            arr2[2, 2] = int.Parse(textBox13.Text);

            richTextBox1.AppendText("Matrix multiplication:\n");
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    sum =0;
                    for(k=0;k<3;k++)
                    {
                        sum = sum + (arr1[i, k] * arr2[k, j]);
                    }
                    mul_arr[i,j] = sum;
                    richTextBox1.AppendText(mul_arr[i, j] + "\t");
                }
                richTextBox1.AppendText("\n\n");
            }
        }
    }
}
