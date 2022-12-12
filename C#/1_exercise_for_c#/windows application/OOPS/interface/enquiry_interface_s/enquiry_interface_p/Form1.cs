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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_form student = new student_form();
            employee_form employee = new employee_form();
            passport_form airport = new passport_form();
            hospital_form hospital = new hospital_form();
            if (radioButton1.Checked == true)
                student.Show();
            else if (radioButton2.Checked == true)
                employee.Show();
            else if (radioButton3.Checked == true)
                airport.Show();
            else if (radioButton4.Checked == true)
                hospital.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
