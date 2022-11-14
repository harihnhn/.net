using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_nov_10
{
    public partial class page2 : Form
    {
        public page2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result;
            int m1 = int.Parse(textBox1.Text);
            int m2 = int.Parse(textBox2.Text);
            int m3 = int.Parse(textBox3.Text);
            int m4 = int.Parse(textBox4.Text);
            int m5 = int.Parse(textBox5.Text);
            
            //check pass or fail
            if((m1>=35) && (m2>=35) && (m3 >= 35) && (m4 >= 35) && (m5 >= 35))
            {
                result = "Pass";
            }
            else
            {
                result = "Fail";
            }

            //total calculation
            int tot = m1 + m2 + m3 + m4 + m5;

            //average calculation
            int average = tot / 5;

            //percentage
            int percentage = tot / (500 / 100);

            MessageBox.Show("Result = " + result + "\ntotal marks = " + tot +
                "\npercentage = " + percentage + "\naverage = " + average);
        }
    }
}
