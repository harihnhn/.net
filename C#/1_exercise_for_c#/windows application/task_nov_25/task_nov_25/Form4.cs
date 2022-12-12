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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[5];
            bool flag = true;

            //get input from textBox
            arr[0] = Convert.ToInt32(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = Convert.ToInt32(textBox5.Text);

            //check the given array is consecutive array or not
            for(int i = 1; i< arr.Length; i++)            
                if (!(arr[i] == (arr[i-1] + 1)))
                    flag = false;

            //print output 
            richTextBox1.Clear();
            if (flag)
                richTextBox1.AppendText("Given array is \"Consecutive array\"");
            else
                richTextBox1.AppendText("Given array is \"Not Consecutive array\"");
        }
    }
}
