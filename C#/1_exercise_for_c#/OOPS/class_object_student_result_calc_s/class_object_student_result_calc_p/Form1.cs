using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace class_object_student_result_calc_p
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s1 = new student(); //object 1 created for class
            s1.sname = textBox1.Text;
            s1.reg_no = long.Parse(textBox2.Text);
            s1.m1 = long.Parse(textBox3.Text);
            s1.m2 = long.Parse(textBox4.Text);
            s1.m3 = long.Parse(textBox5.Text);
            s1.m4 = long.Parse(textBox6.Text);
            s1.m5 = long.Parse(textBox7.Text);
            s1.result_calc();
            //MessageBox.Show(s1.tot + "\n" + s1.avg + "\n" + s1.per + "\n" + s1.grade + "\n" + s1.result);
            textBox14.Text = s1.sname.ToString();
            textBox13.Text = s1.reg_no.ToString();
            textBox12.Text = s1.tot.ToString();
            textBox11.Text = s1.avg.ToString();
            textBox10.Text = s1.per.ToString();
            textBox9.Text = s1.grade.ToString();
            textBox8.Text = s1.result.ToString();
        }
    }
}
