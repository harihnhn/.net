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
    public partial class employee_form : Form
    {
        public employee_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //employee e = new employee();
            employee ee = new employee();

            ee.name = textBox1.Text;

            ee.age = int.Parse(textBox2.Text);

            ee.gender = textBox3.Text;

            ee.exp = int.Parse(textBox4.Text);
            
            ee.job = (radioButton1.Checked) ? 1 : (radioButton2.Checked) ? 2 : 3;

            ee.mob_no = long.Parse(textBox5.Text);

            ee.add = richTextBox1.Text;

            richTextBox2.Clear();
            richTextBox2.AppendText(
                "\nName : " + ee.name +
                "\nAge :" + ee.age +
                "\nGender :" + ee.gender +
                "\nDesignation :" + ((ee.job == 1) ? ".Net developer" : (ee.job == 2) ? "Java developer" : "fullstack developer" ) + 
                "\nMobile No. :" + ee.mob_no + 
                "\nAddress :" + ee.add
                );

            MessageBox.Show("before close this msg box check the details in output box");
            ee.calc_amt();
            richTextBox2.Clear();
            //show output
            richTextBox2.AppendText("Hello " + ee.name + "\n Your salay : Rs. " + ee.amt);


        }
    }
}
