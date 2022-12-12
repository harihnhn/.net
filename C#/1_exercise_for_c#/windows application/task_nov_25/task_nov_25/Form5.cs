using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_25
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr1, arr2, arr3;
            int i, j, k;
            arr1 = new int[5];
            arr2 = new int[5];
            arr3 = new int[arr1.Length];
            bool flag;

            //get input from textBox
            arr1[0] = int.Parse(textBox1.Text);
            arr1[1] = int.Parse(textBox2.Text);
            arr1[2] = int.Parse(textBox3.Text);
            arr1[3] = int.Parse(textBox4.Text);
            arr1[4] = int.Parse(textBox5.Text);

            arr2[0] = int.Parse(textBox10.Text);
            arr2[1] = int.Parse(textBox9.Text);
            arr2[2] = int.Parse(textBox8.Text);
            arr2[3] = int.Parse(textBox7.Text);
            arr2[4] = int.Parse(textBox6.Text);

            //A - B
            k = 0;
            for(i =0; i< arr1.Length; i++) 
            {
                flag = true;
                for(j = 0 ; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                        flag = false;
                }
                if(flag)
                    arr3[k++] = arr1[i];
            }

            //print OUTPUT
            for (i = 0; i < k; i++)
                richTextBox1.AppendText(arr3[i] + " ");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] arr1, arr2, arr3;
            int i, j, k;
            arr1 = new int[5];
            arr2 = new int[5];
            arr3 = new int[arr1.Length];
            bool flag;

            //get input from textBox
            arr1[0] = int.Parse(textBox1.Text);
            arr1[1] = int.Parse(textBox2.Text);
            arr1[2] = int.Parse(textBox3.Text);
            arr1[3] = int.Parse(textBox4.Text);
            arr1[4] = int.Parse(textBox5.Text);

            arr2[0] = int.Parse(textBox10.Text);
            arr2[1] = int.Parse(textBox9.Text);
            arr2[2] = int.Parse(textBox8.Text);
            arr2[3] = int.Parse(textBox7.Text);
            arr2[4] = int.Parse(textBox6.Text);

            //A - B
            k = 0;
            for (i = 0; i < arr2.Length; i++)
            {
                flag = true;
                for (j = 0; j < arr1.Length; j++)                
                    if (arr2[i] == arr1[j])
                        flag = false;  
                
                if (flag)
                    arr3[k++] = arr2[i];
            }

            //print OUTPUT
            richTextBox1.Clear();
            for (i = 0; i < k; i++)
                richTextBox1.AppendText(arr3[i] + " ");
        }
    }
}
