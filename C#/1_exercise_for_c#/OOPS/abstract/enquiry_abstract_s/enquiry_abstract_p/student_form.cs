using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enquiry_abstract_p
{
    public partial class student_form : Form
    {
        public student_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //create object 
            student s = new student();

            //get input
            s.name = textBox1.Text;

            s.age = int.Parse(textBox2.Text);

            s.gender = textBox3.Text;

            s.qualification = textBox4.Text;

            if (checkBox1.Checked == true)
                s.course1 = true;
            if (checkBox2.Checked == true)
                s.course2 = true;
            if (checkBox3.Checked == true)
                s.course3 = true;

            s.mob_no = long.Parse(textBox5.Text);

            s.add = richTextBox1.Text;

            richTextBox2.Clear();
            richTextBox2.AppendText("Name : " + s.name + "\nAge :" + s.age + "\nGender :" + s.gender +
                "\nCourse 1 :" + s.course1 + "\nCourse 2:" + s.course2 + "\nCourse 3 :" + s.course3 +
                "\nMobile No. :" + s.mob_no + "\nAddress :" + s.add);
            MessageBox.Show("before close this msg box check the details in output box");
            s.calc_amt();
            richTextBox2.Clear();
            //show output
            richTextBox2.AppendText("Hello " + s.name + "\n Your course fees : Rs. " + s.amt);
        }

        
    }
}