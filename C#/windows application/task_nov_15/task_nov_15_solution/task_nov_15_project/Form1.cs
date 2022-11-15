using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_15_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text;
            long regno = long.Parse(textBox2.Text);
            int m1 = int.Parse(textBox3.Text);
            int m2 = int.Parse(textBox4.Text);
            int m3 = int.Parse(textBox5.Text);
            int m4 = int.Parse(textBox6.Text);
            int m5 = int.Parse(textBox7.Text);
            //int avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if(m1>34 && m2>34 && m3>34 && m4>34 && m5>34)
                MessageBox.Show("Name: " + sname + "\nReg.No: " + regno + "\n\nRESULT = \"PASS\"");
            else
                MessageBox.Show("Name: " + sname + "\nReg.No: " + regno + "\n\nRESULT = \"FAIL\"");  
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text;
            long regno = long.Parse(textBox2.Text);
            int m1 = int.Parse(textBox3.Text);
            int m2 = int.Parse(textBox4.Text);
            int m3 = int.Parse(textBox5.Text);
            int m4 = int.Parse(textBox6.Text);
            int m5 = int.Parse(textBox7.Text);
            textBox8.Text = (m1+m2+m3+m4+m5).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        /*
            string sname = textBox1.Text;
            long regno = int.Parse(textBox2.Text);
            int m1 = int.Parse(textBox3.Text);
            int m2 = int.Parse(textBox4.Text);
            int m3 = int.Parse(textBox5.Text);
            int m4 = int.Parse(textBox6.Text);
            int m5 = int.Parse(textBox7.Text);
        */
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text;
            long regno = long.Parse(textBox2.Text);
            int m1 = int.Parse(textBox3.Text);
            int m2 = int.Parse(textBox4.Text);
            int m3 = int.Parse(textBox5.Text);
            int m4 = int.Parse(textBox6.Text);
            int m5 = int.Parse(textBox7.Text);
            int avg = (m1 + m2 + m3 + m4 + m5) / 5;
            MessageBox.Show("Name : " + sname + "\nReg.No : " + regno +"\n\nAVERAGE = " + avg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text;
            long regno = long.Parse(textBox2.Text);
            int m1 = int.Parse(textBox3.Text);
            int m2 = int.Parse(textBox4.Text);
            int m3 = int.Parse(textBox5.Text);
            int m4 = int.Parse(textBox6.Text);
            int m5 = int.Parse(textBox7.Text);
            int avg = (m1 + m2 + m3 + m4 + m5) / 5;

            if (avg > 89)
                MessageBox.Show("Name : " + sname + "\nReg.No : " + regno + "\n\nGRADE = \"O\"");
            else if (avg > 79)
                MessageBox.Show("Name : " + sname + "\nReg.No : " + regno + "\n\nGRADE = \"A+\"");
            else if (avg > 69)
                MessageBox.Show("Name : " + sname + "\nReg.No : " + regno + "\n\nGRADE = \"A\"");
            else if (avg > 59)
                MessageBox.Show("Name : " + sname + "\nReg.No : " + regno + "\n\nGRADE = \"B+\"");
            else if (avg > 49)
                MessageBox.Show("Name : " + sname + "\nReg.No : " + regno + "\n\nGRADE = \"B\"");
            else
                MessageBox.Show("Name : " + sname + "\nReg.No : " + regno + "\n\nGRADE = \"U\"");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
