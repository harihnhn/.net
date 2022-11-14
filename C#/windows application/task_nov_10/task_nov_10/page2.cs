using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_nov_10
{
    public partial class page2 : Form
    {
        public page2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name = textBox1.Text;
            //int age = int.Parse(textBox2.Text);
            int age = Convert.ToInt32(textBox2.Text);

            if (age >= 18)
                MessageBox.Show("Congratulations " + user_name + "!!!\n You are eligible for voting!!!");
            else
                MessageBox.Show("Sorry " + user_name + "!!!\n You are not eligible for voting!!!");
        }
    }
}

