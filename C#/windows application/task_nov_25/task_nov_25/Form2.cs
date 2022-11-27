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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr1, arr2, arr3;
            int i, j, k;
            arr1 = new int[5];
            arr2 = new int[5];
            arr3 = new int[arr1.Length+arr2.Length];

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

            //Merge
            j =0;
            k =0;
            for(i = 0; i< arr3.Length; i++)
            {
                if(i%2 == 0)
                    arr3[i] = arr1[j++];
                else
                    arr3[i] = arr2[k++];
            }

            //print output
            textBox15.Text = arr3[0].ToString();
            textBox14.Text = arr3[1].ToString();
            textBox13.Text = arr3[2].ToString();
            textBox12.Text = arr3[3].ToString();
            textBox11.Text = arr3[4].ToString();
            textBox20.Text = arr3[5].ToString();
            textBox19.Text = arr3[6].ToString();
            textBox18.Text = arr3[7].ToString();
            textBox17.Text = arr3[8].ToString();
            textBox16.Text = arr3[9].ToString();

        }
    }
}
