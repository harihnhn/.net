using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_16_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Elements without \"0\":");
            int[] arr = new int[5];

            arr[0] = int.Parse(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = int.Parse(textBox5.Text);
            
            for(int i=0; i<arr.Length; i++)            
                if (arr[i]!=0)                
                    listBox1.Items.Add(arr[i]);                   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Sum of odd numbers:");
            int[] arr = new int[5];
            int sum = 0;

            arr[0] = int.Parse(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = int.Parse(textBox5.Text);

            for (int i = 0; i < arr.Length; i++)
                if (arr[i]%2 != 0)
                    sum = sum + arr[i];

            listBox1.Items.Add(sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Sum of even numbers:");
            int[] arr = new int[5];
            int sum = 0;

            arr[0] = int.Parse(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = int.Parse(textBox5.Text);

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] % 2 == 0)
                    sum = sum + arr[i];

            listBox1.Items.Add(sum);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Average:");
            int[] arr = new int[5];
            int sum = 0, avg;

            arr[0] = int.Parse(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = int.Parse(textBox5.Text);

            for (int i = 0; i < arr.Length; i++)                  
                sum = sum + arr[i];

            avg = sum/ arr.Length;

            listBox1.Items.Add(avg);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("\"5\" divisible elements:");
            int[] arr = new int[5];
            bool flag = true;

            arr[0] = int.Parse(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = int.Parse(textBox5.Text);

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 5 == 0)
                {
                    listBox1.Items.Add(arr[i]);
                    flag = false;
                }
            }
                
            if (flag)
            {
                listBox1.Items.Add("No \"5\" divisible in the array elements");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Assending order:");
            int i;
            int[] arr = new int[5];
            bool flag;

            arr[0] = int.Parse(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = int.Parse(textBox5.Text);

            //bubble sort
            do
            {
                flag = false;
                for (i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        arr[i] = arr[i] + arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] = arr[i] - arr[i + 1];
                        flag = true;
                    }
                }
            }
            while(flag);

            //to print output
            for(i = 0; i<arr.Length; i++)
                listBox1.Items.Add(arr[i]);             
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Descending order:");
            int i;
            int[] arr = new int[5];
            bool flag;

            arr[0] = int.Parse(textBox1.Text);
            arr[1] = Convert.ToInt32(textBox2.Text);
            arr[2] = Convert.ToInt32(textBox3.Text);
            arr[3] = Convert.ToInt32(textBox4.Text);
            arr[4] = int.Parse(textBox5.Text);

            do
            {
                flag = false;
                for (i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        arr[i] = arr[i] + arr[i + 1];
                        arr[i + 1] = arr[i] - arr[i + 1];
                        arr[i] = arr[i] - arr[i + 1];
                        flag = true;
                    }
                }
            }
            while (flag);

            for (i = 0; i < arr.Length; i++)
                listBox1.Items.Add(arr[i]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
