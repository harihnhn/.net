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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5];

            //get input from textBox
            arr[0] = Convert.ToInt32(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = Convert.ToInt32(textBox5.Text);

            //swap
            arr[2] += arr[4];
            arr[4] = arr[2] - arr[4];
            arr[2] -= arr[4];

            //print output
            richTextBox1.Clear();
            for (int i = 0; i< arr.Length; i++)            
                richTextBox1.AppendText(arr[i] + " ");            
        }
    }
}
